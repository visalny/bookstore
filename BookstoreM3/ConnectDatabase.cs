﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BookstoreM3
{
    
    class ConnectDatabase
    {
        public static SqlConnection con;
        public static string empID;
        public static string empName;
        public static int status;
        public static void Myconnection()
        {
            string str = "";
            str = "Data Source=DESKTOP-40EVD05; Initial Catalog=BookStore;Integrated security=true";
            try
            {
                con = new SqlConnection(str);
                con.Open();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void OnoffControls(Form frm,Boolean b)
        {
            foreach(Control ct in frm.Controls)
            {
                if (!(ct is Label))
                    if (ct.Tag == null)
                        ct.Enabled = b;
            }
        }
   /*     internal static void OnoffControls(User_Control.UcEmployee ucEmployee, bool v)
        {
           
        }
        internal static void ClearData(User_Control.UcEmployee ucEmployee)
        {
           
        }*/

        public static void ClearData( Form frm)
        {
            foreach(Control ct in frm.Controls)
            {
                if (ct is TextBox || ct is MaskedTextBox || ct is ComboBox)
                    if(ct.Tag==null)
                        ct.Text = "";
                else if (ct is RadioButton)
                    ((RadioButton)ct).Checked = false;
                else if (ct is DateTimePicker)
                    if (ct.Tag == null)
                        ((DateTimePicker)ct).CustomFormat = "";
                    else if (ct is PictureBox)
                        ((PictureBox)ct).Image = null;
            }
        }
    }
}
