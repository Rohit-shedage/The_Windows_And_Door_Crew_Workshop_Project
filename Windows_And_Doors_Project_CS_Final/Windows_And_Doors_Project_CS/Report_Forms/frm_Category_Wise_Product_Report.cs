using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_And_Doors_Project_CS.Report_Forms
{
    public partial class frm_Category_Wise_Product_Report : Form
    {
        public frm_Category_Wise_Product_Report()
        {
            InitializeComponent();
        }
        void DisplayReport()
        {

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {

                var Data = (from p in db.Products
                            where p.Catagory == cmb_Catagory.Text
                            select p
                            ).ToList();
                ReportDataSource Product = new ReportDataSource("DataSet1", Data);


                reportViewer1.LocalReport.ReportPath = @"F:\Rohit_Shedage\DotNet_Project_Slinding_Windows_and_Door\Windows_And_Doors_Project_CS_Final\Windows_And_Doors_Project_CS\Report_RDLC\Category_Wise_Product_RDLC.rdlc";
                reportViewer1.LocalReport.DataSources.Add(Product);
                reportViewer1.RefreshReport();
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cmb_Catagory.Text == "")
            {
                cmb_Catagory.SelectedIndex = 0;
            }
            reportViewer1.Reset();
            DisplayReport();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Catagory.SelectedIndex = 0;
            reportViewer1.Reset();
            DisplayReport();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            this.Close();
        }

        private void frm_Category_Wise_Product_Report_Load(object sender, EventArgs e)
        {
            cmb_Catagory.SelectedIndex = 0;
            reportViewer1.Reset();
            DisplayReport();
        }
    }
}
