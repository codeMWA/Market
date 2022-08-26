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

namespace MarketForm.sellerHomepage
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {
            Deconnection.adapt = new SqlDataAdapter("select * from seller where userS = '"+Class1.User+"'",Deconnection.cn);
            Deconnection.adapt.Fill(Deconnection.dss,"sell");
            for(int i=0; i<Deconnection.dss.Tables["sell"].Rows.Count; i++)
            {
                txtUser.Text = Deconnection.dss.Tables["sell"].Rows[i][0].ToString();
                txtName.Text = Deconnection.dss.Tables["sell"].Rows[i][1].ToString();
                txtPass.Text = Deconnection.dss.Tables["sell"].Rows[i][2].ToString();
                txtCity.Text = Deconnection.dss.Tables["sell"].Rows[i][3].ToString();
                txtPhone.Text = Deconnection.dss.Tables["sell"].Rows[i][4].ToString();
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Deconnection.com = new SqlCommandBuilder(Deconnection.adapt);
            for (int i = 0; i < Deconnection.dss.Tables["sell"].Rows.Count; i++)
            {
                if(Deconnection.dss.Tables["sell"].Rows[i][0].ToString() == txtUser.Text)
                {
                    Deconnection.dss.Tables["sell"].Rows[i][1] = txtName.Text;
                    Deconnection.dss.Tables["sell"].Rows[i][2] = txtPass.Text;
                    Deconnection.dss.Tables["sell"].Rows[i][3] = txtCity.Text;
                    Deconnection.dss.Tables["sell"].Rows[i][4] = txtPhone.Text;
                    Deconnection.adapt.Update(Deconnection.dss.Tables["sell"]);
                    MessageBox.Show("Your informations are updated.");
                    break;
                }
            }
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
