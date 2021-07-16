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
    public partial class frm_Montly_Stocks_Report : Form
    {
        public frm_Montly_Stocks_Report()
        {
            InitializeComponent();
        }

        private void frm_Montly_Stocks_Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            int C_Month = System.DateTime.Today.Month;

            cmb_Month.SelectedIndex = C_Month - 1;
            reportViewer1.Reset();
            DisplayReport();
            
        }

        //private DataTable Std()
        //{
        //    Connect();

        //    DataTable dt = new DataTable();
        //    SqlCommand cmd = new SqlCommand("Select * FROM tbl_Add_User", con);
        //    SqlDataReader sdr = cmd.ExecuteReader();
        //    dt.Load(sdr);
        //    return dt;

        //}

        void DisplayReport()
        {
            
            using (The_Windows_And_Door_Crew_DBEntities db = new The_Windows_And_Door_Crew_DBEntities())
            {
                int C_Month = cmb_Month.SelectedIndex + 1;
                var Data = (from s in db.Stock_Order
                            join si in db.Stock_Order_Items on s.Order_Stock_Id equals si.Order_Stock_Id
                            where s.Date.Month == C_Month
                            select new
                            {
                                s.Order_Stock_Id,
                                s.Distributor_Name,
                                s.Date,
                                si.Material_Name,
                                si.Type,
                                si.Colour,
                                si.Track,
                                si.Size,
                                si.Quantity,
                                si.Purchase_Price,
                                s.Total,
                                s.Paid_Amount,
                                s.Remaining_Amount,
                            }
                            ).ToList();
                ReportDataSource Login = new ReportDataSource("DataSet1", Data);
                ReportDataSource Login1 = new ReportDataSource("DataSet2", Data);

                reportViewer1.LocalReport.ReportPath = @"F:\Rohit_Shedage\DotNet_Project_Slinding_Windows_and_Door\Windows_And_Doors_Project_CS_Final\Windows_And_Doors_Project_CS\Report_RDLC\Montly_Stock.rdlc";
                reportViewer1.LocalReport.DataSources.Add(Login);
                reportViewer1.LocalReport.DataSources.Add(Login1);
                reportViewer1.RefreshReport();
                reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            }
           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            reportViewer1.Reset();
            DisplayReport();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            int C_Month = System.DateTime.Today.Month;
          
            cmb_Month.SelectedIndex = C_Month - 1;
            reportViewer1.Reset();
            DisplayReport();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
