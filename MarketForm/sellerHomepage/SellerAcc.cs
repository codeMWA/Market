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
    public partial class SellerAcc : Form
    {
        public SellerAcc()
        {
            InitializeComponent();
        }

        private void SellerAcc_Load(object sender, EventArgs e)
        {
            SellerDataSet ds = new SellerDataSet();
            SellerDataSetTableAdapters.sellerAccTableAdapter adapt = new SellerDataSetTableAdapters.sellerAccTableAdapter();
            adapt.FillBySellAcc(ds.sellerAcc,Class1.User);
            CrystalSeller_cust.CrystalReport3 rapport = new CrystalSeller_cust.CrystalReport3();
            rapport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rapport;
        }
    }
}
