using BookstoreM3.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreM3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelCtrl.Controls.Clear();
            panelCtrl.Controls.Add(c);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void MoveAsidePanel(Control btn)
        {
            panelUpdown.Top = btn.Top;
            panelUpdown.Height = btn.Height;

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnEmployee);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnProduct);
            UcProduct ucp = new UcProduct();
            panelCtrl.Controls.Add(ucp);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnInfo);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnReport);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MoveAsidePanel(btnSetting);
        }
    }
}
