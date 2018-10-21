using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BookstoreM3
{
    class Product
    {
        public string pid;
        private string pname;
        private int qty;
        private double price;
        public static SqlDataAdapter da;
        public static SqlCommand com;
        public static DataTable dt;
        public Product() { }

        public string Pid
        {
            get
            {
                return pid;
            }

            set
            {
                pid = value;
            }
        }

        public string Pname
        {
            get
            {
                return pname;
            }

            set
            {
                pname = value;
            }
        }

        public int Qty
        {
            get
            {
                return qty;
            }

            set
            {
                qty = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public void Modify(string procedure,string pid,string name,int qty,double price,int catid)
        {
            com = new SqlCommand(procedure, ConnectDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@code", pid);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@qty", qty);
            com.Parameters.AddWithValue("@price", price);
            com.Parameters.AddWithValue("@cat_id", catid);
            if (frmProduct.fp != null)
                frmProduct.photo = File.ReadAllBytes(frmProduct.fp);          
            com.Parameters.AddWithValue("@photo", frmProduct.photo);
            
            com.ExecuteNonQuery();
        }
        public void GetProduct(DataGridView datagridview)
        {
            da = new SqlDataAdapter("SELECT * FROM tblProduct INNER JOIN tblCategory ON tblProduct.cat_id=tblCategory.cid WHERE tblProduct.status='active'", ConnectDatabase.con);
            dt = new DataTable();
            da.Fill(dt);
            datagridview.DataSource = dt;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)datagridview.Columns["image"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            datagridview.Columns["id"].Visible = false;
            datagridview.Columns["cid"].Visible = false;
            datagridview.Columns["status"].Visible = false;
            datagridview.Columns["cat_id"].Visible = false;
            datagridview.Columns[1].HeaderCell.Value = "Code";
            datagridview.Columns[2].HeaderCell.Value = "Name";
            datagridview.Columns[3].HeaderCell.Value = "Price";
            datagridview.Columns[4].HeaderCell.Value = "Quantity";
            datagridview.Columns[5].HeaderCell.Value = "Image";
            datagridview.ClearSelection();
            
            
        }


        public void SearchPro(DataGridView datagridview,string name)
        {
            com = new SqlCommand("searchPro", ConnectDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", name);
            da = new SqlDataAdapter();
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);
            datagridview.DataSource = dt;
            datagridview.Columns["id"].Visible = false;
            datagridview.Columns["cid"].Visible = false;
            datagridview.Columns["status"].Visible = false;
            datagridview.Columns["cat_id"].Visible = false;
            datagridview.Columns[1].HeaderCell.Value = "Code";
            datagridview.Columns[2].HeaderCell.Value = "Name";
            datagridview.Columns[3].HeaderCell.Value = "Price";
            datagridview.Columns[4].HeaderCell.Value = "Quantity";
            datagridview.Columns[5].HeaderCell.Value = "Image";
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)datagridview.Columns["image"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
    }
   
}
