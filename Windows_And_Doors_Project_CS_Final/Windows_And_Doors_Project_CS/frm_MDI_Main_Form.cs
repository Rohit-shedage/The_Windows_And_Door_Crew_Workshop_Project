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
    public partial class frm_MDI_Main_Form : Form
    {
        private int childFormNumber = 0;

        public frm_MDI_Main_Form()
        {
            InitializeComponent();
        }

        private void Hide_Opened_Sub_Panel()
        {
            /*
            foreach (Control panel in this.Controls)
            {
                foreach (Control panel1 in panel1.Controls)
                {
                    if (panel1.GetType() == typeof(Panel) && panel1 != pnl_Logo)
                    {
                        if (panel1.Visible == true)
                        {
                            panel1.Visible = false;
                        } 
                    }
                }
            }*/

            if (pnl_Sub_Customer.Visible == true)
            {
                pnl_Sub_Customer.Visible = false;
            }
            if (pnl_Sub_Distributor.Visible == true)
            {
                pnl_Sub_Distributor.Visible = false;
            }
            if (pnl_Sub_Employee.Visible == true)
            {
                pnl_Sub_Employee.Visible = false;
            }
            if (pnl_Sub_Order.Visible == true)
            {
                pnl_Sub_Order.Visible = false;
            }
            if (pnl_Sub_Pay.Visible == true)
            {
                pnl_Sub_Pay.Visible = false;
            }
            if (pnl_Sub_Product.Visible == true)
            {
                pnl_Sub_Product.Visible = false;
            }
            if (pnl_Sub_Stock.Visible == true)
            {
                pnl_Sub_Stock.Visible = false;
            }
            if (pnl_Sub_User.Visible == true)
            {
                pnl_Sub_User.Visible = false;
            }
            if (pnl_Sub_Report.Visible == true)
            {
                pnl_Sub_Report.Visible = false;
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
            activeForm.MdiParent = this;
            activeForm.WindowState = FormWindowState.Maximized;
            activeForm.Show();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            
            if (pnl_Sub_Order.Visible == false)
            {
                Hide_Opened_Sub_Panel();
                pnl_Sub_Order.Visible = true;
            }
            else
            {
                pnl_Sub_Order.Visible = false;
            }
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            if (pnl_Sub_Stock.Visible == false)
            {
                Hide_Opened_Sub_Panel();
                pnl_Sub_Stock.Visible = true;
            }
            else
            {
                pnl_Sub_Stock.Visible = false;
            }
        }

        private void btn_Edit_Prices_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Edit_Prices());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (pnl_Sub_Pay.Visible == false)
            {
                Hide_Opened_Sub_Panel();
                pnl_Sub_Pay.Visible = true;
            }
            else
            {
                pnl_Sub_Pay.Visible = false;
            }
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            if (pnl_Sub_Product.Visible == false)
            {
                Hide_Opened_Sub_Panel();
                pnl_Sub_Product.Visible = true;
            }
            else
            {
                pnl_Sub_Product.Visible = false;
            }
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            if (pnl_Sub_Employee.Visible == false)
            {
                Hide_Opened_Sub_Panel();
                pnl_Sub_Employee.Visible = true;
            }
            else
            {
                pnl_Sub_Employee.Visible = false;
            }
        }

        private void btn_Distributor_Click(object sender, EventArgs e)
        {
            if (pnl_Sub_Distributor.Visible == false)
            {
                Hide_Opened_Sub_Panel();
                pnl_Sub_Distributor.Visible = true;
            }
            else
            {
                pnl_Sub_Distributor.Visible = false;
            }
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            if (pnl_Sub_Customer.Visible == false)
            {
                Hide_Opened_Sub_Panel();
                pnl_Sub_Customer.Visible = true;
            }
            else
            {
                pnl_Sub_Customer.Visible = false;
            }

        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            if (pnl_Sub_User.Visible == false)
            {
                Hide_Opened_Sub_Panel();
                pnl_Sub_User.Visible = true;
            }
            else
            {
                pnl_Sub_User.Visible = false;
            }
        }

        private void btn_Total_Earning_Expenditure_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Total_Earning_And_Expenditure());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            if (pnl_Sub_Report.Visible == false)
            {
                Hide_Opened_Sub_Panel();
                pnl_Sub_Report.Visible = true;
            }
            else
            {
                pnl_Sub_Report.Visible = false;
            }
        }

        private void btn_Accept_Order_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Accept_New_Order());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Mark_as_Completed_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Order());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Accept_Money_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Order(1));
            Hide_Opened_Sub_Panel();
        }

        private void btn_Cancel_Order_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Order(2));
            Hide_Opened_Sub_Panel();
        }

        private void btn_Total_Order_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Order(3));
            Hide_Opened_Sub_Panel();
        }

        private void btn_Add_Stock_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_Stock());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Update_Stock_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_Stock(1));
            Hide_Opened_Sub_Panel();
        }

        private void btn_Manage_Stock_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Stock());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Salary_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Salary());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Add_Product_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_Product());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Manage_Product_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Product());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Distributor_Bill_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Salary(1));
            Hide_Opened_Sub_Panel();
        }

        private void btn_Maintainance_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Pay_Maintenance());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_New_Employee());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Manage_Employee_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Employee());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Add_New_Distributor_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_New_Distributor());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Manage_Distributor_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Distributor());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Add_New_Customer_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_Customer_Details());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Manage_Customer_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_Customer());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Add_New_User_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Add_New_User());
            Hide_Opened_Sub_Panel();
        }

        private void btn_Manage_User_Click(object sender, EventArgs e)
        {
            Show_Mdi_Parent(new frm_Manage_User());
            Hide_Opened_Sub_Panel();
        }
    }
}
