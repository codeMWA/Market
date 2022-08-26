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

namespace MarketForm.sellerHomepage
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelManager.Visible = false;
            panelStatistics.Visible = false;
            settingPanel.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelManager.Visible == true)
                panelManager.Visible = false;

            if (panelStatistics.Visible == true)
                panelStatistics.Visible = false;

            if (settingPanel.Visible == true)
                settingPanel.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        private void addAnAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removeAnAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
        private Form activeForm = null;
        private void openChildForm(Form childF)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childF;
            childF.TopLevel = false;
            childF.FormBorderStyle = FormBorderStyle.None;
            childF.Dock = DockStyle.Fill;
            panelSection.Controls.Add(childF);
            panelSection.Tag = childF;
            childF.BringToFront();
            childF.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelManager);
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new sellerHomepage.AddAcc());
            hideSubMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new sellerHomepage.DelAcc());
            hideSubMenu();
        }

        private void buttonStati_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStatistics);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            openChildForm(new sellerHomepage.UpdateAcc());
            hideSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            openChildForm(new sellerHomepage.SellerCust());
            hideSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            openChildForm(new sellerHomepage.SellerAcc());
            hideSubMenu();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            openChildForm(new sellerHomepage.AccCust());
            hideSubMenu();
        }


        private void Homepage_Load(object sender, EventArgs e)
        {
            lbUser.Text = Class1.User;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showSubMenu(settingPanel);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new CrystalSeller_cust.Support());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (DialogResult.Yes == dialogResult)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new settings());
        }
    }
}
