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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Deconnection.adapt = new SqlDataAdapter("select * from customer where userC = '" + Class1.User + "'", Deconnection.cn);
            Deconnection.adapt.Fill(Deconnection.dss, "cust");
            for (int i = 0; i < Deconnection.dss.Tables["cust"].Rows.Count; i++)
            {
                txtUser.Text = Deconnection.dss.Tables["cust"].Rows[i][0].ToString();
                txtName.Text = Deconnection.dss.Tables["cust"].Rows[i][1].ToString();
                txtPass.Text = Deconnection.dss.Tables["cust"].Rows[i][2].ToString();
                txtCity.Text = Deconnection.dss.Tables["cust"].Rows[i][3].ToString();
                txtPhone.Text = Deconnection.dss.Tables["cust"].Rows[i][4].ToString();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Deconnection.com = new SqlCommandBuilder(Deconnection.adapt);
            for (int i = 0; i < Deconnection.dss.Tables["cust"].Rows.Count; i++)
            {
                if (Deconnection.dss.Tables["cust"].Rows[i][0].ToString() == txtUser.Text)
                {
                    Deconnection.dss.Tables["cust"].Rows[i][1] = txtName.Text;
                    Deconnection.dss.Tables["cust"].Rows[i][2] = txtPass.Text;
                    Deconnection.dss.Tables["cust"].Rows[i][3] = txtCity.Text;
                    Deconnection.dss.Tables["cust"].Rows[i][4] = txtPhone.Text;
                    Deconnection.adapt.Update(Deconnection.dss.Tables["cust"]);
                    MessageBox.Show("Your informations are updated.");
                    break;
                }
            }
        }

    }
}
