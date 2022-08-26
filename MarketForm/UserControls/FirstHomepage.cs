using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketForm.UserControls
{
    public partial class FirstHomepage : UserControl
    {
        public FirstHomepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UserControls.ReadMoreForm().Show();
        }
    }
}
