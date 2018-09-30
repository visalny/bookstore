using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;


namespace BookstoreM3
{
    class Category
    {
        private int id;
        private string type;
        static SqlCommand com;
        static SqlDataAdapter da;
        static DataTable dt;

        public Category() { }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        public static void AddCat(string name)
        {
            com = new SqlCommand("InsertCat", ConnectDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", name);
            com.ExecuteNonQuery();
        }

        public static void GetCat(ListView listcat)
        {
            da = new SqlDataAdapter("SELECT * FROM tblCategory", ConnectDatabase.con);
            dt = new DataTable();
            da.Fill(dt);
            listcat.View = View.Details;
            listcat.Clear();
            listcat.Columns.Add("ID", 90);
            listcat.Columns.Add("Type", 106);
            //load data on listview
            string[] arr = new string[2];
            ListViewItem item;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                arr[0] = dr[0].ToString();
                arr[1] = dr[1].ToString();
                item = new ListViewItem(arr);
                listcat.Items.Add(item);
            }
            foreach (ListViewItem list in listcat.Items)
            {
                if ((list.Index % 2) == 0)
                    list.BackColor = Color.White;
                else
                    list.BackColor = Color.LightBlue;
            }
            da.Dispose();
            dt.Dispose();
            
        }
        public static void GetCatByid(TextBox name)
        {
            da = new SqlDataAdapter("SELECT MAX(cid) FROM tblCategory", ConnectDatabase.con);
            dt = new DataTable();
            da.Fill(dt);
            
            string[] arr = new string[1];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
               
                DataRow dr = dt.Rows[i];
                arr[0] = dr[0].ToString();
                int id = Int32.Parse(arr[0]);
                name.Text = (id + 1).ToString();
                
            }
            da.Dispose();
            dt.Dispose();
        }
        public static void SearchCat(ListView listcat,string name)
        {
            com = new SqlCommand("searchCat", ConnectDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@n", name);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = com;
            da.Fill(dt);
            listcat.Clear();
            listcat.View = View.Details;
            listcat.Columns.Add("ID", 90);
            listcat.Columns.Add("Type", 106);
            string[] arr = new string[2];
            ListViewItem item;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                arr[0] = dr[0].ToString();
                arr[1] = dr[1].ToString();
                item = new ListViewItem(arr);
                listcat.Items.Add(item);
            }
            foreach (ListViewItem list in listcat.Items)
            {
                if ((list.Index % 2) == 0)
                    list.BackColor = Color.White;
                else
                    list.BackColor = Color.LightBlue;
            }
            da.Dispose();
            dt.Dispose();
        }
         public static void UpdateCategory(int id,string type)
        {
            com = new SqlCommand("UpdateCategory",ConnectDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@cid", id);
            com.Parameters.AddWithValue("@Type", type);
            com.ExecuteNonQuery();

        }

        
    }
}
