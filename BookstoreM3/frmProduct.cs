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
using System.Globalization;

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
        public static int cat_id;
        Boolean b;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Invalid product ID!");
                txtId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Invalid product Name!");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Invalid product price!");
                txtPrice.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Invalid product Quantity!");
                txtQuantity.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbCategory.Text) || string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                MessageBox.Show("Invalid product category!");
                cbCategory.DroppedDown=true;
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please choose product image!");
                return;
            }
            if (b == true)
            {
                getData();
                Product.Modify("InsertProduct", pro.Pid, pro.Pname, pro.Qty, pro.Price, cat_id);
                MessageBox.Show("Your record was Inserted!");
                Product.GetProduct(dgvProduct);
                ConnectDatabase.ClearData(this);
                ConnectDatabase.OnoffControls(this, false);
                btnNew.Text = "New";
                txtId.Text = "";
                pictureBox1.Image = null;
            }
            else
            {
                getData();
                Product.Modify("UpdateProduct", pro.Pid, pro.Pname, pro.Qty, pro.Price, cat_id);
                MessageBox.Show("Your record was updated!");
                Product.GetProduct(dgvProduct);
                ConnectDatabase.ClearData(this);
                ConnectDatabase.OnoffControls(this, false);
                btnNew.Text = "New";
                txtId.Text = "";
                pictureBox1.Image = null;
            }
           
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
            cbCategory.ValueMember = "cid";
            
            Product.GetProduct(dgvProduct);

            //clear combobox selected item
            cbCategory.Text = "";
            txtsearch.Text = "Searching ...";
            txtsearch.ForeColor = Color.Gray;
            ConnectDatabase.OnoffControls(this, false);
            txtId.Enabled = false;
            

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
            if (dgvProduct.RowCount > 0)
                i = e.RowIndex;
            if (i < 0) return;
            DataGridViewRow row = dgvProduct.Rows[i];
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
            DialogResult re;
            re = MessageBox.Show("Do you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                getData();
                Product.Modify("DelProduct", pro.Pid, pro.Pname, pro.Qty, pro.Price, cat_id);
                MessageBox.Show("Your record was deleted!");
                Product.GetProduct(dgvProduct);
                ConnectDatabase.ClearData(this);
                pictureBox1.Image = null;
                txtId.Text = "";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            getData();
            Product.Modify("UpdateProduct", pro.Pid, pro.Pname, pro.Qty, pro.Price,cat_id);
            Product.GetProduct(dgvProduct);
        }

        private void getData()
        {
            pro.Pid = txtId.Text;
            pro.Pname = txtName.Text;
            pro.Qty = int.Parse(txtQuantity.Text);
            pro.Price = Double.Parse(txtPrice.Text,NumberStyles.Currency);
        }

        private void txtsearch_KeyUp(object sender, KeyEventArgs e)
        {
            string name = txtsearch.Text;
            Product.SearchPro(dgvProduct, name);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                b = true;
                btnNew.Text = "Cancel";
                ConnectDatabase.ClearData(this);
                ConnectDatabase.OnoffControls(this, true);
                txtId.Enabled = true;
                txtId.Focus();
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                txtId.Text = "";
                pictureBox1.Image = null;

            }
            else
            {
                DialogResult re;
                re = MessageBox.Show("Do you want to Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    btnNew.Text = "New";
                    ConnectDatabase.ClearData(this);
                    ConnectDatabase.OnoffControls(this, false);
                    pictureBox1.Image = null;
                    txtId.Text = "";
                    txtId.Enabled = false;
                }

            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void txtsearch_Leave_1(object sender, EventArgs e)
        {
            txtsearch.Text = "Searching ...";
            txtsearch.ForeColor = Color.Gray;
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void dgvProduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtId.Enabled = false;
            int i = 0;
            if (dgvProduct.RowCount > 0)
                i = e.RowIndex;
            if (i < 0) return;
            DataGridViewRow row = dgvProduct.Rows[i];
            id = int.Parse(row.Cells[0].Value.ToString());
            txtId.Text = row.Cells[1].Value.ToString();
            txtName.Text = row.Cells[2].Value.ToString();
            txtQuantity.Text = row.Cells[4].Value.ToString();
            txtPrice.Text = string.Format("{0:c}", row.Cells[3].Value);
            int catid = int.Parse(row.Cells[6].Value.ToString());
            //read byte from datagridview

            photo = (byte[])row.Cells[5].Value;
            //MessageBox.Show(photo.ToString());

            MemoryStream ms = new MemoryStream(photo);
            pictureBox1.Image = Image.FromStream(ms);
            //MessageBox.Show(ms.ToString());
            com = new SqlCommand("SELECT cid FROM tblCategory WHERE cid=" + catid, ConnectDatabase.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cbCategory.SelectedValue = int.Parse(dr[0].ToString());
            }
            com.Dispose();
            dr.Dispose();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            b = false;
            ConnectDatabase.OnoffControls(this, true);
            txtId.Enabled = false;
            txtName.Focus();
            btnNew.Text = "Cancel";
            cbCategory.DroppedDown = true;
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                txtPrice.Text = null;
            }
            else
            {
                txtPrice.Text = string.Format("{0:C}", decimal.Parse(txtPrice.Text));

            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                txtPrice.Text = null;
            }
            else
            {
                var value = Decimal.Parse(txtPrice.Text, NumberStyles.Currency);
                txtPrice.Text = value.ToString();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                    e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //only allow on decimal point
            if((e.KeyChar=='.')&&((sender as TextBox).Text.IndexOf('.') > -1)){
                e.Handled = true;
            }
        }

        

        private void cbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cat_id = int.Parse(cbCategory.SelectedValue.ToString());
        }
    }
}
