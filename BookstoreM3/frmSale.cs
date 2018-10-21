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
using System.Globalization;
using System.IO;
using Microsoft.Reporting.WinForms;


namespace BookstoreM3
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
            ConnectDatabase.Myconnection();
            timer1.Start();
        }
        DataTable dt;
        SqlDataAdapter da;
        decimal Total = 0;
        decimal amount;
        decimal total_kh = 0;
        int cat_id;
        Sell s = new Sell();



        private void cboproName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            s.GetProbyProName(txtproID,txtprice, cboproName, cboCategory);     

        }

        private void frmSale_Load(object sender, EventArgs e)
        {

            s.GetPro(cboproName);
            s.GetCate(cboCategory);
           
            //listsale.Clear();
            //listsale.View = View.Details;
            //listsale.Columns.Add("Code", 75);
            //listsale.Columns.Add("Name", 120);
            //listsale.Columns.Add("Category", 100);
            //listsale.Columns.Add("Quanlity", 100);
            //listsale.Columns.Add("Price", 75);
            //listsale.Columns.Add("Amount", 85);
            //listsale.Columns.Add("Cat_ID", 0);
            //listsale.Columns.Add("Photo", 0);
            dgvSale.Columns[0].Width = 75;
            dgvSale.Columns[1].Width = 120;
            dgvSale.Columns[2].Width = 100;
            dgvSale.Columns[3].Width = 100;
            dgvSale.Columns[4].Width = 75;
            dgvSale.Columns[5].Width = 85;
            dgvSale.Columns[6].Width = 0;
            GetSaleID();
            btnRemove.Enabled = false;

        }
        private void GetSaleID()
        {
            da = new SqlDataAdapter("select MAX(id) from tblSale", ConnectDatabase.con);
            dt = new DataTable();
            da.Fill(dt);
            int id = 0;
            if (dt.Rows.Count > 0)
            {
                string[] arr = new string[1];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    arr[0] = dr[0].ToString();
                    id = int.Parse(arr[0]);
                    lblpayment.Text = (id + 1).ToString();

                }
            }
            else
            {
                lblpayment.Text = "";
            }

            da.Dispose();
            dt.Dispose();
        }

        private void txtproID_TextChanged(object sender, EventArgs e)
        {
            s.GetProbyId(txtproID, txtprice, cboproName, cboCategory);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrEmpty(txtproID.Text) || string.IsNullOrWhiteSpace(txtproID.Text))
            {
                MessageBox.Show("Invalid product id!");
                txtproID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtqty.Text) || string.IsNullOrWhiteSpace(txtqty.Text))
            {
                MessageBox.Show("Invalid product quantity!");
                txtqty.Focus();
                return;
            }
            int qty = int.Parse(txtqty.Text);
            if (qty > Sell.qty)
            {
                MessageBox.Show("You can not sell! your product in stock have only:" + Sell.qty);
                txtqty.Focus();
                return;
            }
            //ListViewItem item;
            //string[] arr = new string[8];
            //arr[0] = txtproID.Text;
            //arr[1] = cboproName.Text;
            //arr[2] = cboCategory.Text;
            //arr[3] = txtqty.Text;
            //arr[4] = string.Format("{0:c}", txtprice.Text);
            //amount = decimal.Parse(txtqty.Text) * decimal.Parse(txtprice.Text,NumberStyles.Currency);
            //arr[5] = string.Format("{0:c}", amount);
            //// arr[5] = cboCate.Text;
            //arr[6] = cboCategory.SelectedValue.ToString();
            //cat_id = int.Parse(arr[6]);
            //arr[7] = Sell.photo;
            ////MessageBox.Show(arr[7]);
            //item = new ListViewItem(arr);
            //listsale.Items.Add(item);
            //Total = Total + amount;
            //txtsubTotal.Text = string.Format("{0:c}", Total);
            //txtpaymentus.Text = string.Format("{0:c}", Total);
            //total_kh = Total * 4000;
            //txtpaymentkh.Text = total_kh.ToString();
            DataTable dt = new DataTable();
            dt =(DataTable)dgvSale.DataSource;
            string[] arr = new string[8];
            arr[0] = txtproID.Text;
            arr[1] = cboproName.Text;
            arr[2] = cboCategory.Text;
            arr[3] = txtqty.Text;
            arr[4] = string.Format("{0:c}", txtprice.Text);
            amount = decimal.Parse(txtqty.Text) * decimal.Parse(txtprice.Text, NumberStyles.Currency);
            arr[5] = string.Format("{0:c}", amount);
            // arr[5] = cboCate.Text;
            arr[6] = cboCategory.SelectedValue.ToString();
            cat_id = int.Parse(arr[6]);
            //ms = new MemoryStream(Sell.photo);

            //// MessageBox.Show(ms.ToString());
            //arr[7] = ms.ToString();
            //MessageBox.Show(arr[7]);
            dgvSale.Rows.Add(arr);
            dgvSale.ClearSelection();
            Total = Total + amount;
            txtsubTotal.Text = string.Format("{0:c}", Total);
            txtpaymentus.Text = string.Format("{0:c}", Total);
            total_kh = Total * 4000;
            txtpaymentkh.Text = total_kh.ToString();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult re;
            //foreach (DataGridView item in dgvSale.Rows)
            //{
            //    if (item.CellClick)
            //    {
            //        re = MessageBox.Show("Do you want to remove?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (re == DialogResult.Yes)
            //        {
            //            ListViewItem it = listsale.SelectedItems[0];
            //            listsale.Items.Remove(item);
            //            var a = decimal.Parse(it.SubItems[5].Text, NumberStyles.Currency);
            //            Total = Total - a;
            //            txtsubTotal.Text = string.Format("{0:c}", Total);
            //            txtpaymentus.Text = string.Format("{0:c}", Total);
            //            total_kh = Total * 400;
            //            txtpaymentkh.Text = total_kh.ToString();
            //        }
            //    }
            ////}
            
            if (this.dgvSale.SelectedRows.Count > 0)
            {
                re = MessageBox.Show("Do you want to remove?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    var a = decimal.Parse(this.dgvSale.SelectedRows[0].Cells[5].Value.ToString(),NumberStyles.Currency);
                    dgvSale.Rows.RemoveAt(this.dgvSale.SelectedRows[0].Index);
                    Total = Total - a;
                    txtsubTotal.Text = string.Format("{0:c}", Total);
                    txtpaymentus.Text = string.Format("{0:c}", Total);
                    total_kh = Total * 400;
                    txtpaymentkh.Text = total_kh.ToString();
                    txtproID.Text = "";
                    txtqty.Text = "";
                    btnRemove.Enabled = false;
                }
            }
        }

        private void listsale_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            string value = txtdiscount.Text;
            decimal discount;
            if (value == "")
            {
                MessageBox.Show("no discount?, input '0'");
                txtdiscount.Text = "0";
            }
            else
            {
                decimal subtotal = decimal.Parse(txtsubTotal.Text,NumberStyles.Currency);
                
                //if (string.IsNullOrEmpty(txtdiscount.Text)||string.IsNullOrWhiteSpace(txtdiscount.Text))
                //{
                //    discount = 0;
                //}
                 
                discount=decimal.Parse(txtdiscount.Text);
                decimal paymentus= ((100 - discount) / 100) * subtotal;
                decimal paymentkh= ((100 - discount) / 100) * (subtotal*4000);
                txtpaymentus.Text = string.Format("{0:c}",paymentus.ToString());
                txtpaymentkh.Text = paymentkh.ToString();
            }
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpaidkh.Text) || string.IsNullOrWhiteSpace(txtpaidkh.Text))
            {
                MessageBox.Show("Invalid customer payment!");
                return;
            }
            //if (decimal.Parse(txtpaymentkh.Text) <decimal.Parse(txtpaidkh.Text))
            //{
            //    MessageBox.Show("Your money not enough!");
            //    return;
            //}
            //DateTime time = DateTime.Now;
            //string empid = ConnectDatabase.empID;
            //decimal total = Decimal.Parse(txtpaymentus.Text, NumberStyles.Currency);
            //string format = "yyyy-MM-dd hh:mm:ss";
            //foreach (ListViewItem list in listsale.Items)
            //{
            //    SqlCommand com = new SqlCommand("insert into tblSale(Date,pro_name,quantity,unit_price,amount,emp_ID,cat_ID) VALUES('" + time.ToString(format) + "','" + list.SubItems[1].Text + "','" + list.SubItems[3].Text + "','" + list.SubItems[4].Text + "','" + total + "','" + empid + "','" + cat_id + "')", ConnectDatabase.con);
            //    com.ExecuteNonQuery();
            //    SqlCommand com1 = new SqlCommand("UpdateProduct", ConnectDatabase.con);
            //    com1.CommandType = CommandType.StoredProcedure;
            //    com1.Parameters.AddWithValue("@code", list.SubItems[0].Text);
            //    com1.Parameters.AddWithValue("@name", list.SubItems[1].Text);
            //    int qty = int.Parse(list.SubItems[3].Text);
            //    int newqty = (Sell.qty - qty);
            //    image = (byte[])list.SubItems[7].Text;
            //    com1.Parameters.AddWithValue("@qty", newqty);
            //    com1.Parameters.AddWithValue("@price", list.SubItems[4].Text);
            //    com1.Parameters.AddWithValue("@photo", image);
            //    com1.Parameters.AddWithValue("@cat_id", list.SubItems[6].Text);
            //    com1.ExecuteNonQuery();

            //}
            //GetSaleID();
            //ConnectDatabase.ClearData(this);
            //listsale.Items.Clear();
            DateTime time = DateTime.Now;
            string empid = ConnectDatabase.empID;
            decimal total = Decimal.Parse(txtpaymentus.Text, NumberStyles.Currency);
            string format = "yyyy-MM-dd hh:mm:ss";

            DataTable dtinvoice = new DataTable();
            dtinvoice.Columns.Add("No", typeof(int));
            dtinvoice.Columns.Add("proID", typeof(string));
            dtinvoice.Columns.Add("proName", typeof(string));
            dtinvoice.Columns.Add("qty", typeof(int));
            dtinvoice.Columns.Add("unitprice", typeof(float));
            dtinvoice.Columns.Add("amount", typeof(float));
            int index = 1;
            for (int i = 0; i < dgvSale.Rows.Count; i++)
            {
                string pid = dgvSale.Rows[i].Cells[0].Value.ToString();
                string pn = dgvSale.Rows[i].Cells[1].Value.ToString();
                int q = int.Parse(dgvSale.Rows[i].Cells[3].Value.ToString());
                float up = float.Parse(dgvSale.Rows[i].Cells[4].Value.ToString(),NumberStyles.Currency);
                dtinvoice.Rows.Add(index,pid, pn, q, up, q * up);


                SqlCommand com = new SqlCommand("insert into tblSale(Date,pro_name,quantity,unit_price,amount,emp_ID,cat_ID) VALUES('" + time.ToString(format) + "','" + dgvSale.Rows[i].Cells[1].Value + "','" + dgvSale.Rows[i].Cells[3].Value + "','" + dgvSale.Rows[i].Cells[4].Value + "','" + total + "','" + empid + "','" + cat_id + "')", ConnectDatabase.con);
                com.ExecuteNonQuery();
                SqlCommand com1 = new SqlCommand("UpdateProBySale", ConnectDatabase.con);
                com1.CommandType = CommandType.StoredProcedure;
                com1.Parameters.AddWithValue("@code", dgvSale.Rows[i].Cells[0].Value);
                int qty = int.Parse(dgvSale.Rows[i].Cells[3].Value.ToString());
                int newqty = (Sell.qty - qty);
                com1.Parameters.AddWithValue("@qty", newqty);
                com1.ExecuteNonQuery();
                index++; 
            }
            frmRptInvoice RptInvoice = new frmRptInvoice();
            RptInvoice.Vinv.ProcessingMode = ProcessingMode.Local;
            LocalReport lRpt = RptInvoice.Vinv.LocalReport;
            lRpt.DisplayName = "rptInvoice.rdlc";
            lRpt.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("dsInvoice", dtinvoice);
            lRpt.DataSources.Add(rds);

            ReportParameter p1 = new ReportParameter("InvNo", lblpayment.Text);
            lRpt.SetParameters(p1);
            ReportParameter p2 = new ReportParameter("InvDate", time.ToString("ddd-MM-yyy hh:mm:ss"));
            lRpt.SetParameters(p2);
            ReportParameter p3 = new ReportParameter("Emp",ConnectDatabase.empName);
            lRpt.SetParameters(p3);
            ReportParameter p4 = new ReportParameter("subTotal", txtsubTotal.Text);
            lRpt.SetParameters(p4);
            if (txtdiscount.Text == "")
            {
                ReportParameter p5 = new ReportParameter("discount", "0");
                lRpt.SetParameters(p5);
            }
            else
            {
                ReportParameter p55 = new ReportParameter("discount", txtdiscount.Text);
                lRpt.SetParameters(p55);
            }
           
            
            ReportParameter p6 = new ReportParameter("paymentKh", txtpaymentkh.Text);
            lRpt.SetParameters(p6);
            ReportParameter p7 = new ReportParameter("peymentUs", txtpaymentus.Text);
            lRpt.SetParameters(p7);
            ReportParameter p8 = new ReportParameter("returnKh", txtreturnkh.Text);
            lRpt.SetParameters(p8);
            ReportParameter p9 = new ReportParameter("returnUs", txtreturnus.Text);
            lRpt.SetParameters(p9);


            RptInvoice.Show();
            RptInvoice.Vinv.RefreshReport();

            
            

        }

        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void txtpaidkh_TextChanged(object sender, EventArgs e)
        {
            if (txtpaidkh.Text == "")
            {
                txtpaidkh.Text = "0";
            }
            float paidus;
            float paidkh = float.Parse(txtpaidkh.Text);
            if (txtpaidus.Text == "")
            {
                txtpaidus.Text = "0";
            }
            paidus = float.Parse(txtpaidus.Text);
            float paymenkh = float.Parse(txtpaymentkh.Text);
            float paymenus = float.Parse(txtpaymentus.Text, NumberStyles.Currency);
            float returnkh = 0;
            if (txtpaidus.Text == "")
            {

                //returnkh = (paidkh + exchangtous) - paymenkh;
                returnkh = paidkh - paymenkh;
                txtreturnkh.Text = returnkh.ToString();
            }
            else
            {
                float returnus;
                float exchangtous = paidus * 4000;
                returnkh = (paidkh + exchangtous) - paymenkh;
                txtreturnkh.Text = returnkh.ToString();
                returnus = (paidus / 4000) + paymenus;

                txtreturnus.Text = string.Format("{0:c}", returnus);


                if (txtreturnus.Text != "")
                {
                    returnus = returnkh / 4000;
                    txtreturnus.Text = string.Format("{0:c}",returnus);
                }
            }
        }

        private void txtpaidus_TextChanged(object sender, EventArgs e)
        {
            if (txtpaidkh.Text == "")
            {
                txtpaidkh.Text = "0";
            }
            float paidus;
            float paidkh = float.Parse(txtpaidkh.Text);
            if (txtpaidus.Text == "")
            {
                txtpaidus.Text = "0";
            }
            paidus = float.Parse(txtpaidus.Text);
            float paymenkh = float.Parse(txtpaymentkh.Text);
            float paymenus = float.Parse(txtpaymentus.Text, NumberStyles.Currency);
            float returnkh = 0;
            float returnus;

            float exchangtous = paidkh / 4000;
            returnus = (paidus + exchangtous) - paymenus;
            txtreturnus.Text = string.Format("{0:c}",returnus);
            returnkh = returnus * 4000;
            //returnus = returnkh / 4000;
            txtreturnkh.Text = returnkh.ToString();

        }

        
    }
}
