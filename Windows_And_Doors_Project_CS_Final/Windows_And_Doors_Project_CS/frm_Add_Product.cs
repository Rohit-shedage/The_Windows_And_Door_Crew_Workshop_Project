using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_And_Doors_Project_CS
{
    public partial class frm_Add_Product : Form
    {
        public frm_Add_Product()
        {
            InitializeComponent();
            AutoIncrement();
            CLBItems();
        }

        //private int P_Cnt = 0;

        public frm_Add_Product(int iNo)
        {
            InitializeComponent();

            tbllpnl_Product_Details.Enabled = true;
            lbl_Header.Text = "Update Product";

            btn_Search.Visible = true;
            btn_Search.Enabled = true;
            btn_Save.Text = "Update";
            tb_ID.Enabled = true;

            btn_Close.Enabled = true;

            CLBItems();

            if (iNo != 0)
            {
                Search(iNo);
            }

        }

        private void AutoIncrement()
        {


            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                int? ID = db.Products.Max(i => (int?)i.Product_Id);
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

        private void Search(int ID)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var Prod = db.Products.Find(ID);

                if (Prod != null)
                {
                    if (Prod.Available_In_Track == rbtn_Yes.Text)
                    {
                        rbtn_Yes.Checked = true;
                    }
                    else
                    {
                        rbtn_No.Checked = true;
                    }

                    tb_ID.Text = Prod.Product_Id.ToString();
                    tb_Name.Text = Prod.Product_Name;
                    cmb_Catagory.Text = Prod.Catagory;
                    tb_Price_By_SQFT.Text = Prod.Price.ToString();
                    cmb_Required_Time_To_Build.Text = Prod.Time_To_Build.ToString();
                    tb_Description.Text = Prod.Description;

                    MemoryStream ms = new MemoryStream((byte[])Prod.Image);

                    pb_Product.Image = new Bitmap(ms);

                    var Material = (from m in db.Product_Material where m.Product_Id == ID select m.Material_Name).ToList();

                    foreach (var item in Material)
                    {
                        bool C = true;
                        if (C)
                        {
                            for (int i = 0; i < clb_Material.Items.Count; i++)
                            {
                                if (item == clb_Material.Items[i].ToString())
                                {
                                    clb_Material.SetItemChecked(i, true);
                                    C = false;
                                    break;
                                }
                            }
                        }
                        if (C)
                        {
                            for (int i = 0; i < clb_Glass.Items.Count; i++)
                            {
                                if (item == clb_Glass.Items[i].ToString())
                                {
                                    clb_Glass.SetItemChecked(i, true);
                                    C = false;
                                    break;
                                }
                            }
                        }
                        if (C)
                        {
                            for (int i = 0; i < clb_Other.Items.Count; i++)
                            {
                                if (item == clb_Other.Items[i].ToString())
                                {
                                    clb_Other.SetItemChecked(i, true);
                                    C = false;
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void CLBItems()
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var Material = (from m in db.Material_Info where m.Group_Id == 1 select m.Material_Name).ToList();

                foreach (var m in Material)
                {
                    clb_Material.Items.Add(m);
                }

                Material = (from m in db.Material_Info where m.Group_Id == 2 select m.Material_Name).ToList();

                foreach (var m in Material)
                {
                    clb_Glass.Items.Add(m);
                }

                Material = (from m in db.Material_Info where m.Group_Id == 3 || m.Group_Id == 4 select m.Material_Name).ToList();

                foreach (var m in Material)
                {
                    clb_Other.Items.Add(m);
                }
            }
        }

        private void Refresh()
        {
            tb_ID.Text = "";
            if (btn_Save.Text == "Save")
            {
                AutoIncrement();
            }
            tb_Name.Text = "";
            cmb_Catagory.Text = "";
            tb_Price_By_SQFT.Text = "";
            tb_Description.Text = "";
            cmb_Required_Time_To_Build.Text = "";
            pb_Product.Image = null;
            rbtn_No.Checked = false;
            rbtn_Yes.Checked = false;
            for (int i = 0; i < clb_Material.Items.Count; i++)
            {
                clb_Material.SetItemChecked(i, false);
            }

            for (int i = 0; i < clb_Glass.Items.Count; i++)
            {
                clb_Glass.SetItemChecked(i, false);
            }

            for (int i = 0; i < clb_Other.Items.Count; i++)
            {
                clb_Other.SetItemChecked(i, false);
            }

        }

        private void SelectAll(Button btn, CheckedListBox clb)
        {
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.SetItemChecked(i, true);
            }
        }

       

       

       

       

       

       

      

        private bool CheckFill()
        {
            if (tb_ID.Text != "" && tb_Name.Text != "" && cmb_Catagory.Text != "" && tb_Price_By_SQFT.Text != "" && cmb_Required_Time_To_Build.Text != "" && tb_Description.Text != "" && pb_Product.Image != null && (rbtn_No.Checked == true || rbtn_Yes.Checked == true))
            {
                return true;
            }

            return false;
        }

        private Image ByteArrayToImage(byte[] vs)
        {
            throw new NotImplementedException();
        }

        private void InsertCLBItems(int ID)
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                for (int i = 0; i < clb_Material.Items.Count; i++)
                {
                    if (clb_Material.GetItemCheckState(i) == CheckState.Checked)
                    {
                        db.Product_Material.Add(new Product_Material() { Product_Id = ID, Material_Name = clb_Material.Items[i].ToString() });

                    }
                }

                for (int i = 0; i < clb_Other.Items.Count; i++)
                {
                    if (clb_Other.GetItemCheckState(i) == CheckState.Checked)
                    {
                        db.Product_Material.Add(new Product_Material() { Product_Id = ID, Material_Name = clb_Other.Items[i].ToString() });

                    }
                }

                for (int i = 0; i < clb_Glass.Items.Count; i++)
                {
                    if (clb_Glass.GetItemCheckState(i) == CheckState.Checked)
                    {
                        db.Product_Material.Add(new Product_Material() { Product_Id = ID, Material_Name = clb_Glass.Items[i].ToString() });

                    }
                }
                db.SaveChanges();

            }
        }
       

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(tb_ID.Text));
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckFill())
            {
                using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                {
                    ImageConverter icon = new ImageConverter();
                    byte[] imgArray = (byte[])icon.ConvertTo(pb_Product.Image, typeof(byte[])); //Image Exception Hanling is Requried

                    string rb = "No";
                    int ID = Convert.ToInt32(tb_ID.Text);

                    if (rbtn_Yes.Checked)
                    {
                        rb = rbtn_Yes.Text;
                    }

                    if (btn_Save.Text == "Save")
                    {
                        db.Products.Add(new Product() { Product_Name = tb_Name.Text, Catagory = cmb_Catagory.Text, Price = Convert.ToDecimal(tb_Price_By_SQFT.Text), Time_To_Build = Convert.ToDouble(cmb_Required_Time_To_Build.Text), Description = tb_Description.Text, Image = imgArray, Available_In_Track = rb });
                        db.SaveChanges();

                        InsertCLBItems(ID);

                        MessageBox.Show("Record Save Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Refresh();
                        rb = "";
                    }
                    else
                    {
                        var Prod = db.Products.Find(ID);

                        if (Prod != null)
                        {
                            Prod.Product_Name = tb_Name.Text;
                            Prod.Catagory = cmb_Catagory.Text;
                            Prod.Price = Convert.ToDecimal(tb_Price_By_SQFT.Text);
                            Prod.Time_To_Build = Convert.ToInt32(cmb_Required_Time_To_Build.Text);
                            Prod.Description = tb_Description.Text;
                            Prod.Available_In_Track = rb;
                            Prod.Image = imgArray;

                            db.SaveChanges();

                            db.Product_Material.RemoveRange(db.Product_Material.Where(pm => pm.Product_Id == ID));

                            InsertCLBItems(ID);

                            rb = "";
                        }
                    }
                }

                Refresh();


            }
            else
            {
                MessageBox.Show("1st Fill All The Filleds", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btn_Upload_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Display Image In Picture Box
                pb_Product.Image = new Bitmap(open.FileName);
                //Image File Path

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Catagory.Text == "Door")
            {
                clb_Glass.Enabled = false;
                clb_Material.Enabled = false;
                clb_Other.Enabled = false;

                btn_Glass_Select_All.Enabled = false;
                btn_Material_Select_All.Enabled = false;
                btn_Other_Select_All.Enabled = false;

                for (int i = 0; i < clb_Material.Items.Count; i++)
                {
                    clb_Material.SetItemChecked(i, false);
                }

                for (int i = 0; i < clb_Glass.Items.Count; i++)
                {
                    clb_Glass.SetItemChecked(i, false);
                }

                for (int i = 0; i < clb_Other.Items.Count; i++)
                {
                    clb_Other.SetItemChecked(i, false);
                }
            }
            else
            {
                clb_Glass.Enabled = true;
                clb_Material.Enabled = true;
                clb_Other.Enabled = true;

                btn_Glass_Select_All.Enabled = true;
                btn_Material_Select_All.Enabled = true;
                btn_Other_Select_All.Enabled = true;
            }
        }

        private void btn_Other_Select_All_Click(object sender, EventArgs e)
        {
            SelectAll(btn_Other_Select_All, clb_Other);
        }

        private void btn_Glass_Select_All_Click(object sender, EventArgs e)
        {
            SelectAll(btn_Glass_Select_All, clb_Glass);
        }

        private void btn_Material_Select_All_Click(object sender, EventArgs e)
        {
            SelectAll(btn_Material_Select_All, clb_Material);
        }
    }
}
