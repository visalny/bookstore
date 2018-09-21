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
        public static void InsertProduct(string pid,string name,int qty,double price)
        {
            com = new SqlCommand("InsertProduct", ConnectDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@code", pid);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@qty", qty);
            com.Parameters.AddWithValue("@price", price);
            if (frmProduct.fp != null)
                frmProduct.photo = File.ReadAllBytes(frmProduct.fp);          
            com.Parameters.AddWithValue("@photo", frmProduct.photo);

            com.ExecuteNonQuery();
        }
        public static void GetProduct(DataGridView datagridview)
        {
            da = new SqlDataAdapter("SELECT * FROM tblProduct WHERE status=1", ConnectDatabase.con);
            dt = new DataTable();
            da.Fill(dt);
            datagridview.DataSource = dt;
            datagridview.Columns["id"].Visible = false;
            datagridview.Columns["status"].Visible = false;
            datagridview.Columns["cat_id"].Visible = false;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)datagridview.Columns["image"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            
        }

        public static void DelProduct(string pid, string name, int qty, double price)
        {
            com = new SqlCommand("DelProduct", ConnectDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@code", pid);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@qty", qty);
            com.Parameters.AddWithValue("@price", price);
            com.Parameters.AddWithValue("@id", frmProduct.id);
            if (frmProduct.fp != null)
                frmProduct.photo = File.ReadAllBytes(frmProduct.fp);
            com.Parameters.AddWithValue("@photo", frmProduct.photo);

            com.ExecuteNonQuery();
        }

        public static void UpdateProduct(string pid, string name, int qty, double price)
        {
            com = new SqlCommand("UpdateProduct", ConnectDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@code", pid);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@qty", qty);
            com.Parameters.AddWithValue("@price", price);
            //com.Parameters.AddWithValue("@status", 1);
            com.Parameters.AddWithValue("@id", frmProduct.id);
            if (frmProduct.fp != null)
                frmProduct.photo = File.ReadAllBytes(frmProduct.fp);
            com.Parameters.AddWithValue("@photo", frmProduct.photo);

            com.ExecuteNonQuery();
        }
    }
   
}
