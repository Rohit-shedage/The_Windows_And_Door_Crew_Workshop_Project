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
    public partial class frm_Manage_Order : Form
    {
        int P_Cnt = 0;
        public frm_Manage_Order()
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

        public frm_Manage_Order(int iNo)
        {
            P_Cnt = iNo;
            InitializeComponent();
            if (P_Cnt == 1)
            {
                lbl_Header.Text = "Accept Money";
            }
            if (P_Cnt == 2)
            {
                lbl_Header.Text = "Cancel Order";
            }
            if (P_Cnt == 3)
            {
                lbl_Header.Text = "View Order";
            }
        }
        

        private void btn_Update_Order_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Accept_New_Order(1));
            this.Hide();
        }

        private void btn_Cancel_Order_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Order(2));
            this.Hide();
        }

        private void btn_Accept_Money_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Order(1));
            this.Hide();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Manage_Order_Load(object sender, EventArgs e)
        {

        }
    }
}
