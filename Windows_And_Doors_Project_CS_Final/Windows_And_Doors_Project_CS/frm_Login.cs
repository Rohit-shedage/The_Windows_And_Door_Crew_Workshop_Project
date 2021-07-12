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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successfull....!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_MDI_Main_Form MDIObj = new frm_MDI_Main_Form();
                frm_Lobby LObj = new frm_Lobby();
                
                
                this.Close();
                if (LObj.Visible == true)
                {
                    LObj.Close();
                }
               
                MDIObj.Show();
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
