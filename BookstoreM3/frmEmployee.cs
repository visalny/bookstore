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
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            Employee.GetEmp(dgvEmp);
        }

        private void picEmp_Click(object sender, EventArgs e)
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            getData();
            Employee.Modify("InsertEmp", emp.Eid, emp.Ename, emp.Gender, emp.Date, emp.Username, emp.Password);
            MessageBox.Show("Your recored was inserted!");
            Employee.GetEmp(dgvEmp);
        }

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

        private void btndelete_Click(object sender, EventArgs e)
        {
            getData();
            Employee.Modify("DeleteEmp", emp.Eid, emp.Ename, emp.Gender, emp.Date, emp.Username, emp.Password);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            getData();
            Employee.Modify("UpdateEmp", emp.Eid, emp.Ename, emp.Gender, emp.Date, emp.Username, emp.Password);
            MessageBox.Show("Your recored was updated!");
            Employee.GetEmp(dgvEmp);
        }

        private void dgvEmp_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
        }
    }
}
