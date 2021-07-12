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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
            AutoIncrement();
        }

        private void AutoIncrement()
        {
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                int? ID = db.Employee_Details.Max(i => (int?)i.Employee_Id);
                if (ID != null)
                {
                    tb_ID.Text = (ID + 1).ToString();
                }
                else
                {
                    tb_ID.Text = "1";
                }
            }
        }

       
        public frm_Add_New_Employee(int iNo)
        {
            InitializeComponent();
          
           
            tbllpnl_Employee_ID.Enabled = true;
            lbl_Header.Text = "Update Employee Details";
            btn_Search.Visible = true;
            btn_Save.Text = "Update";
            tb_ID.Enabled = true;
            btn_Search.Enabled = true;
            btn_Close.Enabled = true;

            if (iNo != 0)
            {
                Search(iNo);
            }
            
            
        }

        private void Search(int ID)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var Emp = db.Employee_Details.Find(ID);

                if (Emp != null)
                {
                    var EmpSal = db.Employee_salary.Find(ID);

                    if (EmpSal != null)
                    {
                        if (Emp.Gender == rbtn_Male.Text)
                        {
                            rbtn_Male.Checked = true;
                        }
                        if (Emp.Gender == rbtn_Female.Text)
                        {
                            rbtn_Female.Checked = true;
                        }

                        tb_ID.Text = Emp.Employee_Id.ToString();
                        tb_Date.Text = Emp.Joining_Date.ToString("dd-MM-yyyy");
                        tb_Name.Text = Emp.Name;
                        tb_Mobile_No.Text = Emp.Mobile_No.ToString();
                        dtp_DOB.Text = Convert.ToDateTime(Emp.DOB).ToString("dd-MM-yyyy");
                        tb_Account_No.Text = Emp.Account_No;
                        tb_Adhaar_No.Text = Emp.Adhaar_No;
                        cmb_Qualification.Text = Emp.Qualification;
                        cmb_Experience.Text = Emp.Experience;
                        cmb_Post.Text = EmpSal.Post;
                        tb_Salary.Text = EmpSal.Salary.ToString();
                        tb_Address.Text = Emp.Address;
                    }

                }
            }
        }

        private void ClearControl()
        {
            foreach  (Control control in tbllpnl_Personal_Details.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
            }
            foreach (Control control in tbllpnl_Other_Panel.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
            }

            foreach (Control control in tbllpnl_Other_Panel.Controls)
            {
                if (control.GetType() == typeof(ComboBox))
                {
                    control.Text = "";
                }
            }

            rbtn_Male.Checked = false;
            rbtn_Female.Checked = false;
            dtp_DOB.Text = null;
        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            
        }

        private void rtbn_Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckItemFill()
        {
            if (tb_Date.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Adhaar_No.Text != "" && tb_Salary.Text != "" && tb_Adhaar_No.Text != "" && tb_Address.Text != "" && tb_Account_No.Text != "" && cmb_Experience.Text != "" && cmb_Post.Text != "" && cmb_Qualification.Text != "" && (rbtn_Male.Checked || rbtn_Female.Checked))
            {
                return true;
            }

            return false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "Save")
            {
                if (CheckItemFill())
                {
                    String Gender = "";
                    DateTime Date = Convert.ToDateTime(tb_Date.Text);
                    if (rbtn_Male.Checked)
                    {
                        Gender = rbtn_Male.Text;
                    }
                    if (rbtn_Female.Checked)
                    {
                        Gender = rbtn_Female.Text;
                    }
                    using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                    {
                        db.Employee_Details.Add(new Employee_Details() { Name = tb_Name.Text, Joining_Date = Date, Mobile_No = Convert.ToInt64(tb_Mobile_No.Text), DOB = Convert.ToDateTime(dtp_DOB.Text), Gender = Gender, Account_No = tb_Account_No.Text, Address = tb_Address.Text, Adhaar_No = tb_Adhaar_No.Text, Experience = cmb_Experience.Text, Qualification = cmb_Qualification.Text });
                        db.SaveChanges();

                        db.Employee_salary.Add(new Employee_salary() { Employee_Id = Convert.ToInt32(tb_ID.Text), Post = cmb_Post.Text, Salary = Convert.ToDecimal(tb_Salary.Text), Pending_Salary = 0, Last_Paid = Date });
                        db.SaveChanges();

                        MessageBox.Show("Record Save Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearControl();
                }
                else
                {
                    MessageBox.Show("1st Fill All The Fields...!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (CheckItemFill())
                {
                    using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                    {
                        int ID = Convert.ToInt32(tb_ID.Text);
                        string Gender = "";
                        var Emp = db.Employee_Details.Find(ID);

                        if (Emp != null)
                        {
                            var EmpSal = db.Employee_salary.Find(ID);

                            if (EmpSal != null)
                            {
                                if (rbtn_Male.Checked)
                                {
                                   Gender = rbtn_Male.Text;
                                }
                                if (rbtn_Female.Checked)
                                {
                                    Gender = rbtn_Female.Text;
                                }

                                 Emp.Name = tb_Name.Text;
                                 Emp.Mobile_No = Convert.ToInt64(tb_Mobile_No.Text);
                                 Emp.DOB = Convert.ToDateTime(dtp_DOB.Text);
                                 Emp.Account_No = tb_Account_No.Text;
                                 Emp.Adhaar_No = tb_Adhaar_No.Text;
                                Emp.Qualification = cmb_Qualification.Text;
                                Emp.Experience = cmb_Experience.Text;
                                EmpSal.Post = cmb_Post.Text;
                                EmpSal.Salary = Convert.ToDecimal(tb_Salary.Text);
                                Emp.Address = tb_Address.Text;
                                Emp.Gender = Gender; 
                            }

                        }
                        db.SaveChanges();
                        MessageBox.Show("Record Update Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControl();
                        tb_ID.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("1st Fill All The Fields...!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControl();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(tb_ID.Text));
        }
    }
}
