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
    public partial class Acces : Form
    {
        public Acces()
        {
            InitializeComponent();
        }
        int i = 0;
        AccesLinq.DataClasses1DataContext lnq = new AccesLinq.DataClasses1DataContext();
      

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ForgotPassword().Show();
        }

        private void tpUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Acces_Load(object sender, EventArgs e)
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
                                    user = cus.userC,
                                    password = cus.passwordC
                                };
                foreach (var v in customers)
                {
                    if (tpUser.Text == v.user && tpPassword.Text == v.password)
                    {
                        Class1.User = tpUser.Text;
                        new CustomerHomepage.Homepage().Show();
                        this.Hide();
                        i++;
                    }
                    //else
                    //{
                    //    MessageBox.Show("Your user or password are incorrect! Try again");
                    //    tpUser.Clear();
                    //    tpPassword.Clear();
                    //}
                };
                if (i == 0)
                {
                    MessageBox.Show("Your user or password are incorrect! Try again");
                    tpUser.Clear();
                    tpPassword.Clear();
                }


            }
            else if (comboBox1.Text == "seller")
            {
                var sellers = from cus in lnq.seller
                              select new
                              {
                                  user = cus.userS,
                                  password = cus.passwordS
                              };
                foreach (var v in sellers)
                {
                    if (tpUser.Text == v.user && tpPassword.Text == v.password)
                    {
                        Class1.User = tpUser.Text;
                        new sellerHomepage.Homepage().Show();
                        this.Hide();
                        i += 1;
                    }
                    //else
                    //{
                    //    MessageBox.Show("Your user or password are incorrect! Try again");
                    //    tpUser.Clear();
                    //    tpPassword.Clear();
                    //}
                };
                if (i == 0)
                {
                    MessageBox.Show("Your user or password are incorrect! Try again");
                    tpUser.Clear();
                    tpPassword.Clear();
                }

            }
            else
                MessageBox.Show("choose customer/seller");
        }
    }
}
