using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace Grocery_Store_Management
{
    public partial class Report : Form
    {
        string invoice_id;   

    
        public Report(string id)
        {
            invoice_id = id;

            InitializeComponent();
        }
        string db_path = "Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=cloth sales;Data Source=CYBERSPACE";
        private void Report_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(db_path);
            SqlDataAdapter da = new SqlDataAdapter("select * from cloth_table where ID =" + invoice_id, conn);
            DataTable dt = new DataTable();
            cloth_salesDataSet ds = new cloth_salesDataSet();
            da.Fill(ds, "cloth_dataset");

            ReportDataSource dataSource = new ReportDataSource("DataSet_sale_report", ds.Tables[0]);


            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
            
        }

        

        private void btn_search_Click(object sender, EventArgs e)
        {
             SqlConnection conn = new SqlConnection(db_path);
            SqlDataAdapter da = new SqlDataAdapter("select * from cloth_table where ID =" + txt_search, conn);
            DataTable dt = new DataTable();
            cloth_salesDataSet ds = new cloth_salesDataSet();
            da.Fill(ds, "cloth_dataset");

            ReportDataSource dataSource = new ReportDataSource("DataSet_sale_report", ds.Tables[0]);


            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
