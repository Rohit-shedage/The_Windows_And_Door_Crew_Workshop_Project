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
    public partial class frm_Date_Wise_Orders : Form
    {
        public frm_Date_Wise_Orders()
        {
            InitializeComponent();
        }

        void DisplayReport()
        {

            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                
                var Data = (from o in db.Orders
                            join oi in db.Ordered_Items on o.Order_Id equals oi.Order_Id
                            where o.Order_Date >= dtp_From.Value.Date && o.Order_Date <= dtp_To.Value.Date
                            select new
                            {
                                o.Order_Date,
                                oi.Order_Id,
                                oi.Catagory,
                                oi.Sub_Catagory,
                                oi.Material_Type,
                                oi.Colour,
                                oi.Glass_Type,
                                oi.Track,
                                oi.Height,
                                oi.Width,
                                oi.Quantity,
                                
                            }
                            ).ToList();
                ReportDataSource DS1 = new ReportDataSource("DataSet1", Data);
                ReportDataSource DS2 = new ReportDataSource("DataSet2", Data);

                reportViewer1.LocalReport.ReportPath = @"F:\Rohit_Shedage\DotNet_Project_Slinding_Windows_and_Door\Windows_And_Doors_Project_CS_Final\Windows_And_Doors_Project_CS\Report_RDLC\Date_Wise_Order_RDLC.rdlc";
                reportViewer1.LocalReport.DataSources.Add(DS1);
                reportViewer1.LocalReport.DataSources.Add(DS2);
                reportViewer1.RefreshReport();
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            }

        }

        private void frm_Date_Wise_Orders_Load(object sender, EventArgs e)
        {
            dtp_From.Value = DateTime.Now;
            dtp_To.Value = DateTime.Now;
            reportViewer1.Reset();
            DisplayReport();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            DisplayReport();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dtp_From.Value = DateTime.Now;
            dtp_To.Value = DateTime.Now;
            reportViewer1.Reset();
            DisplayReport();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
