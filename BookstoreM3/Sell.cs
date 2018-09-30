using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookstoreM3
{
    class Sell
    {
        static SqlCommand com;
        static SqlDataAdapter da;
        static DataTable dt;
        public static byte[] photo;
        public static int qty;



        public static void GetProbyProName(TextBox txtproid,TextBox txtprice,ComboBox cboproname,ComboBox cbocategory)
        {
            txtproid.Text = cboproname.SelectedValue.ToString();
            com = new SqlCommand("SELECT cat_id,price,image,quantity FROM tblProduct WHERE code='" + txtproid.Text + "' AND status='active'", ConnectDatabase.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbocategory.SelectedValue = int.Parse(dr[0].ToString());
                txtprice.Text = string.Format("{0:c}",dr[1]);
                photo = (byte[])dr[2];
                qty = int.Parse(dr[3].ToString());
            }
            com.Dispose();
            dr.Dispose();
        }
        public static void GetProbyId(TextBox txtproid, TextBox txtprice, ComboBox cboproname, ComboBox cbocategory)
        {
           
            com = new SqlCommand("SELECT cat_id,price,image,quantity FROM tblProduct WHERE code='" + txtproid.Text + "' AND status='active'", ConnectDatabase.con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    cbocategory.SelectedValue = int.Parse(dr[0].ToString());
                    cboproname.SelectedValue = txtproid.Text;
                    txtprice.Text = string.Format("{0:c}",dr[1]);
                    photo = (byte[])dr[2];
                    qty = int.Parse(dr[3].ToString());
                }
            }
            else
            {
                cboproname.Text = null;
                cbocategory.Text = null;
                txtprice.Text = null;
            }
            com.Dispose();
            dr.Dispose();

        }

        public static void GetPro(ComboBox cboproduct)
        {
            da = new SqlDataAdapter("SELECT * FROM tblProduct WHERE status='active'", ConnectDatabase.con);
            dt = new DataTable();
            da.Fill(dt);
            cboproduct.DataSource = null;
            cboproduct.Items.Clear();
            cboproduct.DataSource = dt;
            cboproduct.DisplayMember = "pro_name";
            cboproduct.ValueMember = "code";
            cboproduct.Text = "";

        }
        public static void GetCate(ComboBox cbocategory)
        {
            da = new SqlDataAdapter("SELECT cid,Type FROM tblCategory", ConnectDatabase.con);
            dt = new DataTable();
            da.Fill(dt);
            cbocategory.DataSource = null;
            cbocategory.Items.Clear();
            cbocategory.DataSource = dt;
            cbocategory.DisplayMember = "Type";
            cbocategory.ValueMember = "cid";
            cbocategory.Text = "";
        }
    }
}
