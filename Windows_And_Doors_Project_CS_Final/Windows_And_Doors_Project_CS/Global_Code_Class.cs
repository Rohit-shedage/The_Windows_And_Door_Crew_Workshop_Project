using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_And_Doors_Project_CS
{
    class Global_Code_Class
    {
        private Form ActiveForm = null;

        public void OpenChildForm(Form ChildForm,Panel Pnlstr)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            Pnlstr.Controls.Add(ChildForm);
            Pnlstr.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }
    }
}
