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
    public partial class frm_Salary : Form
    {
        public frm_Salary()
        {
            InitializeComponent();
        }

        private int P_Cnt = 0;
        public frm_Salary(int iNo)
        {
            InitializeComponent();

            P_Cnt = iNo;
            if (P_Cnt == 1)
            {
                lbl_Header.Text = "Pending Bills";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
