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

namespace MarketForm.signUp
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }
        static string searchCustomer(string user)
        {
            string us = "";
            Connection.connecter();
            Connection.com.Connection = Connection.cnx;
            Connection.com.CommandText = "select * from customer";
            Connection.dr = Connection.com.ExecuteReader();
            while (Connection.dr.Read())
            {
                if (Connection.dr[0].ToString() == user)
                {
                    MessageBox.Show("user used");
                }
                else
                {
                    us = user;
                } 

            }
            Connection.dr.Close();
            return us;

        }
        static string searchSellerr(string user)
        {
            string us = "";
            Connection.connecter();
            Connection.com.Connection = Connection.cnx;
            Connection.com.CommandText = "select * from seller";
            Connection.dr = Connection.com.ExecuteReader();
            while (Connection.dr.Read())
            {
                if (Connection.dr[0].ToString() == user)
                {
                    MessageBox.Show("user used");
                }
                else
                {
                    us = user;
                }

            }
            Connection.dr.Close();
            return us;

        }
        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
            new Welcome().Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void tpUser_TextChanged(object sender, EventArgs e)
        {
            if (cb1.Text == "customer")
            {
                searchCustomer(tpUser.Text);
            }
            else if (cb1.Text == "seller")
            {
                searchSellerr(tpUser.Text);
            }
            
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
            cb1.Items.Add("customer");
            cb1.Items.Add("seller");
        }

        private void tpCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb1.Text == "customer")
                {
                    Connection.connecter();
                    Connection.com.Connection = Connection.cnx;
                    Connection.com.Parameters.AddWithValue("@user", tpUser.Text);
                    Connection.com.Parameters.AddWithValue("@name", tpName.Text);
                    Connection.com.Parameters.AddWithValue("@password", tpPassword.Text);
                    Connection.com.Parameters.AddWithValue("@city", tpCity.Text);
                    Connection.com.Parameters.AddWithValue("@phone", tpPhone.Text);
                    Connection.com.CommandText = "insert into customer values(@user,@name,@password,@city,@phone)";
                    Connection.com.ExecuteNonQuery();
                    Connection.deconnecter();
                    Class1.ls.Add(tpUser.Text);
                    Password.User = tpUser.Text;
                    Password.name = tpName.Text;
                    Password.PasswordA = tpPassword.Text;
                    Password.City = tpCity.Text;
                    Password.phone = tpPhone.Text;
                    MessageBox.Show("Congratulations " + tpName.Text + "! You have successfully sign up");

                    this.Hide();
                    new Welcome().Show();
                }
                else if (cb1.Text == "seller")
                {
                    Connection.connecter();
                    Connection.com.Connection = Connection.cnx;
                    Connection.com.Parameters.AddWithValue("@user", tpUser.Text);
                    Connection.com.Parameters.AddWithValue("@name", tpName.Text);
                    Connection.com.Parameters.AddWithValue("@password", tpPassword.Text);
                    Connection.com.Parameters.AddWithValue("@city", tpCity.Text);
                    Connection.com.Parameters.AddWithValue("@phone", tpPhone.Text);
                    Connection.com.CommandText = "insert into seller values(@user,@name,@password,@city,@phone)";
                    Connection.com.ExecuteNonQuery();
                    Connection.deconnecter();
                    Class1.ls.Add(tpUser.Text);
                    Password.User = tpUser.Text;
                    Password.name = tpName.Text;
                    Password.PasswordA = tpPassword.Text;
                    Password.City = tpCity.Text;
                    Password.phone = tpPhone.Text;
                    MessageBox.Show("Congratulations " + tpName.Text + "! You have successfully sign up");
                    this.Hide();
                    new Welcome().Show();
                }
                else
                    MessageBox.Show("choose customer/seller");


            }
            catch { MessageBox.Show("You failed to sign up! Try again"); };
        }
    }
}
