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
    public partial class frm_Manage_Stock : Form
    {

        int OrderID = 0;
        public frm_Manage_Stock()
        {
            InitializeComponent();

            using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
            {
                dgv_View_Stock_Details.DataSource = DB.Stock_Order.ToList();
            }
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


        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Stock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do You Want To Delete This Order ?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_Stock(OrderID));
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_Stock());
            this.Hide();
        }

        private void dgv_View_Stock_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderID = Convert.ToInt32(dgv_View_Stock_Details.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}
