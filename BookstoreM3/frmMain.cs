
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookstoreM3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, picuser.Width, picuser.Height);
            picuser.Region = new Region(path);
            lblDate.Text = DateTime.Now.ToString("ddd-MMM-yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();

            lblusername.Text = ConnectDatabase.empName;
            MemoryStream ms = new MemoryStream(Form1.imag);
            picuser.Image = Image.FromStream(ms);
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Do you want to close program?", "Close program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
                Application.Exit();
            
        }
        private void MoveAsidePanel(Control btn)
        {
            panelUpdown.Top = btn.Top;
            panelUpdown.Height = btn.Height;

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnEmployee);
            panelCrtl.Controls.Clear();
            frmEmployee frm = new frmEmployee();
            frm.TopLevel = false;
            panelCrtl.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnProduct);
            panelCrtl.Controls.Clear();
            frmProduct frm = new frmProduct();
            frm.TopLevel = false;
            panelCrtl.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnInfo);
            panelCrtl.Controls.Clear();
            frmSale frm = new frmSale();
            frm.TopLevel = false;
            panelCrtl.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnReport);
            panelCrtl.Controls.Clear();
            frmSaleReport frm = new frmSaleReport();
            frm.TopLevel = false;
            panelCrtl.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

       

        private void panelCtrl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnReport);
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnReport);
            panelCrtl.Controls.Clear();
            frmCategory frm = new frmCategory();
            frm.TopLevel = false;
            panelCrtl.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            //frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!(ConnectDatabase.empID.Equals("1")&&ConnectDatabase.empName.Equals("admin")))
            {
                btnEmployee.Enabled = false;
                btnProduct.Enabled = false;
                btnCategory.Enabled = false;
                btnReport.Enabled = false;
            }
        }
    }
}
