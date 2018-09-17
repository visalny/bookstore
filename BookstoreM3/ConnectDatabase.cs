using System;
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
        public static int status;
        public static void Myconnection()
        {
            string str = "";
            str = "Data Source=DESKTOP-40EVD05; Initial Catalog=BookStore;Integrated security=true";
            try
            {
                con = new SqlConnection(str);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
