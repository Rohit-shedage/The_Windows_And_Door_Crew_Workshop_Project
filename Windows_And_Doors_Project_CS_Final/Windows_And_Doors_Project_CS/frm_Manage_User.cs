using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_And_Doors_Project_CS
{
    public partial class frm_Manage_User : Form
    {
        public frm_Manage_User()
        {
            InitializeComponent();

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var Post = (from u in db.Users select u.Treat_AS).ToList();

                //var Post = (List<IEnumerable<char>>)db.Users.Select(u => u.Treat_AS).Distinct();

                foreach (var i in Post)
                {
                    cmb_Post.Items.Add(i);
                }
            }


        }

        private int Globalvar = 0;

        private Form activeForm = null;
        private void Show_Mdi_Parent(Form FObj)
        {
            if (activeForm != null)
            {
                activeForm = null;
            }

            activeForm = FObj;
            activeForm.MdiParent = this.MdiParent;
            activeForm.WindowState = FormWindowState.Maximized;
            activeForm.Show();
        }
        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            
            Show_Mdi_Parent(new frm_Add_New_User(Globalvar));
            this.Hide();
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            
            Show_Mdi_Parent(new frm_Add_New_User());
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Manage_User_Load(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                dgv_Manage_User.DataSource = (from u in db.Users select u).ToList();
            }
          
        }

        private void dgv_Manage_User_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Globalvar = Convert.ToInt32(dgv_Manage_User.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btn_Delete_User_Click(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var User = db.Users.Find(Globalvar);

                db.Users.Remove(User);
                db.SaveChanges();
                dgv_Manage_User.DataSource = (from u in db.Users select u).ToList();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int SearchID = Convert.ToInt32(tb_ID.Text);
           //string Name = tb_Name.Text;

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                //dgv_Manage_User.DataSource = (from u in db.Users.Where((u => (u.User_Id == SearchID && tb_Name.Text == "") || (u.UserName == tb_Name.Text && tb_ID.Text == ""))) select u).ToList();
               
                 dgv_Manage_User.DataSource = (from u in db.Users.Where(u => u.User_Id == SearchID) select u).ToList();
               
            }
        }

        private void cmb_Post_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                dgv_Manage_User.DataSource = (from u in db.Users.Where(u => u.Treat_AS == cmb_Post.Text) select u).ToList();
            }
           
        }
    }
}
