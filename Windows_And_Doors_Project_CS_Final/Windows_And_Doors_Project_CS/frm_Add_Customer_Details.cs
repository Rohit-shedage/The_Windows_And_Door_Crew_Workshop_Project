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
    public partial class frm_Add_Customer_Details : Form
    {
        public frm_Add_Customer_Details()
        {
            InitializeComponent();

            AutoIncrement();
           
        }

        public frm_Add_Customer_Details(int iNo)
        {
               InitializeComponent();
                 
                tb_ID.Enabled = true;
                btn_Search.Visible = true;
                btn_Search.Enabled = true;
                btn_Save.Text = "Update";
                lbl_Header.Text = "Update Customer Details";
                btn_Close.Enabled = true;

            if (iNo != 0)
            {
                Search(iNo);
            }
        }

        private void AutoIncrement()
        {
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                int? ID = db.Customers.Max(i => (int?)i.Customer_Id);

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

        private void Search(int iNo)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var Cust = db.Customers.Find(iNo);

                if (Cust != null)
                {
                    tb_ID.Text = Cust.Customer_Id.ToString();
                    tb_Name.Text = Cust.Customer_Name.ToString();
                    tb_Date.Text = Cust.Created_Date.ToString("dd-MM-yyyy");
                    tb_Mobile_No.Text = Cust.Mobile.ToString();
                    tb_Address.Text = Cust.Address.ToString();
                }
            }
        }

        private void ClearControl()
        {
            foreach (Control control in tbl_Customer_Details.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Add_Customer_Details_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "Save")
            {
                DateTime Date = Convert.ToDateTime(tb_Date.Text);
                using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                {
                    db.Customers.Add(new Customer() { Customer_Name = tb_Name.Text, Created_Date = Date, Mobile = Convert.ToInt64(tb_Mobile_No.Text), Address = tb_Address.Text });
                    db.SaveChanges();
                }
                MessageBox.Show("Record Save Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControl();
                AutoIncrement();
            }
            else
            {
                int ID = Convert.ToInt32(tb_ID.Text);
                DateTime Date = Convert.ToDateTime(tb_Date.Text);

                using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                {
                    var Cust = db.Customers.Find(ID);

                    if (Cust != null)
                    {
                        Cust.Customer_Name = tb_Name.Text;
                        Cust.Created_Date = Date;
                        Cust.Mobile = Convert.ToInt64(tb_Mobile_No.Text);
                        Cust.Address = tb_Address.Text;

                        db.SaveChanges();
                    }
                    MessageBox.Show("Record Update Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControl();
                    tb_ID.Text = "";
                    tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
                }
            }
           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int iNo = Convert.ToInt32(tb_ID.Text);
            Search(iNo);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControl();
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            if (btn_Save.Text == "Save")
            {
                AutoIncrement();
            }
        }
    }
}
