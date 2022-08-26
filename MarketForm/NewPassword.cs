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
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (tpNewP.Text == tpNewC.Text)
            {
                if (Password.userType == "customer")
                {
                    Connection.connecter();
                    Connection.com.Connection = Connection.cnx;
                    Connection.com.CommandText = "update customer set passwordC = '" + tpNewP.Text + "' where nameC='" + Password.name + "' and CityC= '" + Password.City + "' and phoneC = '" + Password.phone + "'";
                    Connection.com.ExecuteNonQuery();
                    new Acces().Show();
                    this.Hide();
                }
                if (Password.userType == "seller")
                {
                    Connection.connecter();
                    Connection.com.Connection = Connection.cnx;
                    Connection.com.CommandText = "update seller set passwordS = '" + tpNewP.Text + "' where nameS='" + Password.name + "' and CityS= '" + Password.City + "' and phoneS = '" + Password.phone + "'";
                    Connection.com.ExecuteNonQuery();
                    new Acces().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Try Confirm new password!");
                tpNewP.Clear();
                tpNewC.Clear();
            }
        }
    }
}
