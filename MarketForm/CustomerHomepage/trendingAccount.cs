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
using MarketClass;

namespace MarketForm.CustomerHomepage
{
    public partial class trendingAccount : UserControl
    {
        public trendingAccount()
        {
            InitializeComponent();
        }

        private void trendingAccount_Load(object sender, EventArgs e)
        {
            Deconnection.adapt = new SqlDataAdapter("select top(3) products.account_type, count(orders.id_account) from products join accounts_products "+
            "on products.account_type = accounts_products.account_type "+
            "join orders on accounts_products.id_account = orders.id_account "+
            "group by products.account_type order by count(orders.id_account) desc",Deconnection.cn);
            Deconnection.adapt.Fill(Deconnection.dss,"acc");
            dgv1.Rows.Clear();
            for(int i =0;i<Deconnection.dss.Tables["acc"].Rows.Count;i++)
            {
                dgv1.Rows.Add(Deconnection.dss.Tables["acc"].Rows[i][0], Deconnection.dss.Tables["acc"].Rows[i][1]);
            }
        }
    }
}
