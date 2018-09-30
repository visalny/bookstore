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
        Boolean b;
        Category cat = new Category();

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                cat.Type = txttype.Text;
                Category.AddCat(cat.Type);
                MessageBox.Show("You record was Inserted!");
                Category.GetCatByid(txtid);
                Category.GetCat(listCat);
                
                txttype.Text = "";
                ConnectDatabase.OnoffControls(this, false);
                btnnew.Text = "New";
            }
            else
            {
                cat.Type = txttype.Text;
                cat.Id = int.Parse(txtid.Text);
                Category.UpdateCategory(cat.Id, cat.Type);
                MessageBox.Show("Your record was updated!");
                Category.GetCat(listCat);
                txttype.Text = "";
                ConnectDatabase.OnoffControls(this, false);
                btnnew.Text = "New";
                
            }
            
            
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

            Category.GetCat(listCat);
            Category.GetCatByid(txtid);
            txtsearch.Text = "Searching ...";
            txtsearch.ForeColor = Color.Gray;
            ConnectDatabase.OnoffControls(this, false);
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
            btnEdit.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {   
            cat.Type = txttype.Text;
            cat.Id = int.Parse(txtid.Text);
            Category.UpdateCategory(cat.Id,cat.Type);
           
        }

        private void txtsearch_Leave(object sender, EventArgs e)
        {
            txtsearch.Text = "Searching ...";
            txtsearch.ForeColor = Color.Gray;
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            if (btnnew.Text == "  New")
            {
                b = true;
                txttype.Enabled = true;
                txttype.Focus();
                btnnew.Text = "    Cancel";
                btnnew.Image = BookstoreM3.Properties.Resources.cancel_32px;
                btnadd.Enabled = true;
                Category.GetCatByid(txtid);
                txttype.Text = "";
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
                    txttype.Text = "";
                    btnEdit.Enabled = false;
                    Category.GetCatByid(txtid);
                    ConnectDatabase.OnoffControls(this, false);
                }
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            b = false;
            ConnectDatabase.OnoffControls(this, true);
            txttype.Focus();
            txtid.Enabled = false;
            btnnew.Text = "Cancel";
        }
    }
}
