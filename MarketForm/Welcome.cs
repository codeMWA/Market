using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketForm
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void DisplayHomepage(Control home1)
        {
            firstHomepage1.Visible = false;
            secondHomepage1.Visible = false;
            thirdHomepage1.Visible = false;
            fourthHomepage1.Visible = false;
            home1.Visible = true;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayHomepage(firstHomepage1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayHomepage(secondHomepage1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayHomepage(thirdHomepage1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisplayHomepage(fourthHomepage1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new signUp.Sign_Up().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Acces().Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
