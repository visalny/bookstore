using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace BookstoreM3
{
    public partial class frmRptInvoice : Form
    {
        public frmRptInvoice()
        {
            InitializeComponent();
        }

        private void frmRptInvoice_Load(object sender, EventArgs e)
        {

            Vinv.SetDisplayMode(DisplayMode.PrintLayout);
            Vinv.ZoomMode = ZoomMode.Percent;
            Vinv.ZoomPercent = 100;
        }
    }
}
