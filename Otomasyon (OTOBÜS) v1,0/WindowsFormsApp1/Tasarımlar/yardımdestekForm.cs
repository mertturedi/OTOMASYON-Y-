using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class yardımdestek : Form
    {
        public yardımdestek()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
            MailMessage message = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new NetworkCredential("iksvinfo@gmail.com", "iksvESTP34");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            message.To.Add("mertturedi90@gmail.com");
            message.From = new MailAddress("mertturedi90@gmail.com");
            message.Subject = "HATA BİLDİRİM"+" "+"("+textBox1.Text+")";
            message.Body = "HATA MESAJI   : " + richTextBox1.Text;
            istemci.Send(message);
            MessageBox.Show("Mail Gönderildi...");
            }
            else
            {
                MessageBox.Show("Lütfen Hata Mesajını Yazınız Alanları Doldurunuz...");
            }
           
        }

        private void yardımdestek_Load(object sender, EventArgs e)
        {
            textBox1.Text = YöneticiPaneliForm.mert1;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form112 klnc = new Form112();
            klnc.Show();
        }
    }
}
