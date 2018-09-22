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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
            ConnectDatabase.Myconnection();
        }
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        Category cat = new Category();
        private void btnadd_Click(object sender, EventArgs e)
        {
            cat.Type = txttype.Text;
            Category.AddCat(cat.Type);
            
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

            Category.GetCat(listCat);
            Category.GetCatByid(txtid);
        }

        private void txtsearch_KeyUp(object sender, KeyEventArgs e)
        {
            string name = txtsearch.Text;
            Category.SearchCat(listCat, name);
            
        }

        private void listCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCat.SelectedItems.Count > 0)
            {
                ListViewItem item;
                item = listCat.SelectedItems[0];
                txtid.Text = item.SubItems[0].Text;
                txttype.Text = item.SubItems[1].Text;
            }
        }
    }
}
