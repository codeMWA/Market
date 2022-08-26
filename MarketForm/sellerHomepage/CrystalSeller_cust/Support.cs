using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MarketForm.sellerHomepage.CrystalSeller_cust
{
    public partial class Support : Form
    {
        public Support()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtmess_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmail_Enter(object sender, EventArgs e)
        {
            if(txtmail.Text=="Your Email")
            {
                txtmail.Clear();
                txtmail.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtmail_Leave(object sender, EventArgs e)
        {
            if(txtmail.Text=="")
            {
                txtmail.ForeColor = Color.DimGray;
                txtmail.Text = "Your Email";
            }
        }

        private void txtsub_Enter(object sender, EventArgs e)
        {
            if (txtsub.Text == "Subject")
            {
                txtsub.Clear();
                txtsub.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtsub_Leave(object sender, EventArgs e)
        {
            if (txtsub.Text == "")
            {
                txtsub.ForeColor = Color.DimGray;
                txtsub.Text = "Subject";
            }
        }

        private void txtmess_Enter(object sender, EventArgs e)
        {
            if (txtmess.Text == "Message")
            {
                txtmess.Clear();
                txtmess.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txtmess_Leave(object sender, EventArgs e)
        {
            if (txtmess.Text == "")
            {
                txtmess.ForeColor = Color.DimGray;
                txtmess.Text = "Message";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           


        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string to, from, pass, messageBody;
            MailMessage message = new MailMessage();
            to = "barakatamine99@gmail.com";
            from = txtmail.Text;
            pass = txPass.Text;
            messageBody = txtmess.Text;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "From : " + to + "<br>Message : " + messageBody;
            message.Subject = txtsub.Text;
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Email sent successfully", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (code == DialogResult.OK)
                {
                    txtmail.Clear();
                    txtsub.Clear();
                    txtmess.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txPass_Enter(object sender, EventArgs e)
        {
            if (txPass.Text == "Your Password")
            {
                txPass.Clear();
                txPass.ForeColor = Color.FromArgb(83, 179, 233);
            }
        }

        private void txPass_Leave(object sender, EventArgs e)
        {
            if (txPass.Text == "")
            {
                txPass.ForeColor = Color.DimGray;
                txPass.Text = "Your Password";
            }
        }
    }
}
