using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_And_Doors_Project_CS
{
    public partial class frm_Add_New_Distributor : Form
    {
        public frm_Add_New_Distributor()
        {
            InitializeComponent();
            AutoIncrement();
            CLBItems();
        }
        private void AutoIncrement()
        {
            tb_Date.Text = DateTime.Now.ToString("dd-MM-yyyy");

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                int? ID = db.Distributors.Max(i => (int?)i.Distributor_Id);
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

        public frm_Add_New_Distributor(int iNo)
        {
            InitializeComponent();

           
           

                tbllpnl_Distributor_ID.Enabled = true;
                tb_ID.Enabled = true;
                btn_Search.Visible = true;
                btn_Search.Enabled = true;
                btn_Save.Text = "Update";
                lbl_Header.Text = "Update Distributor Details";
                btn_Close.Enabled = true;
                CLBItems();
                if (iNo != 0)
                {
                     Search(iNo);
                }
        }

        private void Search(int iNo)
        {
            rbtn_Window_Select.Checked = true;
            rbtn_Door_Select.Checked = true;
            rbtn_Other_Select.Checked = true;
            RadioButton(rbtn_Window_Select.Text,chlb_Windows_Material);
            RadioButton(rbtn_Door_Select.Text,chlb_Door_Material);
            RadioButton(rbtn_Other_Select.Text,chlb_Other);

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var ID = db.Distributors.Find(iNo);

                tb_ID.Text = ID.Distributor_Id.ToString();
                tb_Name.Text = ID.Distributor_Name.ToString();
                tb_Date.Text = ID.Added_Date.ToString("dd-MM-yyyy");
                tb_Mobile_No.Text = ID.Mobile_No.ToString();

                var Material = (from M in db.Distributor_Material where M.Distributor_Id == iNo select M.Material_Name).ToList();

                foreach (var item in Material)
                {
                    bool C = true;
                    if (C)
                    {
                        for (int i = 0; i < chlb_Windows_Material.Items.Count; i++)
                        {
                            if (item == chlb_Windows_Material.Items[i].ToString())
                            {
                                chlb_Windows_Material.SetItemChecked(i, true);
                                C = false;
                                break;
                            }
                        }
                    }
                    if (C)
                    {
                        for (int i = 0; i < chlb_Door_Material.Items.Count; i++)
                        {
                            if (item == chlb_Door_Material.Items[i].ToString())
                            {
                                chlb_Door_Material.SetItemChecked(i, true);
                                C = false;
                                break;
                            }
                        }
                    }
                    if (C)
                    {
                        for (int i = 0; i < chlb_Other.Items.Count; i++)
                        {
                            if (item == chlb_Other.Items[i].ToString())
                            {
                                chlb_Other.SetItemChecked(i, true);
                                C = false;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CLBItems()
        {
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                var Material = (from m in db.Material_Info where m.Group_Id == 1 || m.Group_Id == 2 select m.Material_Name).ToList();

                foreach (var M in Material)
                {
                    chlb_Windows_Material.Items.Add(M);
                }

                Material = (from m in db.Material_Info where m.Group_Id == 3 || m.Group_Id == 4 select m.Material_Name).ToList();

                foreach (var M in Material)
                {
                    chlb_Other.Items.Add(M);
                }
            }
        }

        private void RadioButton(string Name,CheckedListBox CLB)
        {
            if (Name == "All")
            {
                for (int i = 0; i < CLB.Items.Count; i++)
                {
                    CLB.SetItemChecked(i,true);
                }
                CLB.Enabled = false;
            }
            else if (Name == "None")
            {
                for (int i = 0; i < CLB.Items.Count; i++)
                {
                    CLB.SetItemChecked(i, false);
                }
                CLB.Enabled = false;
            }
            else
            {
                for (int i = 0; i < CLB.Items.Count; i++)
                {
                    CLB.SetItemChecked(i, false);
                }
                CLB.Enabled = true;
            }
        }
        private void frm_Add_New_Distributor_Load(object sender, EventArgs e)
        {
            //CLBItems();
        }

        private void btn_Select_All_Click(object sender, EventArgs e)
        {
            rbtn_Window_All.Checked = true;
            rbtn_Door_All.Checked = true;
            rbtn_Other_All.Checked = true;
            RadioButton(rbtn_Window_All.Text, chlb_Windows_Material);
            RadioButton(rbtn_Door_All.Text, chlb_Door_Material);
            RadioButton(rbtn_Other_All.Text, chlb_Other);
        }

        private void rbtn_Window_Select_CheckedChanged(object sender, EventArgs e)
        {
            chlb_Windows_Material.Enabled = true;
            RadioButton(rbtn_Window_Select.Text,chlb_Windows_Material);
        }

        private void rbtn_Window_None_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton(rbtn_Window_None.Text,chlb_Windows_Material);
        }

        private void rbtn_Window_All_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton(rbtn_Window_All.Text,chlb_Windows_Material);
        }

        private void rbtn_Door_All_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton(rbtn_Door_All.Text, chlb_Door_Material);
        }

        private void rbtn_Door_Select_CheckedChanged(object sender, EventArgs e)
        {
            chlb_Door_Material.Enabled = true;
            RadioButton(rbtn_Door_Select.Text, chlb_Door_Material);
        }

        private void rbtn_Door_None_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton(rbtn_Door_None.Text, chlb_Door_Material);
        }

        private void rbtn_Other_All_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton(rbtn_Other_All.Text, chlb_Other);
        }

        private void rbtn_Other_Select_CheckedChanged(object sender, EventArgs e)
        {
            chlb_Other.Enabled = true;
            RadioButton(rbtn_Other_Select.Text, chlb_Other);
        }

        private void rbtn_Other_None_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton(rbtn_Other_None.Text, chlb_Other);
        }

        private void CLBFillItems(int ID)
        {

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                if (rbtn_Window_None.Checked != true)
                {
                    for (int i = 0; i < chlb_Windows_Material.Items.Count; i++)
                    {
                        if (chlb_Windows_Material.GetItemCheckState(i) == CheckState.Checked)
                        {
                            db.Distributor_Material.Add(new Distributor_Material { Distributor_Id = ID, Material_Name = chlb_Windows_Material.Items[i].ToString() });
                            db.SaveChanges();                       
                        }
                    }
                }
                if (rbtn_Door_None.Checked != true)
                {
                    for (int i = 0; i < chlb_Door_Material.Items.Count; i++)
                    {
                        if (chlb_Door_Material.GetItemCheckState(i) == CheckState.Checked)
                        {
                            db.Distributor_Material.Add(new Distributor_Material { Distributor_Id = ID, Material_Name = chlb_Door_Material.Items[i].ToString() });
                            db.SaveChanges();
                        }
                    }
                }
                if (rbtn_Other_None.Checked != true)
                {
                    for (int i = 0; i < chlb_Other.Items.Count; i++)
                    {
                        if (chlb_Other.GetItemCheckState(i) == CheckState.Checked)
                        {
                            db.Distributor_Material.Add(new Distributor_Material { Distributor_Id = ID, Material_Name = chlb_Other.Items[i].ToString() });
                            db.SaveChanges();
                        }
                    }
                }

            }
        }

        private void Refresh()
        {
            tb_Name.Text = "";
            tb_Mobile_No.Text = "";
            RadioButton("None", chlb_Windows_Material);
            RadioButton("None", chlb_Door_Material);
            RadioButton("None", chlb_Other);
            rbtn_Door_All.Checked = false;
            rbtn_Door_None.Checked = false;
            rbtn_Door_Select.Checked = false;
            rbtn_Window_Select.Checked = false;
            rbtn_Window_None.Checked = false;
            rbtn_Window_All.Checked = false;
            rbtn_Other_Select.Checked = false;
            rbtn_Other_None.Checked = false;
            rbtn_Other_All.Checked = false;
        }

        private bool CheckFill()
        {
            if (tb_Name.Text != "" && tb_Mobile_No.Text != "")
            {
                return true;
            }
            return false;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "Save")
            {
                if (CheckFill())
                {
                    using (The_Windows_And_Door_Crew_DBEntities DB = new The_Windows_And_Door_Crew_DBEntities())
                    {
                        DateTime Date = Convert.ToDateTime(tb_Date.Text);
                        DB.Distributors.Add(new Distributor { Distributor_Name = tb_Name.Text, Added_Date = Date, Mobile_No = Convert.ToInt64(tb_Mobile_No.Text) });
                        DB.SaveChanges();
                        CLBFillItems(Convert.ToInt32(tb_ID.Text));

                        MessageBox.Show("Record Save Successfully...!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Refresh();
                    AutoIncrement();
                }
                else
                {
                    MessageBox.Show("1st Fill All The Field...!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                if (CheckFill())
                {
                    using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
                    {
                        DateTime Date = Convert.ToDateTime(tb_Date.Text);
                        int ID = Convert.ToInt32(tb_ID.Text);

                        var Dist = db.Distributors.Find(Convert.ToInt32(tb_ID.Text));

                        if (Dist != null)
                        {
                            Dist.Distributor_Name = tb_Name.Text;
                            Dist.Mobile_No = Convert.ToInt64(tb_Mobile_No.Text);
                        }

                        db.SaveChanges();
                        db.Distributor_Material.RemoveRange(db.Distributor_Material.Where(dm => dm.Distributor_Id == ID));
                        db.SaveChanges();
                        CLBFillItems(Convert.ToInt32(tb_ID.Text));

                        MessageBox.Show("Record Update Successfully...!!!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                        tb_ID.Text = "";
                        tb_Date.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("1st Fill All The Field...!!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search(Convert.ToInt32(tb_ID.Text));
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
