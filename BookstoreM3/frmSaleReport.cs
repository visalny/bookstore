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

namespace BookstoreM3
{
    public partial class frmSaleReport : Form
    {
        public frmSaleReport()
        {
            InitializeComponent();
            ConnectDatabase.Myconnection();
        }
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        DateTime dsta;
        DateTime dsto;

        private void dtpstart_ValueChanged(object sender, EventArgs e)
        {
            dtpstop.Value = dtpstart.Value;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            dsta = dtpstart.Value;
            dsto = dtpstop.Value;
            listreport.Clear();
            listreport.View = View.Details;
            listreport.Columns.Add("Date",150);
            listreport.Columns.Add("Pro_Name",110);
            listreport.Columns.Add("Quantity",80);
            listreport.Columns.Add("Unit Price",90);
            listreport.Columns.Add("Amount",90);
            listreport.Columns.Add("Type",110);
            listreport.Columns.Add("Employee",110);
            if (dsta > dsto)
            {
                MessageBox.Show("Invalid date...");
                return;
            }
            else
            {
                com = new SqlCommand("SaleReport", ConnectDatabase.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@SA", dsta);
                com.Parameters.AddWithValue("@SO", dsto);
                com.ExecuteNonQuery();
                da = new SqlDataAdapter();
                da.SelectCommand = com;
                dt = new DataTable();
                da.Fill(dt);
                ListViewItem item;
                string[] arr = new string[7];
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    DataRow dr = dt.Rows[i];
                    arr[0] = dr[0].ToString();
                    arr[1] = dr[1].ToString();
                    arr[2] = dr[2].ToString();
                    arr[3] = dr[3].ToString();
                    arr[4] = dr[4].ToString();
                    arr[5] = dr[5].ToString();
                    arr[6] = dr[6].ToString();
                    item = new ListViewItem(arr);
                    listreport.Items.Add(item);

                }
                foreach (ListViewItem list in listreport.Items)
                {
                    if ((list.Index % 2) == 0)
                        list.BackColor = Color.White;
                    else
                        list.BackColor = Color.LightBlue;
                }
                da.Dispose();
                dt.Dispose();

            }
            btnpreview.Enabled = true;
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            DataTable dtsale = new DataTable();
            dtsale.Columns.Add("rDate", typeof(string));
            dtsale.Columns.Add("rproName", typeof(string));
            dtsale.Columns.Add("rqty", typeof(int));
            dtsale.Columns.Add("rprice", typeof(float));
            dtsale.Columns.Add("amount", typeof(float));
            dtsale.Columns.Add("remp", typeof(string));
            dtsale.Columns.Add("rcate", typeof(string));

            // string[] arr = new string[7];
            //if (listreport.Items == null)
            //{
            //    MessageBox.Show("No Data to print!", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (dt.Rows.Count < 0)
            //{
            //    MessageBox.Show("No Data to print!", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            decimal total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataRow dr = dt.Rows[i];
                string date = dr[0].ToString();
                string proname = dr[1].ToString();
                int qty = int.Parse(dr[2].ToString());
                decimal price =decimal.Parse( dr[3].ToString());
                decimal amount = decimal.Parse(dr[4].ToString());
                string emp = dr[6].ToString();
                string cate = dr[5].ToString();
               // MessageBox.Show(amount.ToString());
                //item = new ListViewItem(arr);
                //listreport.Items.Add(item);
                dtsale.Rows.Add(date, proname, qty, price, amount, emp, cate);
                total = total + amount;

            }
            frmRptSaleReport RptSale = new frmRptSaleReport();
            RptSale.Vspt.ProcessingMode = ProcessingMode.Local;
            LocalReport lRpt = RptSale.Vspt.LocalReport;
            lRpt.DisplayName = "rptSale.rdlc";
            lRpt.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("dsSale", dtsale);
            lRpt.DataSources.Add(rds);

            ReportParameter p = new ReportParameter("rdate", time.ToString("dd-MM-yyyy hh:mm:ss"));
            lRpt.SetParameters(p);
            ReportParameter p2 = new ReportParameter("total", total.ToString());
            lRpt.SetParameters(p2);


            RptSale.Show();
            RptSale.Vspt.RefreshReport();
        }
    }
}
