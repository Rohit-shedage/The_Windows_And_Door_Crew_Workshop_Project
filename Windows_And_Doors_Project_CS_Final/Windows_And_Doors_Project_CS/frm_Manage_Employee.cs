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
    public partial class frm_Manage_Employee : Form
    {
        public frm_Manage_Employee()
        {
            InitializeComponent();
        }

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

        private int GlobalVar = 0;
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Employee_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_New_Employee(GlobalVar));
            this.Hide();
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_New_Employee());
            this.Hide();
        }

        private void frm_Manage_Employee_Load(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                dgv_View_Empolyee.DataSource = (from u in db.Employee_Details 
                                                join es in db.Employee_salary on u.Employee_Id equals es.Employee_Id
                                                select new
                                                {
                                                    u.Employee_Id,
                                                    u.Name,
                                                    u.Mobile_No,
                                                    u.Joining_Date,
                                                    u.DOB,
                                                    u.Gender,
                                                    u.Account_No,
                                                    u.Qualification,
                                                    u.Experience,
                                                    es.Post,
                                                    es.Salary,
                                                }
                                                ).ToList();
            }
        }

        private void dgv_View_Empolyee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GlobalVar = Convert.ToInt32(dgv_View_Empolyee.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
