using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace BookstoreM3
{
    class Employee
    {

        private string eid;
        private string ename;
        private string gender;
        private DateTime date;
        private string username;
        private string password;
        static SqlDataAdapter da;
        static SqlCommand com;
        static DataTable dt;

        public string Eid
        {
            get
            {
                return eid;
            }

            set
            {
                eid = value;
            }
        }

        public string Ename
        {
            get
            {
                return ename;
            }

            set
            {
                ename = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public Employee() { }

        public static void GetEmp(DataGridView datagridview)
        {
            da = new SqlDataAdapter("SELECT * FROM tblEmployee WHERE status=1", ConnectDatabase.con);
            dt = new DataTable();
            da.Fill(dt);
            datagridview.DataSource = dt;
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)datagridview.Columns["image"];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            datagridview.Columns["id"].Visible = false;
            datagridview.Columns["status"].Visible = false;
            datagridview.ClearSelection();
        }

        public static void GetEmpID(string eid, TextBox txtid)
        {
            SqlCommand com = new SqlCommand(@"SELECT emp_ID FROM tblEmployee WHERE emp_ID = @id", ConnectDatabase.con);
            com.Parameters.AddWithValue("@id", eid);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string id = row["emp_ID"].ToString();
                if (eid == id)
                {
                    MessageBox.Show("Your ID already exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtid.Focus();
                }


            }
        }

        public static void Modify(string procedure, string id, string name, string gender, DateTime date, string uname, string uid)
        {
            com = new SqlCommand(procedure, ConnectDatabase.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@gender", gender);
            com.Parameters.AddWithValue("@dob", date);
            if (frmEmployee.fp != null)
                frmEmployee.photo = File.ReadAllBytes(frmEmployee.fp);
            com.Parameters.AddWithValue("@image", frmEmployee.photo);

            com.Parameters.AddWithValue("@uname", uname);
            com.Parameters.AddWithValue("@uid", uid);
            com.ExecuteNonQuery();
        }

    }
}
