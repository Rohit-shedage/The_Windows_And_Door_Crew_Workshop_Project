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
    public partial class frm_Manage_Product : Form
    {
        public frm_Manage_Product()
        {
            InitializeComponent();
        }

        private int P_ID = 0;

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

       

      

       

        private void frm_Manage_Product_Load(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                dgv_Manage_Product.DataSource = (from p in db.Products select p).ToList();
            }
        }

        private void dgv_Manage_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            P_ID = Convert.ToInt32(dgv_Manage_Product.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btn_Update_Product_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_Product(P_ID));
        }
    }
}
