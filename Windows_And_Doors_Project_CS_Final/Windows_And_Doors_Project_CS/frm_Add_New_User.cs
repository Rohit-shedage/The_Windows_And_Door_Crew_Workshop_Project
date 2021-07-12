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
    public partial class frm_Add_New_User : Form
    {
        public frm_Add_New_User()
        {
            InitializeComponent();
            AutoIncrementID();
        }

        private void AutoIncrementID()
        {
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                int? ID = db.Users.Max(i => (int?)i.User_Id);

                if (ID != null)
                {
                    tb_ID.Text = (ID + 1).ToString();
                }
                else
                {
                    tb_ID.Text = "1";
                }
            }
        }

        private int SearchID = 0;
        public frm_Add_New_User(int iNo)
        {
            InitializeComponent();
            SearchID = iNo;
            lbl_Header.Text = "Update User";
            btn_Save.Text = "Update";
            tb_ID.Enabled = true;
            btn_Search.Visible = true;
            if (SearchID != 0)
            {
                Search(SearchID);
            }
        }

        private void ClearControls()
        {
            
            foreach (Control control in tbl_User_Details.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
            }
            cmb_Treat_As.Text = "";
        }
        private void Search(int iNo)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var User = db.Users.Find(iNo);

                if (User != null)
                {
                    tb_ID.Text = Convert.ToString(User.User_Id);
                    tb_Username.Text = User.UserName;
                    tb_Password.Text = User.Password;
                    tb_Confirm_Password.Text = User.Password;
                    cmb_Treat_As.Text = User.Treat_AS;
                    tb_Security_Key.Text = User.Security_Key;
                    tb_Date.Text = User.Created_Date.ToString("dd-MM-yyyy");
                    MessageBox.Show("Record Search Successfully..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Enter Valid ID","Failure",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    ClearControls();
                    tb_ID.Text = "";
                    tb_Date.Text = "";
                }
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            int iNo = Convert.ToInt32(tb_ID.Text);
            Search(iNo);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Add_New_User_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "Save")
            {
                DateTime Date = Convert.ToDateTime(tb_Date.Text);
                using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                {
                    db.Users.Add(new User { Created_Date = Date, UserName = tb_Username.Text, Password = tb_Confirm_Password.Text, Treat_AS = cmb_Treat_As.Text, Security_Key = tb_Security_Key.Text });
                    db.SaveChanges();
                }

                MessageBox.Show("Record Save Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                AutoIncrementID();
            }
            else
            {
                int ID = Convert.ToInt32(tb_ID.Text);
                using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                {
                    var User = db.Users.Find(ID);

                    if (User != null)
                    {
                        User.UserName = tb_Username.Text;
                        User.Password = tb_Confirm_Password.Text;
                        User.Treat_AS = cmb_Treat_As.Text;
                        User.Security_Key = tb_Security_Key.Text;
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Record Update Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                tb_ID.Text = "";
                tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }
          
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
