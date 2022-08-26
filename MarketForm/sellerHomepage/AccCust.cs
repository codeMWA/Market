using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketForm.sellerHomepage
{
    public partial class AccCust : Form
    {
        public AccCust()
        {
            InitializeComponent();
        }

        private void AccCust_Load(object sender, EventArgs e)
        {
            SellerDataSet ds = new SellerDataSet();
            SellerDataSetTableAdapters.AccountCustTableAdapter adapt = new SellerDataSetTableAdapters.AccountCustTableAdapter();
            adapt.FillByAccCust(ds.AccountCust);
            CrystalSeller_cust.CrystalReport2 rapport = new CrystalSeller_cust.CrystalReport2();
            rapport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rapport;
        }
    }
}
