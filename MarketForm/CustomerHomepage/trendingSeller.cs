using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketClass;
using System.Data.SqlClient;


namespace MarketForm.CustomerHomepage
{
    public partial class trendingSeller : UserControl
    {
        public trendingSeller()
        {
            InitializeComponent();
        }

        private void trendingSeller_Load(object sender, EventArgs e)
        {
            Deconnection.adapt = new SqlDataAdapter("select top(3) userS,count(userC) from orders group by userS order by count(userC) desc", Deconnection.cn);
            Deconnection.adapt.Fill(Deconnection.dss,"users");
            dgv1.Rows.Clear();
            for(int i=0;i<Deconnection.dss.Tables["users"].Rows.Count;i++)
            {
                dgv1.Rows.Add(Deconnection.dss.Tables["users"].Rows[i][0], Deconnection.dss.Tables["users"].Rows[i][1]);
            }
        }

        private void groupBoxSeller_Enter(object sender, EventArgs e)
        {

        }
    }
}
