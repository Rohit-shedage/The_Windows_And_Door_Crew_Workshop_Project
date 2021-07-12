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
    public partial class frm_Final_Amount : Form
    {
        static int flag = 1;
        public static DataTable dt;
        public static int test = 0;
        string OrderDate;
        string OrderID;
        int custID;
        string amount;
        int Total1;
        public frm_Final_Amount()
        {
            InitializeComponent();
        }
        public frm_Final_Amount(string Total, string Date, string Order_ID, DataTable Data, int i, string cid)
        {
            InitializeComponent();
            Total1 = (Convert.ToInt32(Total) + Convert.ToInt32(Total) * 12 / 100 + 1000);
            tb_Total.Text = (Convert.ToInt32(Total) + Convert.ToInt32(Total) * 12 / 100 + 1000).ToString();
            dtp_Delivery_Date.Text = Convert.ToDateTime(Date).AddDays(8).ToString("dd-MM-yyyy");
            OrderDate = Date;
            OrderID = Order_ID;
            custID = Convert.ToInt32(cid);
            dt = Data;
            amount = (Convert.ToInt32(Total) + Convert.ToInt32(Total) * 12 / 100).ToString();
            cmb_Installation.SelectedIndex = 0;
            cmb_Discount.SelectedIndex = 0;

            if (i == 1)
            {
                btn_Confirm.Text = "Update";
            }
        }
        private void lbl_Advance_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_Installation_Yes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Final_Amount_Load(object sender, EventArgs e)
        {

        }

        private void cmb_Installation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Installation.Text == "YES" && flag == 0)
            {
                tb_Total.Text = (Convert.ToInt32(tb_Total.Text) + 1000).ToString();
                flag = 1;
            }
            else if (cmb_Installation.Text == "NO" && flag == 1)
            {
                tb_Total.Text = (Convert.ToInt32(tb_Total.Text) - 1000).ToString();
                flag = 0;
            }
        }

        private void cmb_Discount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = (flag == 1) ? 1000 : 0;
            tb_Total.Text = (Convert.ToInt32(amount) - Convert.ToInt32(amount) * Convert.ToInt32(cmb_Discount.Text.Remove(cmb_Discount.Text.Length - 1)) / 100 + i).ToString();
        }

        private void tb_Total_TextChanged(object sender, EventArgs e)
        {
            tb_Advance.Text = (Convert.ToInt32(tb_Total.Text) * 30 / 100).ToString();

            tb_Remaining.Text = (Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(tb_Advance.Text)).ToString();
        }

        private void tb_Advance_TextChanged(object sender, EventArgs e)
        {
            string i = "0";
            if (tb_Advance.Text != "")
            {
                i = tb_Advance.Text;
            }

            tb_Remaining.Text = (Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(i)).ToString();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
            {

                if (btn_Confirm.Text == "CONFIRM")
                {

                    DateTime date = Convert.ToDateTime(OrderDate);
                    decimal Installation = (cmb_Installation.Text == "YES") ? 1000 : 0;
                    double gst = ((Convert.ToInt32(Total1) + Convert.ToInt32(Total1) * 12 / 100 + 1000));
                    double discount = (Convert.ToInt32(amount) * Convert.ToInt32(cmb_Discount.Text.Remove(cmb_Discount.Text.Length - 1)) / 100);
                    DateTime dDate = Convert.ToDateTime(dtp_Delivery_Date.Text);
                    decimal total = Convert.ToInt32(tb_Total.Text);
                    decimal remaining = Convert.ToInt32(tb_Remaining.Text);
                    decimal paid = Convert.ToInt32(tb_Advance.Text);

                    DB.Orders.Add(new Order { Customer_Id = custID, User_Id= 2, Order_Date = date, Installation_Charge = Installation, GST = gst, Discount = discount, Total = total, Paid_Amount = paid, Remaining_Amount = remaining, Delivery_Date = dDate, Status = "Incomplete" });
                    DB.SaveChanges();

                    InsertItems();

                    MessageBox.Show("Order Placed Successfully. Thank You : )");

                    test = 1;

                    this.Close();
                }
                else
                {
                    var Order = DB.Orders.Find(Convert.ToInt32(OrderID));

                    if (Order != null)
                    {
                        Order.Order_Date = Convert.ToDateTime(OrderDate);
                        Order.Installation_Charge = (cmb_Installation.Text == "YES") ? 1000 : 0;
                        Order.GST = ((Convert.ToInt32(Total1) + Convert.ToInt32(Total1) * 12 / 100 + 1000));
                        Order.Discount = (Convert.ToInt32(amount) * Convert.ToInt32(cmb_Discount.Text.Remove(cmb_Discount.Text.Length - 1)) / 100);
                        Order.Total = Convert.ToInt32(tb_Total.Text);
                        Order.Paid_Amount = Convert.ToInt32(tb_Advance.Text);
                        Order.Remaining_Amount = Convert.ToInt32(tb_Remaining.Text);
                        Order.Delivery_Date = Convert.ToDateTime(dtp_Delivery_Date.Text);


                        

                        DB.Ordered_Items.RemoveRange(DB.Ordered_Items.Where(dm => dm.Order_Id == Order.Order_Id));
                        DB.SaveChanges();

                        InsertItems();

                        test = 0;

                        this.Close();
                    }
                }
            }
        }

        private void InsertItems()
        {
            using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
            {
                foreach (DataRow row in dt.Rows)
                {
                    //int? Size = (int.TryParse(row.Cells[5].Value.ToString(), out var s) ? (int?)s : null);
                    int? Track = (int.TryParse(row[5].ToString(), out var t) ? (int?)t : null);

                    DB.Ordered_Items.Add(new Ordered_Items { Order_Id = Convert.ToInt32(OrderID), Catagory = row[0].ToString(), Sub_Catagory = row[1].ToString(), Material_Type = row[2].ToString(), Glass_Type = row[4].ToString(), Colour = row[3].ToString(), Track = Convert.ToInt32(Track), Height = Convert.ToDouble(row[6]), Width = Convert.ToDouble(row[7]), Quantity = Convert.ToInt32(row[8]) });
                    DB.SaveChanges();

                   
                }
                DB.Customer_Transaction.Add(new Customer_Transaction { Order_Id = Convert.ToInt32(OrderID), User_Id = 2, Date = DateTime.Now, Paid = Convert.ToDecimal(tb_Advance.Text) });
                DB.SaveChanges();
            }
        }
    }
}
