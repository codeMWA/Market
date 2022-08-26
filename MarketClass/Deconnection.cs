using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MarketClass
{
    public class Deconnection
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-QV3FUH3\SQLEXPRESS;Initial Catalog=Market;Integrated Security=True");
        public static SqlDataAdapter adapt = new SqlDataAdapter();
        public static SqlCommandBuilder com = new SqlCommandBuilder();
        public static DataSet dss = new DataSet();

        

    }
}
