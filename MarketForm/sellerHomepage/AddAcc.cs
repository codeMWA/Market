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
    public partial class AddAcc : Form
    {
        public AddAcc()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void FillDGV()
        {
            DataTable dt = new DataTable();
            Deconnection.adapt = new SqlDataAdapter("select accounts_products.account_type, email, passwordA,price, quantity from products join accounts_products " +
                "on products.account_type = accounts_products.account_type where userS = '"+Class1.User+"'", Deconnection.cn);
            Deconnection.adapt.Fill(dt);
            //dataGridView1.Rows.Clear();
            dataGridView1.DataSource = dt;
        }
        private void AddAcc_Load(object sender, EventArgs e)
        {
            Deconnection.adapt = new SqlDataAdapter("select * from products", Deconnection.cn);
            DataTable dt = new DataTable();
            Deconnection.adapt.Fill(dt);
            for(int i = 0;i<dt.Rows.Count;i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0]);
            }
            comboBox1.Items.Add("New account");
            FillDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBox1.Text == "New account")
                {
                    AccesLinq.DataClasses1DataContext lnq = new AccesLinq.DataClasses1DataContext();
                    AccesLinq.products pr = new AccesLinq.products();
                    pr.account_type = Class1.AccType;
                    pr.quantity = 0;
                    lnq.products.InsertOnSubmit(pr);
                    lnq.SubmitChanges();
                    

                    Connection.connecter();
                    Connection.com.Connection = Connection.cnx;
                    Connection.com.CommandText = "insert into accounts_products values('" + Class1.AccType + "','" + int.Parse(tpPrice.Text) + "','" + tpEmail.Text + "','" + tpPass.Text + "','" + float.Parse(tpDuration.Text) + "','"+Class1.User+"')";
                    Connection.com.ExecuteNonQuery();
                    MessageBox.Show("good add");
                    FillDGV();
                }
                else
                {
                    Connection.connecter();
                    Connection.com.Connection = Connection.cnx;
                    Connection.com.CommandText = "insert into accounts_products values('" + comboBox1.Text + "','" + int.Parse(tpPrice.Text) + "','" + tpEmail.Text + "','" + tpPass.Text + "','" + float.Parse(tpDuration.Text) + "','" + Class1.User + "')";
                    Connection.com.ExecuteNonQuery();
                    MessageBox.Show("good add");
                    FillDGV();
                }
        }
            catch(Exception ex) { MessageBox.Show("" + ex); }


}

        private void tpPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="New account")
            {
                new AutreTypeAcc.AccType().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
