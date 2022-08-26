using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MarketClass;

namespace MarketForm.sellerHomepage
{
    public partial class UpdateAcc : Form
    {
        public UpdateAcc()
        {
            InitializeComponent();
        }
        public void FillDGV()
        {
            DataTable dt = new DataTable();
            Deconnection.adapt = new SqlDataAdapter("select * from accounts_products where userS = '"+Class1.User+"'", Deconnection.cn);
            Deconnection.adapt.Fill(dt);
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
        }
    
        private void UpdateAcc_Load(object sender, EventArgs e)
        {
            Deconnection.adapt = new SqlDataAdapter("select * from accounts_products where userS = '" + Class1.User + "' ", Deconnection.cn);
            DataTable dt = new DataTable();
            Deconnection.adapt.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0]);
            }

            FillDGV();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            Deconnection.adapt = new SqlDataAdapter("select * from accounts_products where id_account = '"+comboBox1.Text+"'",Deconnection.cn);
            Deconnection.adapt.Fill(dt1);
            for(int i=0;i<dt1.Rows.Count;i++)
            {
                tpDuration.Text = dt1.Rows[i][5].ToString();
                tpEmail.Text = dt1.Rows[i][3].ToString();
                tpTypeA.Text = dt1.Rows[i][1].ToString();
                tpPass.Text = dt1.Rows[i][4].ToString();
                tpPrice.Text = dt1.Rows[i][2].ToString();
                FillDGV();
            }
        }

        private void tpPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        AccesLinq.DataClasses1DataContext lnk = new AccesLinq.DataClasses1DataContext();
     

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                AccesLinq.accounts_products acc = new AccesLinq.accounts_products();
                acc = lnk.accounts_products.First(x => x.id_account == int.Parse(comboBox1.Text));
                acc.account_type = tpTypeA.Text;
                acc.price = decimal.Parse(tpPrice.Text);
                acc.email = tpEmail.Text;
                acc.passwordA = tpPass.Text;
                acc.account_duration = int.Parse(tpDuration.Text);
                lnk.SubmitChanges();
                FillDGV();
                MessageBox.Show("account updated!");
            }
            catch (Exception ex) { MessageBox.Show("" + ex); };
        }

        private void tpDuration_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
