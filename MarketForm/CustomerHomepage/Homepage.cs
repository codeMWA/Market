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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
           
        }
        private void DisplayHome()
        {
            if (pnlPrincipal.Width == 45)
                pnlPrincipal.Width = 186;
            else
                pnlPrincipal.Width = 45;
        }
        private void HiddenHome()
        {
            if (pnlPrincipal.Width == 186)
                pnlPrincipal.Width = 45;
            else
                pnlPrincipal.Width = 186;
        }
        private void DisplayPanel()
        {
            if (panelFK.Visible == false)
                panelFK.Visible = true;
            else
                panelFK.Visible = false;
        }
        private void HiddenPanel()
        {
            if (panelFK.Visible == true)
                panelFK.Visible = false;
        }
        private void DisplayContent(Control cnt)
        {
            productControl2.Visible = false;
            support1.Visible = false;
            trendingSeller1.Visible = false;
            trendingAccount1.Visible = false;
            settings1.Visible = false;
            cnt.Visible = true;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            btnDisplay.Visible = false;
            pictureUser.Visible = true;
            labelUser.Visible = true;
            DisplayHome();
        }

        private void btnHidden_Click(object sender, EventArgs e)
        {
            HiddenPanel();
            pictureUser.Visible = false;
            labelUser.Visible = false;
            HiddenHome();
            btnDisplay.Visible = true;
        }

        private void btnFikra_Click(object sender, EventArgs e)
        {
            DisplayPanel();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            
            HiddenPanel();
            pictureUser.Visible = false;
            labelUser.Visible = false;
            btnDisplay.Visible = true;
            HiddenHome();
            DisplayContent(productControl2);

        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            HiddenPanel();
            pictureUser.Visible = false;
            labelUser.Visible = false;
            btnDisplay.Visible = true;
            HiddenHome();
            DisplayContent(support1);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            HiddenPanel();
            pictureUser.Visible = false;
            labelUser.Visible = false;
            btnDisplay.Visible = true;
            HiddenHome();
            DisplayContent(settings1);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            HiddenPanel();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (DialogResult.Yes == dialogResult)
            {
                this.Close();
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            HiddenPanel();
            labelUser.Text = Class1.User;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            HiddenPanel();
            pictureUser.Visible = false;
            labelUser.Visible = false;
            btnDisplay.Visible = true;
            HiddenHome();
            DisplayContent(trendingSeller1);
        }

        private void productControl2_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            HiddenPanel();
            pictureUser.Visible = false;
            labelUser.Visible = false;
            btnDisplay.Visible = true;
            HiddenHome();
            DisplayContent(trendingAccount1);
        }
    }
}
