using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MarketClass
{
    public class Connection
    {
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=Market;Integrated Security=True");
        public static SqlCommand com = new SqlCommand();
        public static SqlDataReader dr;

        public static void connecter()
        {
            if(cnx.State==ConnectionState.Closed)
            {
                cnx.Open();
            }
                
        }
        public static void deconnecter()
        {
            cnx.Close();
        }

        
    }
}
