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
    public partial class frm_Lobby : Form
    {
        Global_Code_Class GObj = new Global_Code_Class();
        public frm_Lobby()
        {
            InitializeComponent();
        }

        private void btn_Windows_Images_Click(object sender, EventArgs e)
        {
            GObj.OpenChildForm(new frm_Windows_Images(),pnl_Form_Container);
        }

        private void btn_Doors_Images_Click(object sender, EventArgs e)
        {
            GObj.OpenChildForm(new frm_Doors_Images(), pnl_Form_Container);
        }

        private void btn_Glass_Images_Click(object sender, EventArgs e)
        {
            GObj.OpenChildForm(new frm_Glass_Images(),pnl_Form_Container);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //GObj.OpenChildForm(new frm_Login(), pnl_Form_Container);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successfull....!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_MDI_Main_Form MDIObj = new frm_MDI_Main_Form();
                // frm_Lobby LObj = new frm_Lobby();

                MDIObj.Show();
                this.Hide();
 
            }
            else
            {
                MessageBox.Show("Login UnSuccessfull....!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();
        }
    }
}
