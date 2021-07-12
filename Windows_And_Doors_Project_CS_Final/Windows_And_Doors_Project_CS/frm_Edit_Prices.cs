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
    public partial class frm_Edit_Prices : Form
    {
        public frm_Edit_Prices()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Edit_Prices_Load(object sender, EventArgs e)
        {
            Fill_DGV();
        }

        private void Fill_DGV()
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                dgv_Edit_Prices.DataSource = (from P in db.Products
                                              select new
                                              {
                                                  P.Product_Id,
                                                  P.Product_Name,
                                                  P.Catagory,
                                                  P.Price,
                                                  P.Time_To_Build,
                                                  P.Description,
                                                  P.Available_In_Track,
                                              }
                                             ).ToList();

                var C = (from i in db.Catagories select i.Name).ToList();

                foreach (var Obj in C)
                {
                    cmb_Catagory.Items.Add(Obj);
                }
            }
        }

        private void Clear_Controls()
        {
            cmb_Name.Text = "";
            tb_Name.Text = "";
            tb_Current_Selling_Prices.Text = "";
            tb_Purchase_Price_Cost.Text = "";
            tb_New_Price.Text = "";
            //cmb_Catagory.Items.Clear();
            // Fill_DGV();
        }

        private void lbl_New_Prices_Click(object sender, EventArgs e)
        {

        }

        private void tb_New_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_New_Price.Text != "")
            {
                string Ret = MessageBox.Show("Are You Sure To Update Amount..!!", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();

                if (Ret == "OK")
                {
                    using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                    {
                        var c = (from i in db.Products where i.Product_Name == cmb_Name.Text select i).FirstOrDefault();

                        if (c != null)
                        {
                            c.Price = Convert.ToDecimal(tb_New_Price.Text);
                            db.SaveChanges();
                        }
                    }

                    MessageBox.Show("Amount Updated Successfully..!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                    cmb_Catagory.Items.Clear();
                    Fill_DGV();
                    cmb_Catagory.SelectedIndex = -1;
                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("Amount Not Updated..!!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation).ToString();
                }

            }
            else
            {
                MessageBox.Show("Invalid Amount..!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_Catagory.SelectedIndex = -1;
            Clear_Controls();
        }

        private void cmb_Catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear_Controls();

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var c = (from i in db.Products where i.Catagory == cmb_Catagory.Text select i.Product_Name).ToList();

                cmb_Name.Items.Clear();

                foreach (var Obj in c)
                {
                    cmb_Name.Items.Add(Obj);
                }
            }
        }

        private void cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var c = (from i in db.Products where i.Product_Name == cmb_Name.Text select i).FirstOrDefault();

                if (c != null)
                {
                    tb_Name.Text = c.Product_Name;
                    tb_Current_Selling_Prices.Text = c.Price.ToString();
                    tb_Purchase_Price_Cost.Text = "-";
                }
                else
                {
                    MessageBox.Show("Invalid Name", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgv_Edit_Prices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgv_Edit_Prices.Rows[e.RowIndex].Cells[0].Value);

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var c = (from i in db.Products where i.Product_Id == ID select i).FirstOrDefault();

                tb_Name.Text = c.Product_Name;
                tb_Current_Selling_Prices.Text = c.Price.ToString();
                cmb_Catagory.Text = c.Catagory;
                cmb_Name.Text = c.Product_Name;
                tb_Purchase_Price_Cost.Text = "-";
            }
        }
    }
}
