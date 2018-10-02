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
    public partial class frmRptSaleReport : Form
    {
        public frmRptSaleReport()
        {
            InitializeComponent();
        }

        private void frmRptSaleReport_Load(object sender, EventArgs e)
        {

            Vspt.SetDisplayMode(DisplayMode.PrintLayout);
            Vspt.ZoomMode = ZoomMode.Percent;
            Vspt.ZoomPercent = 100;

            
        }
    }
}
