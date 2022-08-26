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

namespace MarketForm.sellerHomepage
{
    public partial class SellerCust : Form
    {
        public SellerCust()
        {
            InitializeComponent();
        }

        private void SellerCust_Load(object sender, EventArgs e)
        {
            SellerDataSet ds = new SellerDataSet();
            SellerDataSetTableAdapters.sellerCustTableAdapter adapt = new SellerDataSetTableAdapters.sellerCustTableAdapter();
            adapt.FillBySellCust(ds.sellerCust,Class1.User);
            CrystalSeller_cust.CrystalReport1 rapport = new CrystalSeller_cust.CrystalReport1();
            rapport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rapport;

        }
    }
}
