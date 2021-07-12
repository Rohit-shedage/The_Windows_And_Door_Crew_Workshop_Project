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
    public partial class frm_Manage_Customer : Form
    {
        public frm_Manage_Customer()
        {
            InitializeComponent();
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

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Mdi_Parent(new frm_Add_Customer_Details(Globalvar));
        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Show_Mdi_Parent(new frm_Add_Customer_Details());
        }

        private void frm_Manage_Customer_Load(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                dgv_Manage_Customer.DataSource = (from u in db.Customers select u).ToList();
            }
            
        }

        private void dgv_Manage_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Globalvar = Convert.ToInt32(dgv_Manage_Customer.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btn_Delete_Customer_Click(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var Cust = db.Customers.Find(Globalvar);

                db.Customers.Remove(Cust);
                db.SaveChanges();
                dgv_Manage_Customer.DataSource = (from u in db.Customers select u).ToList();
            }

            MessageBox.Show("Record Deleted Successfully...!!!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
