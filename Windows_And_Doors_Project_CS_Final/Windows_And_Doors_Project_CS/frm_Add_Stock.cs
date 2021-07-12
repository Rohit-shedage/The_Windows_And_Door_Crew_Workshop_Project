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
    public partial class frm_Add_Stock : Form
    {
        Decimal Total = 0;
        DataTable dt = new DataTable();
        int P_Cnt = 0;

        public frm_Add_Stock()
        {
            InitializeComponent();
            CreateColumn();
            AutoIncrement();
        }

        void AutoIncrement()
        {
            tb_date.Text = DateTime.Now.ToString("dd-MM-yyyy");

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                int? ID = db.Stock_Order.Max(i => (int?)i.Order_Stock_Id);
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
        public frm_Add_Stock(int iNo)
        {
            InitializeComponent();
            lbl_Header.Text = "Update Stock Details";
            btn_Save.Text = "Update";
            tbllpnl_Order_Details.Enabled = true;
            tb_ID.Enabled = true;
            tb_ID.Text = iNo.ToString();
            btn_Search.Visible = true;
            btn_Search.Enabled = true;
            btn_Close.Enabled = true;
            CreateColumn();

            if (iNo != 0)
            {
                Search(iNo);
            }

            
        }

        void CreateColumn()
        {
            DataColumn c1 = new DataColumn("Material Name", typeof(string));
            DataColumn c2 = new DataColumn("Type", typeof(string), null);
            DataColumn c3 = new DataColumn("Colour", typeof(string), null);
            DataColumn c4 = new DataColumn("Track", typeof(int), null);
            DataColumn c5 = new DataColumn("Size", typeof(int), null);
            DataColumn c6 = new DataColumn("Quantity", typeof(int));
            DataColumn c7 = new DataColumn("Price", typeof(int));

            dt.Columns.Add(c1);
            dt.Columns.Add(c2);
            dt.Columns.Add(c3);
            dt.Columns.Add(c4);
            dt.Columns.Add(c5);
            dt.Columns.Add(c6);
            dt.Columns.Add(c7);
        }

        private void Refresh()
        {
            tb_date.Text = "";
            cmb_Distributor.Text = "";
            cmb_Material.Text = "";
            tb_Total.Text = "";
            tb_Paid.Text = "0";
            Total = 0;

            CLearGB();
            if (btn_Save.Text == "Save")
            {
                AutoIncrement();
                tb_date.Text = DateTime.Now.ToString("dd-MM-yyyy");
            }
        }

        void CLearGB()
        {
            cmb_Material_Type.Items.Clear();
            cmb_Material_Type.Text = "";
            cmb_Colour.Items.Clear();
            cmb_Colour.Text = "";
            cmb_Track.Items.Clear();
            cmb_Track.Text = "";
            cmb_Size.Items.Clear();
            cmb_Size.Text = "";

            tb_Purchase_Price.Text = "";
            tb_Quantity.Text = "";

        }

        private void Search(int iNo)
        {
            dgv_Remove.Rows.Clear();
            dt.Rows.Clear();

            using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
            {
                var Order = DB.Stock_Order.Find(iNo);

                if (Order != null)
                {
                    DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();
                    Edit.Name = "Edit";
                    Edit.Text = "Edit";
                    Edit.UseColumnTextForButtonValue = true;
                    int ColumnIndex = 0;

                    DataGridViewButtonColumn Removebtn = new DataGridViewButtonColumn();
                    Removebtn.Name = "Remove";
                    Removebtn.Text = "Remove";
                    Removebtn.UseColumnTextForButtonValue = true;

                    ColumnIndex = 0;

                    tb_date.Text = Order.Date.ToString("dd-MM-yyyy");
                    cmb_Distributor.Text = Order.Distributor_Name.ToString();

                    cmb_Material.Text = "";
                    cmb_Material.Items.Clear();

                    var Dist_ID = (from i in DB.Distributors where i.Distributor_Name == cmb_Distributor.Text select i.Distributor_Id).FirstOrDefault();

                    var dis = (from d in DB.Distributor_Material where d.Distributor_Id == Dist_ID select d.Material_Name).ToList();

                    foreach (var d in dis)
                    {
                        cmb_Material.Items.Add(d);
                    }

                    tb_Total.Text = Order.Total.ToString().Substring(0 , Order.Total.ToString().IndexOf("."));
                    tb_Paid.Text = Order.Paid_Amount.ToString().Substring(0, Order.Paid_Amount.ToString().IndexOf("."));

                    var OrderItem = (from oi in DB.Stock_Order_Items where oi.Order_Stock_Id == iNo select oi).ToList();

                    foreach (var i  in OrderItem)
                    {
                        if (dgv_Order_Details.Columns["Edit"] == null)
                        {
                            dgv_Order_Details.Columns.Insert(ColumnIndex, Edit);
                        }

                        dt.Rows.Add(i.Material_Name, i.Type, i.Colour, i.Track, i.Size, i.Quantity, i.Purchase_Price);

                        if (dgv_Remove.Columns["Remove"] == null)
                        {
                            dgv_Remove.Columns.Insert(ColumnIndex, Removebtn);
                        }

                        dgv_Remove.Rows.Insert(ColumnIndex, Removebtn);

                        dgv_Order_Details.DataSource = dt;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Order ID..!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lbl_Quantity_Click(object sender, EventArgs e)
        {

        }

    

        private void btn_Close_Click(object sender, EventArgs e)
        {

        }

        private void frm_Add_Stock_Load(object sender, EventArgs e)
        {
            tb_date.Text = DateTime.Now.ToString("dd-MM-yyyy");

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var Dis = (from d in db.Distributors select d.Distributor_Name).ToList();

                foreach (var d in Dis)
                {
                    cmb_Distributor.Items.Add(d);
                }
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();

            try
            {
                using (frm_Add_Material Obj = new frm_Add_Material())
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

                    Obj.Owner = formBackground;
                    Obj.ShowDialog();

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

        private void cmb_Distributor_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                cmb_Material.Text = "";
                cmb_Material.Items.Clear();

                var Dis_Id = (from i in db.Distributors where i.Distributor_Name == cmb_Distributor.Text select i.Distributor_Id).FirstOrDefault();

                var Dis = (from d in db.Distributor_Material where d.Distributor_Id == Dis_Id select d.Material_Name).ToList();

                foreach (var d in Dis)
                {
                    cmb_Material.Items.Add(d);
                }
            }
        }

        private void cmb_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLearGB();

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                int Material_Group = (from mg in db.Material_Info where mg.Material_Name == cmb_Material.Text select mg.Group_Id).First();

                var Type = (from t in db.Material_Type where t.Group_Id == Material_Group select t.Material_Type1).ToList();

                if (Type.Count != 0)
                {
                    cmb_Material_Type.Enabled = true;
                    foreach (var t in Type)
                    {
                        cmb_Material_Type.Items.Add(t);
                    }
                }
                else
                {
                    cmb_Material_Type.Enabled = false;
                }

                var color = (from c in db.Material_Colour where c.Group_Id == Material_Group select c.Material_Colour1).ToList();

                if (color.Count != 0)
                {
                    cmb_Colour.Enabled = true;
                    foreach (var c in color)
                    {
                        cmb_Colour.Items.Add(c);
                    }
                }
                else
                {
                    cmb_Colour.Enabled = false;
                }

                var Track = (from t in db.Material_Track where t.Group_Id == Material_Group select t.Track).ToList();

                if (Track.Count != 0)
                {
                    cmb_Track.Enabled = true;
                    foreach (var t in Track)
                    {
                        cmb_Track.Items.Add(t);
                    }
                }
                else
                {
                    cmb_Track.Enabled = false;
                }

                var size = (from s in db.Material_Size where s.Group_Id == Material_Group select s.Material_Size1).ToList();

                if (size.Count != 0)
                {
                    cmb_Size.Enabled = true;
                    foreach (var s in size)
                    {
                        cmb_Size.Items.Add(s);
                    }
                }
                else
                {
                    cmb_Size.Enabled = false;
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Purchase_Price.Text != "" && tb_Quantity.Text != "")
            {
                if (btn_Save.Text == "Save")
                {
                    Total += (Convert.ToInt32(tb_Purchase_Price.Text) * Convert.ToInt32(tb_Quantity.Text));
                }
                else
                {
                    Decimal PPrice = Convert.ToDecimal(tb_Purchase_Price.Text);   //PP => Purchase Price
                    Decimal Quantity = Convert.ToDecimal(tb_Quantity.Text);   //Q => Quantity
                    Decimal T1 = Convert.ToDecimal(tb_Total.Text);

                    Total = (T1 + (PPrice * Quantity));
                }

                DataGridViewButtonColumn Edit = new DataGridViewButtonColumn();
                Edit.Name = "Edit";
                Edit.Text = "Edit";
                Edit.UseColumnTextForButtonValue = true;
                int ColumnIndex = 0;

                if (dgv_Order_Details.Columns["Edit"] == null)
                {
                    dgv_Order_Details.Columns.Insert(ColumnIndex, Edit);
                }

                tb_Total.Text = Total.ToString();

                int? Size = (int.TryParse(cmb_Size.Text, out var s) ? (int?)s : null);
                //int size = Convert.ToInt32(cmb_Size.Text);
                int? Track = (int.TryParse(cmb_Track.Text, out var t) ? (int?)t : null);

                dt.Rows.Add(cmb_Material.Text, cmb_Material_Type.Text, cmb_Colour.Text, Track, Size, Convert.ToInt32(tb_Quantity.Text), Convert.ToInt32(tb_Purchase_Price.Text));

                dgv_Order_Details.DataSource = dt;

                //Remove

                DataGridViewButtonColumn Removebtn = new DataGridViewButtonColumn();
                Removebtn.Name = "Remove";
                Removebtn.Text = "Remove";
                Removebtn.UseColumnTextForButtonValue = true;

                ColumnIndex = 0;
                /*
                if (dgv_Order_Details.Columns["Remove"] == null)
                {
                    dgv_Order_Details.Columns.Insert(ColumnIndex,Removebtn);  ///ERROR
                }

                dgv_Order_Details.Rows.Insert(ColumnIndex, Removebtn);*/

                if (dgv_Remove.Columns["Remove"] == null)
                {
                    dgv_Remove.Columns.Insert(ColumnIndex, Removebtn);  ///ERROR
                }

                dgv_Remove.Rows.Insert(ColumnIndex, Removebtn);

                cmb_Material_Type.Text = "";
                cmb_Size.Text = "";
                cmb_Track.Text = "";
                cmb_Colour.Text = "";
                tb_Available.Text = "";
                tb_Quantity.Text = "";
                tb_Purchase_Price.Text = "";
               
            }
            else
            {
                MessageBox.Show("1st Filled Valid Fields", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Remove_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow dr = dt.Rows[e.RowIndex];

                tb_Total.Text = (Convert.ToDecimal(tb_Total.Text) - (Convert.ToDecimal(dt.Rows[e.RowIndex][5]) * Convert.ToDecimal(dt.Rows[e.RowIndex][6]))).ToString();

                dr.Delete();

                dgv_Remove.Rows.RemoveAt(e.RowIndex);

                dgv_Order_Details.DataSource = dt;
            }
        }

        private void dgv_Order_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            cmb_Material.Text = dt.Rows[i][0].ToString();
            cmb_Material_Type.Text = dt.Rows[i][1].ToString();
            cmb_Colour.Text = dt.Rows[i][2].ToString();
            cmb_Track.Text = dt.Rows[i][3].ToString();
            cmb_Size.Text = dt.Rows[i][4].ToString();
            tb_Quantity.Text = dt.Rows[i][5].ToString();
            tb_Purchase_Price.Text = dt.Rows[i][6].ToString();

            dgv_Remove_CellClick(sender, e);
        }

        private bool CheckFilled()
        {
            if (tb_ID.Text != "" && cmb_Material.Text != "" && cmb_Distributor.Text != "" && tb_Total.Text != "" && tb_Paid.Text != "" && dgv_Order_Details.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckFilled())
            {
                using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                {
                    int Rem = Convert.ToInt32(tb_Total.Text) - Convert.ToInt32(tb_Paid.Text);

                    if (btn_Save.Text == "Save")
                    {
                        db.Stock_Order.Add(new Stock_Order { Date = Convert.ToDateTime(tb_date.Text), Distributor_Name = cmb_Distributor.Text, Total = Convert.ToInt32(tb_Total.Text), Paid_Amount = Convert.ToInt32(tb_Paid.Text), Remaining_Amount = Rem });
                        db.SaveChanges();

                        InsertItems();

                        MessageBox.Show("Record Save Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var Order = db.Stock_Order.Find(Convert.ToInt32(tb_ID.Text));

                        if (Order != null)
                        {
                            Order.Distributor_Name = cmb_Distributor.Text;
                            Order.Total = Convert.ToInt32(tb_Total.Text);
                            Order.Paid_Amount = Convert.ToInt32(tb_Paid.Text);
                            Order.Remaining_Amount = Rem;

                            var stock = (from ss in db.Stock_Order_Items where ss.Order_Stock_Id == Order.Order_Stock_Id select ss).ToList();

                            foreach (var i in stock)
                            {
                                var S = (from s1 in db.Stocks where s1.Material_Name == i.Material_Name && s1.Type == i.Type && s1.Colour == i.Colour && s1.Size == i.Size && s1.Track == i.Track select s1).FirstOrDefault();

                                if (S != null)
                                {
                                    S.Available_Stock -= i.Quantity;
                                }
                            }
                            db.Stock_Order_Items.RemoveRange(db.Stock_Order_Items.Where(dm => dm.Order_Stock_Id == Order.Order_Stock_Id));
                            db.SaveChanges();

                            InsertItems();

                            MessageBox.Show("Record Update Successfully...!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    Refresh();
                    dt.Rows.Clear();
                    dgv_Remove.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields...!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InsertItems()
        {
            using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
            {
                foreach (DataGridViewRow row in dgv_Order_Details.Rows)
                {
                    int? Size = (int.TryParse(row.Cells[5].Value.ToString(), out var s) ? (int?)s : null);
                    int? Track = (int.TryParse(row.Cells[4].Value.ToString(), out var t) ? (int?)t : null);

                    DB.Stock_Order_Items.Add(new Stock_Order_Items { Order_Stock_Id = Convert.ToInt32(tb_ID.Text), Material_Name = row.Cells[1].Value.ToString(), Type = row.Cells[2].Value.ToString(), Colour = row.Cells[3].Value.ToString(), Track = Track, Size = Size, Quantity = Convert.ToInt32(row.Cells[6].Value), Purchase_Price = Convert.ToInt32(row.Cells[7].Value) });
                    DB.SaveChanges();

                    string Material_Name = row.Cells[1].Value.ToString();
                    string Type = row.Cells[2].Value.ToString();
                    string Colour = row.Cells[3].Value.ToString();
                    int PP = Convert.ToInt32(row.Cells[7].Value);

                    var Stock = (from s1 in DB.Stocks where s1.Material_Name == Material_Name && s1.Type == Type && s1.Colour == Colour && s1.Size == Size && s1.Track == Track select s1).FirstOrDefault();

                    if (Stock != null)
                    {
                        Stock.Available_Stock = (Convert.ToInt32(Stock.Available_Stock) + Convert.ToInt32(row.Cells[6].Value));

                        if (Convert.ToInt32(Stock.Purchase_Price) <= Convert.ToInt32(row.Cells[7].Value))
                        {
                            Stock.Purchase_Price = PP;
                        }
                    }
                    else
                    {
                        int As = Convert.ToInt32(row.Cells[6].Value);

                        DB.Stocks.Add(new Stock { Material_Name = Material_Name, Type = Type, Colour = Colour, Track = Track, Size = Size, Available_Stock = As, Purchase_Price = PP });
                    }
                    DB.SaveChanges();
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
            dt.Rows.Clear();
            dgv_Remove.Rows.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(tb_ID.Text));
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
