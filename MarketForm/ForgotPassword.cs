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

namespace MarketForm
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        int i = 0;
        AccesLinq.DataClasses1DataContext lnq = new AccesLinq.DataClasses1DataContext();
        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void tpDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("customer");
            comboBox1.Items.Add("seller");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "customer")
            {
                var customers = from cus in lnq.customer
                                select new
                                {
                                    name = cus.nameC,
                                    city = cus.CityC,
                                    Phone = cus.phoneC
                                };
                foreach (var v in customers)
                {
                    if (tpName.Text == v.name && tpCity.Text == v.city && tpPhone.Text == v.Phone)
                    {
                        Password.name = tpName.Text;
                        Password.City = tpCity.Text;
                        Password.phone = tpPhone.Text;
                        Password.userType = comboBox1.Text;
                        i++;
                        this.Hide();
                        new NewPassword().Show();
                    }
                    //else
                    //{
                    //    MessageBox.Show("Your informations are incorrect, Try again");
                    //    tpName.Clear();
                    //    tpCity.Clear();
                    //    tpPhone.Clear();
                    //}
                }
                if (i == 0)
                {
                    MessageBox.Show("Your informations are incorrect, Try again");
                    tpName.Clear();
                    tpCity.Clear();
                    tpPhone.Clear();
                }
            }
            else if (comboBox1.Text == "seller")
            {
                var sellers = from cus in lnq.seller
                              select new
                              {
                                  name = cus.nameS,
                                  city = cus.CityS,
                                  Phone = cus.phoneS
                              };
                foreach (var v in sellers)
                {
                    if (tpName.Text == v.name && tpCity.Text == v.city && tpPhone.Text == v.Phone)
                    {
                        Password.name = tpName.Text;
                        Password.City = tpCity.Text;
                        Password.phone = tpPhone.Text;
                        Password.userType = comboBox1.Text;
                        this.Hide();
                        new NewPassword().Show();
                    }
                    //else
                    //{
                    //    MessageBox.Show("Your informations are incorrect, Try again");
                    //    tpName.Clear();
                    //    tpCity.Clear();
                    //    tpPhone.Clear();
                    //}
                }
                if (i == 0)
                {
                    MessageBox.Show("Your informations are incorrect, Try again");
                    tpName.Clear();
                    tpCity.Clear();
                    tpPhone.Clear();
                }
            }
            else
                MessageBox.Show("choose customer/seller");
        }
    }
}
