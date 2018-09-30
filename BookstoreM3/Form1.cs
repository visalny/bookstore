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

namespace BookstoreM3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static byte[] imag;

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectDatabase.Myconnection();

        }
        int count = 0;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrWhiteSpace(txtusername.Text))
            {
                MessageBox.Show("Invalid username!");
                txtusername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Invalid password!");
                txtpassword.Focus();
                return;
            }
            string un = txtusername.Text.Trim();
            string pw = txtpassword.Text.Trim();
            SqlCommand com = new SqlCommand(@"SELECT * FROM tblEmployee WHERE username = @uid AND password = @pwd", ConnectDatabase.con);
            
            com.Parameters.AddWithValue("@uid", un);
            com.Parameters.AddWithValue("@pwd", pw);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                ConnectDatabase.empID = row[1].ToString();
                ConnectDatabase.status = int.Parse(row[7].ToString());
                ConnectDatabase.empName = row[2].ToString();
                imag = (byte[])row[5];
                if (ConnectDatabase.empID == "1")
                {
                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Your username or password incorrect...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Text = "";
                txtpassword.Text = "";
                txtusername.Focus();
                count++;
            }
            if (count == 3)
            {
                MessageBox.Show("Your login timeout");
                Application.Exit();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
