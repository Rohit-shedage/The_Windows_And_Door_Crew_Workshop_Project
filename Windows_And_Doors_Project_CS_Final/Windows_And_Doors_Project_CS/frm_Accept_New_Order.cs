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
    public partial class frm_Accept_New_Order : Form
    {
        Decimal Total = 0;

        DataTable dt = new DataTable();
        public frm_Accept_New_Order()
        {
            InitializeComponent();
            CreateColums();
            rbtn_New_Customer.Select();
            Cust_ID();
            Orders_ID();
            dtp_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        int P_Cnt = 0;
        public frm_Accept_New_Order(int iNo)
        {
            InitializeComponent();
            P_Cnt = iNo;
            if (P_Cnt == 1)
            {
 
                foreach (Control Control1 in this.Controls)
                {
                    foreach (Control control2 in Control1.Controls)
                    {
                        control2.Enabled = false;
                    }

                }

               // gpb_Customer_Information.Enabled = true;
                tlpnl_Customer_Info_1.Enabled = true;
                tb_ID.Enabled = true;
                lbl_Header.Text = "Update Order Details";
                btn_Search.Visible = true;
                btn_Search.Enabled = true;
                lbl_Header.Text = "Update Order Details";
                btn_Update_Order.Visible = true;
                pnl_Radio_Button.Visible = false;
                btn_Close.Enabled = true;
               
               
            }
        }

        private void rbtn_Old_Customer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Old_Customer.Checked)
            {
                btn_Search.Visible = true;
                dtp_Date.Enabled = false;
                tb_Name.Enabled = false;
                tb_Address.Enabled = false;
                tb_Mobile_No.Enabled = false;
                tb_ID.Text = "";
                tb_ID.Enabled = true;

            }
            else
            {
                btn_Search.Visible = false;
                dtp_Date.Enabled = true;
                tb_Name.Enabled = true;
                tb_Address.Enabled = true;
                tb_Mobile_No.Enabled = true;
                //tb_Date.Text = "";
                tb_Name.Text = "";
                tb_Address.Text = "";
                tb_Mobile_No.Text = "";
                Cust_ID();
            }
        }

        public void Orders_ID()
        {
            using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
            {
                int? id = DB.Orders.Max(i => (int?)i.Order_Id);

                if (id != null)
                    lbl_Order_ID.Text = (id + 1).ToString();
                else
                    lbl_Order_ID.Text = "1000";
            }
        }
        public void Cust_ID()
        {
            using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
            {
                int? id = DB.Customers.Max(i => (int?)i.Customer_Id);

                if (id != null)
                    tb_ID.Text = (id + 1).ToString();
                else
                    tb_ID.Text = "1";
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Address.Text != "")
            {
                using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
                {
                    if (lbl_Header.Text == "Accept New Order" && rbtn_Old_Customer.Checked != true)
                    {
                        DB.Customers.Add(new Customer { Customer_Name = tb_Name.Text, Mobile = Convert.ToInt64(tb_Mobile_No.Text), Address = tb_Address.Text });
                        DB.SaveChanges();

                        string str = tb_ID.Text;
                        rbtn_Old_Customer.Checked = true;
                        tb_ID.Text = str;
                    }
                }

                if (lbl_Header.Text == "Accept New Order")
                {
                     Form formBackground = new Form();
                    //frm_Final_Amount obj = new frm_Final_Amount(tb_Total.Text, dtp_Date.Text, lbl_Order_ID.Text, dt, 0, tb_ID.Text);
                    //this.Hide();
                    //frm_MDI_Main_Form MDi = new frm_MDI_Main_Form();
                    //MDi.Hide();
                    //obj.Show();
                    try
                    {
                        using (frm_Final_Amount obj = new frm_Final_Amount(tb_Total.Text, dtp_Date.Text, lbl_Order_ID.Text, dt, 0, tb_ID.Text))
                        {
                            formBackground.StartPosition = FormStartPosition.Manual;
                            formBackground.FormBorderStyle = FormBorderStyle.None;
                            formBackground.Opacity = .50d;
                            formBackground.BackColor = Color.Black;
                            formBackground.WindowState = FormWindowState.Maximized;
                            formBackground.TopMost = true;
                            formBackground.Location = this.Location;
                            formBackground.ShowInTaskbar = false;
                            formBackground.Show();
                            frm_Final_Amount.dt = dt;

                            obj.Owner = formBackground;
                            obj.ShowDialog();

                            formBackground.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        formBackground.Dispose();
                    }

                }
                else
                {
                    Form formBackground = new Form();
                    //frm_Final_Amount obj = new frm_Final_Amount(tb_Total.Text, dtp_Date.Text, lbl_Order_ID.Text, dt, 1, tb_ID.Text);
                    //this.Hide();
                    //frm_MDI_Main_Form MDi = new frm_MDI_Main_Form();
                    //MDi.Hide();
                    //obj.Show();
                    try
                    {
                        using (frm_Final_Amount obj = new frm_Final_Amount(tb_Total.Text, dtp_Date.Text, lbl_Order_ID.Text, dt, 1, tb_ID.Text))
                        {
                            formBackground.StartPosition = FormStartPosition.Manual;
                            formBackground.FormBorderStyle = FormBorderStyle.None;
                            formBackground.Opacity = .50d;
                            formBackground.BackColor = Color.Black;
                            formBackground.WindowState = FormWindowState.Maximized;
                            formBackground.TopMost = true;
                            formBackground.Location = this.Location;
                            formBackground.ShowInTaskbar = false;
                            formBackground.Show();
                            frm_Final_Amount.dt = dt;

                            obj.Owner = formBackground;
                            obj.ShowDialog();

                            formBackground.Dispose();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        formBackground.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, First Fill All The Feilds !!!");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Accept_New_Order_Load(object sender, EventArgs e)
        {
            rbtn_New_Customer.Select();

            using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
            {
                var cat = DB.Catagories.ToList();

                foreach (var c in cat)
                {
                    cmb_Category.Items.Add(c.Name);
                }
            }
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Product.Items.Clear();
            cmb_Colour.Items.Clear();
            cmb_Glass_Type.Items.Clear();
            cmb_Track.Items.Clear();
            cmb_Product.Text = "";
            cmb_Colour.Text = "";
            cmb_Glass_Type.Text = "";
            cmb_Track.Text = "";
            cmb_Material_Type.Text = "";

            if (cmb_Category.Text != "Door")
            {
                using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
                {
                    var p = (from a in DB.Products where a.Catagory == "Window" select a.Product_Name).ToList();

                    foreach (var i in p)
                    {
                        cmb_Product.Items.Add(i);
                    }
                }
            }
            else
            {
                using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
                {
                    var p = (from a in DB.Products where a.Catagory == "Door" select a.Product_Name).ToList();

                    foreach (var i in p)
                    {
                        cmb_Product.Items.Add(i);
                    }
                }
                cmb_Material_Type.Enabled = false;
                cmb_Colour.Enabled = false;
                cmb_Glass_Type.Enabled = false;
                cmb_Track.Enabled = false;
            }
            cmb_Product.Enabled = true;
        }

        private void cmb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Colour.Items.Clear();
            cmb_Glass_Type.Items.Clear();
            cmb_Track.Items.Clear();
            cmb_Track.Enabled = false;

            cmb_Material_Type.Enabled = true;
            cmb_Colour.Enabled = true;
            cmb_Glass_Type.Enabled = true;
            cmb_Track.Enabled = true;

            using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
            {
                var PID = (from p in DB.Products where p.Product_Name == cmb_Product.Text select p.Product_Id).FirstOrDefault();

                var GlassType = (from g in DB.Product_Material where g.Product_Id == PID && g.Material_Name.Contains("Glass") select g).ToList();
                var Colour = (from c in DB.Material_Colour where c.Group_Id == 1 select c.Material_Colour1).ToList();
                var Track = (from T in DB.Products where T.Product_Id == PID select T.Available_In_Track).FirstOrDefault();

                foreach (var i in Colour)
                {
                    cmb_Colour.Items.Add(i);
                }

                if (Track == "Yes")
                {
                    cmb_Track.Enabled = true;
                    cmb_Track.Items.Add("1");
                    cmb_Track.Items.Add("2");
                    cmb_Track.Items.Add("3");
                    cmb_Track.Items.Add("4");
                }
                else
                {
                    cmb_Track.Enabled = false;
                    cmb_Track.Text = "";
                }

                if (GlassType != null)
                {
                    cmb_Glass_Type.Enabled = true;

                    foreach (var i in GlassType)
                    {
                        cmb_Glass_Type.Items.Add(i.Material_Name);
                    }
                }
                else
                {
                    cmb_Glass_Type.Enabled = false;
                }

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text != "")
            {
                using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
                {
                    var Cust = DB.Customers.Find(Convert.ToInt32(tb_ID.Text));

                    if (Cust != null)
                    {
                        tb_Name.Text = Cust.Customer_Name;
                        tb_Mobile_No.Text = Cust.Mobile.ToString();
                        tb_Address.Text = Cust.Address;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Customer ID");
                    }
                }
            }
        }

        public void CreateColums()
        {
            dt.Columns.Add(new DataColumn("Catagory", typeof(string)));
            dt.Columns.Add(new DataColumn("Product", typeof(string)));
            dt.Columns.Add(new DataColumn("Material Type", typeof(string)));
            dt.Columns.Add(new DataColumn("Colour", typeof(string)));
            dt.Columns.Add(new DataColumn("Glass Type", typeof(string)));
            dt.Columns.Add(new DataColumn("Track", typeof(int)));
            dt.Columns.Add(new DataColumn("Height", typeof(float)));
            dt.Columns.Add(new DataColumn("Width", typeof(float)));
            dt.Columns.Add(new DataColumn("Quantity", typeof(int)));
            dt.Columns.Add(new DataColumn("Price", typeof(int)));
        }
        private bool CheckFilled()
        {
            if (cmb_Product.Text != "" && tb_Height.Text != "" && tb_Width.Text != "" && tb_Quantity.Text != "" && tb_Price.Text != "")
            {
                return true;
            }
            return false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (CheckFilled())
            {
                if (tb_Price.Text != "" && tb_Quantity.Text != "")
                {
                    if (btn_Next.Text == "Next")
                        Total += (((Convert.ToInt32(tb_Height.Text) * 2 + Convert.ToInt32(tb_Width.Text) * 2) * Convert.ToInt32(tb_Price.Text)) * Convert.ToInt32(tb_Quantity.Text));
                    // Total += (Convert.ToInt32(tb_Price.Text) * Convert.ToInt32(tb_Quantity.Text));
                    else
                    {
                        Decimal a = Convert.ToDecimal(tb_Price.Text);
                        Decimal b = Convert.ToDecimal(tb_Quantity.Text);
                        Decimal t1 = Convert.ToDecimal(tb_Total.Text);

                        Total = (t1 + (a * b));
                    }
                    DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();
                    Edit.Name = "Edit";
                    Edit.Text = "Edit";
                    Edit.UseColumnTextForButtonValue = true;
                    int columnIndex = 0;
                    if (dgv_Order_Details.Columns["Edit"] == null)
                    {
                        dgv_Order_Details.Columns.Insert(columnIndex, Edit);
                    }
                    //dgv_StockItems.Rows.Insert(columnIndex, Edit);

                    tb_Total.Text = Total.ToString();

                    int? Width = (int.TryParse(tb_Width.Text, out var s) ? (int?)s : null);
                    int? Height = (int.TryParse(tb_Height.Text, out var h) ? (int?)h : null);
                    int? Track = (int.TryParse(cmb_Track.Text, out var t) ? (int?)t : null);

                    dt.Rows.Add(cmb_Category.Text, cmb_Product.Text, cmb_Material_Type.Text, cmb_Colour.Text, cmb_Glass_Type.Text, Track, Height, Width, Convert.ToInt32(tb_Quantity.Text), Convert.ToInt32(tb_Price.Text));

                    dgv_Order_Details.DataSource = dt;

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "Remove";
                    btn.Text = "Remove";
                    btn.UseColumnTextForButtonValue = true;
                    columnIndex = 0;
                    if (dgv_Order_Details.Columns["Remove"] == null)
                    {
                        dgv_Order_Details.Columns.Insert(columnIndex, btn);
                    }
                    //dgv_OrderedItems.Rows.Insert(columnIndex, btn);

                }
                else
                {
                    MessageBox.Show("First Fill The Required Fields !!!");
                }
            }
            else
            {
                MessageBox.Show("First Fill The Required Fields !!!");
            }
        }

        private void dgv_Order_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (e.ColumnIndex == 1 && e.RowIndex > 0)
            {
                cmb_Category.Text = dt.Rows[i][0].ToString();
                cmb_Product.Text = dt.Rows[i][1].ToString();
                cmb_Material_Type.Text = dt.Rows[i][2].ToString();
                cmb_Colour.Text = dt.Rows[i][3].ToString();
                cmb_Glass_Type.Text = dt.Rows[i][4].ToString();
                cmb_Track.Text = dt.Rows[i][5].ToString();
                tb_Height.Text = dt.Rows[i][6].ToString();
                tb_Width.Text = dt.Rows[i][7].ToString();
                tb_Quantity.Text = dt.Rows[i][8].ToString();
                tb_Price.Text = dt.Rows[i][9].ToString();

            }

            if (e.RowIndex >= 0)
            {
                DataRow dr = dt.Rows[e.RowIndex];

                tb_Total.Text = (Convert.ToInt32(tb_Total.Text) - (((Convert.ToInt32(dt.Rows[i][7]) * 2 + Convert.ToInt32(dt.Rows[i][6]) * 2) * Convert.ToInt32(dt.Rows[i][9])) * Convert.ToInt32(dt.Rows[i][8]))).ToString();

                Total = Convert.ToInt32(tb_Total.Text);

                dr.Delete();

                dgv_Order_Details.DataSource = dt;
            }
        }
        public override void Refresh()
        {
            if (lbl_Header.Text == "Accept New Order")
            {
                tb_Name.Clear();
                tb_Mobile_No.Clear();
                tb_Address.Clear();
            }

            cmb_Category.Text = "";
            cmb_Product.Text = "";
            cmb_Material_Type.Text = "";
            cmb_Colour.Text = "";
            cmb_Glass_Type.Text = "";
            cmb_Track.Text = "";

            cmb_Product.Items.Clear();
            cmb_Colour.Items.Clear();
            cmb_Glass_Type.Items.Clear();
            cmb_Track.Items.Clear();

            cmb_Product.Enabled = false;
            cmb_Material_Type.Enabled = false;
            cmb_Colour.Enabled = false;
            cmb_Glass_Type.Enabled = false;
            cmb_Track.Enabled = false;

            tb_Height.Clear();
            tb_Width.Clear();
            tb_Quantity.Clear();
            tb_Price.Clear();

            dt.Rows.Clear();
            tb_Total.Clear();
            Total = 0;
            //dgv_Remove.Rows.Clear();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
