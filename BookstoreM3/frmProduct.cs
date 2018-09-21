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
using System.IO;

namespace BookstoreM3
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            ConnectDatabase.Myconnection();
        }

        SqlDataAdapter da;
        DataTable dt;
        SqlCommand com;
        Product pro = new Product();
        public static string fp;
        public static byte[] photo;
        public static int id;
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            pro.Pid = txtId.Text;
            pro.Pname = txtName.Text;
            pro.Qty = int.Parse(txtQuantity.Text);
            pro.Price = Double.Parse(txtPrice.Text);

            Product.InsertProduct(pro.Pid, pro.Pname, pro.Qty, pro.Price);
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM tblCategory", ConnectDatabase.con);
            dt = new DataTable();
            da.Fill(dt);
            cbCategory.DataSource = null;
            cbCategory.Items.Clear();
            cbCategory.DataSource = dt;
            cbCategory.DisplayMember = "Type";
            cbCategory.ValueMember = "id";

            Product.GetProduct(dataGridView1);
            dataGridView1.ClearSelection();
            
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE|*.jpeg;*.jpg|PNG FILE|*.png";
            fd.Title = "Open an Image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                pictureBox1.Image = Image.FromFile(fp);
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            pro.Pid = txtId.Text;
            SqlCommand com = new SqlCommand(@"SELECT * FROM tblProduct WHERE code = @id", ConnectDatabase.con);

            com.Parameters.AddWithValue("@id", pro.Pid);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string id = row[1].ToString();
                if (pro.pid == id)
                {
                    MessageBox.Show("Your code already exist!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                }
                
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Enabled = false;
            int i=0;
            if (dataGridView1.RowCount > 0)
                i = e.RowIndex;
            if (i < 0) return;
            DataGridViewRow row = dataGridView1.Rows[i];
            id = int.Parse(row.Cells[0].Value.ToString());
            txtId.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtQuantity.Text = row.Cells[3].Value.ToString();
            txtPrice.Text = row.Cells[4].Value.ToString();
            //read byte from datagridview

            photo = (byte[])row.Cells[5].Value;
           
            MemoryStream ms = new MemoryStream(photo);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pro.Pid = txtId.Text;
            pro.Pname = txtName.Text;
            pro.Qty = int.Parse(txtQuantity.Text);
            pro.Price = Double.Parse(txtPrice.Text);
            Product.DelProduct(pro.Pid, pro.Pname, pro.Qty, pro.Price);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            pro.Pid = txtId.Text;
            pro.Pname = txtName.Text;
            pro.Qty = int.Parse(txtQuantity.Text);
            pro.Price = Double.Parse(txtPrice.Text);
            Product.DelProduct(pro.Pid, pro.Pname, pro.Qty, pro.Price);
        }
    }
}
