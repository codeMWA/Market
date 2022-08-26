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
    public partial class DelAcc : Form
    {
        public DelAcc()
        {
            InitializeComponent();
        }
         AccesLinq.DataClasses1DataContext lnq = new AccesLinq.DataClasses1DataContext();
        public void FillDGV()
        {
            var accounts = from pr in lnq.products
                           join acc in lnq.accounts_products
                           on pr.account_type equals acc.account_type
                           where acc.userS == Class1.User
                           select new
                           {
                               id = acc.id_account,
                               accType = acc.account_type,
                               email = acc.email,
                               pass = acc.passwordA,
                               duration = acc.account_duration,
                               qte = pr.quantity
                           };
            dataGridView1.Rows.Clear();
            foreach (var v in accounts)
            {
                dataGridView1.Rows.Add(v.id, v.accType, v.email, v.pass, v.duration, v.qte);
            }
        }
        private void DelAcc_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the account!","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (DialogResult.Yes == dialogResult)
            {
                if (e.ColumnIndex == 6)
                {
                    //    try
                    //    {
                    
                    AccesLinq.orders ord = new AccesLinq.orders();
                    var orderss = from or in lnq.orders
                                  select or;
                    foreach(var v in orderss)
                    {
                        if(v.id_account== int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                        {
                            ord = lnq.orders.First(a => a.id_account == int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                            lnq.orders.DeleteOnSubmit(ord);
                            lnq.SubmitChanges();
                        }
                    }
                    AccesLinq.accounts_products ac = new AccesLinq.accounts_products();
                    ac = lnq.accounts_products.First(a => a.id_account == int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        lnq.accounts_products.DeleteOnSubmit(ac);
                        lnq.SubmitChanges();
                        MessageBox.Show("account deleted!");
                        FillDGV();
                    //}
                    //catch (Exception ex) { MessageBox.Show("" + ex); }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
