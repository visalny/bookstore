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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
            ConnectDatabase.Myconnection();
            
        }
        public static string fp;
        public static byte[] photo;
        Employee emp = new Employee();
        Boolean b;

        private void getData()
        {
            emp.Eid = txtid.Text;
            emp.Ename = txtname.Text;
            if (rdMale.Checked == true)
                emp.Gender = "Male";
            else
                emp.Gender = "Female";
            emp.Date = dtpdob.Value;
            emp.Username = txtusername.Text;
            emp.Password = txtpassword.Text;
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            string eid = txtid.Text;
            Employee.GetEmpID(eid, txtid);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE|*.jpeg;*.jpg|PNG FILE|*.png";
            fd.Title = "Open an Image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picEmp.Image = Image.FromFile(fp);
            }
        }

        private void picEmp_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "JPEG FILE|*.jpeg;*.jpg|PNG FILE|*.png|*.gif";
            fd.Title = "Open an Image";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fp = fd.FileName;
                picEmp.Image = Image.FromFile(fp);
            }
        }

        private void frmEmployee_Load_1(object sender, EventArgs e)
        {
            Employee.GetEmp(dgvEmp);
            ConnectDatabase.OnoffControls(this, false);
            txtid.Enabled = false;
            textBox1.Text = "Searching ...";
            textBox1.ForeColor = Color.Gray;

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Employee.SearchEmp(textBox1.Text, dgvEmp);
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            if (dgvEmp.RowCount > 0)
                i = e.RowIndex;
            if (i < 0) return;
            DataGridViewRow row = dgvEmp.Rows[i];

            txtid.Text = row.Cells[1].Value.ToString();
            txtname.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.Equals("Male"))
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;
            dtpdob.Text = row.Cells[4].Value.ToString();
            txtusername.Text = row.Cells[6].Value.ToString();
            txtpassword.Text = row.Cells[7].Value.ToString();


            //read byte from datagridview

            photo = (byte[])row.Cells[5].Value;

            MemoryStream ms = new MemoryStream(photo);
            picEmp.Image = Image.FromStream(ms);
            ConnectDatabase.OnoffControls(this, false);
            ConnectDatabase.ClearData(this);
            txtid.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "Searching ...";
            textBox1.ForeColor = Color.Gray;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            DialogResult re;
            re = MessageBox.Show("Do you want to Close?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                getData();
                Employee.Modify("DeleteEmp",emp.Eid,emp.Ename,emp.Gender,emp.Date,emp.Username,emp.Password);
                Employee.GetEmp(dgvEmp);
                ConnectDatabase.ClearData(this);
                ConnectDatabase.OnoffControls(this, false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            b = false;
            ConnectDatabase.ClearData(this);
            ConnectDatabase.OnoffControls(this, true);
            txtid.Enabled = false;
            txtname.Focus();
            btnnew.Text = "Cancel";

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (btnnew.Text == "  New")
            {
                b = true;
                btnnew.Text = "   Cancel";
                btnnew.Image = BookstoreM3.Properties.Resources.cancel_32px;
                ConnectDatabase.ClearData(this);
                ConnectDatabase.OnoffControls(this, true);
                txtid.Enabled = true;
                txtid.Focus();
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                
            }
            else
            {
                DialogResult re;
                re = MessageBox.Show("Do you want to Cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    btnnew.Text = "  New";
                    btnnew.Image = BookstoreM3.Properties.Resources.new_32px;
                    ConnectDatabase.ClearData(this);
                    ConnectDatabase.OnoffControls(this, false);
                    picEmp.Image = null;
                    txtid.Text = "";
                }
                
            }
        }

        private void txtid_Leave_1(object sender, EventArgs e)
        {
            Employee.GetEmpID(txtid.Text, txtid);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text) || string.IsNullOrWhiteSpace(txtid.Text))
            {
                MessageBox.Show("Invalid ID!");
                txtid.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtname.Text) || string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Invalid Name!");
                txtname.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrWhiteSpace(txtusername.Text))
            {
                MessageBox.Show("Invalid Username!");
                txtusername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Invalid Password!");
                txtpassword.Focus();
                return;
            }
            if (picEmp.Image == null)
            {
                MessageBox.Show("Please choose image!");
                return;
            }
            if (b == true)
            {
                getData();
                Employee.Modify("InsertEmp", emp.Eid, emp.Ename, emp.Gender, emp.Date, emp.Username, emp.Password);
                MessageBox.Show("Your record was Inserted!");
                Employee.GetEmp(dgvEmp);
                txtid.Text = "";
                btnnew.Text = "New";
                rdMale.Checked = true;
                txtid.Enabled = false;
                ConnectDatabase.ClearData(this);
                ConnectDatabase.OnoffControls(this, false);
                picEmp.Image = null;
                
            }
            else
            {
                getData();
                Employee.Modify("UpdateEmp", emp.Eid, emp.Ename, emp.Gender, emp.Date, emp.Username, emp.Password);
                MessageBox.Show("Your record was updated!");
                Employee.GetEmp(dgvEmp);
                txtid.Text = "";
                btnnew.Text = "New";
                rdMale.Checked = true;
                txtid.Enabled = false;
                ConnectDatabase.ClearData(this);
                ConnectDatabase.OnoffControls(this, false);
                picEmp.Image = null;
            }
        }
    }
}
