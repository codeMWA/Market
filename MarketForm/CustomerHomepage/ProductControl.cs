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

namespace MarketForm.CustomerHomepage
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }
        AccesLinq.DataClasses1DataContext lnq = new AccesLinq.DataClasses1DataContext();
        private void ProductControl_Load(object sender, EventArgs e)
        {
            var productAcc = from pp in lnq.products
                             select pp;
            foreach (var v in productAcc)
                gunaComboBox1.Items.Add(v.account_type);
        }
        private void FillDgv()
        {
            var productsA = from pp in lnq.accounts_products
                            where pp.account_type == gunaComboBox1.Text
                            select new
                            {
                                ID = pp.id_account,
                                accType = pp.account_type,
                                prx = pp.price,
                                debut = pp.account_duration,
                            };
            dgv1.Rows.Clear();
            foreach (var v in productsA)
                dgv1.Rows.Add(v.ID, v.accType, v.prx, v.debut);
        }
        private string User()
        {
            string userSS = "";
            var productsC = from pp in lnq.accounts_products
                            where pp.account_type == gunaComboBox1.Text
                            select pp;
            foreach (var v in productsC)
                userSS = v.userS;
            return userSS;
        }
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            FillDgv();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy the account","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(DialogResult.Yes == dialogResult)
            {
                if (e.ColumnIndex == 4)
                {
                    string userSS = User();
                    AccesLinq.orders orde = new AccesLinq.orders();
                    var productsB = from pp in lnq.accounts_products
                                    select pp;
                    dgv2.Rows.Clear();
                    foreach (var v in productsB)
                    {
                        if (v.id_account == int.Parse(dgv1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                        {
                            dgv2.Rows.Add(v.id_account, v.account_type, v.email, v.passwordA);
                            orde.userC = Class1.User;
                            orde.userS = userSS;
                            orde.id_account = v.id_account;
                            lnq.orders.InsertOnSubmit(orde);
                            lnq.SubmitChanges();
                            FillDgv();
                            break;

                        }
                    }
                }
            }
           
        }
    }
}
