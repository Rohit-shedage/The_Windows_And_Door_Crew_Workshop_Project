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
    public partial class frm_Manage_Distributor : Form
    {
        public frm_Manage_Distributor()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private int ID = 0;
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

        private void btn_Update_Distributor_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_New_Distributor(ID));
            this.Hide();
        }

        private void btn_Add_Distributor_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_New_Distributor());
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Manage_Distributor_Load(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                dgv_Distributor.DataSource = (from d in db.Distributors select d).ToList();
            }
        }

        private void dgv_Distributor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dgv_Distributor.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
