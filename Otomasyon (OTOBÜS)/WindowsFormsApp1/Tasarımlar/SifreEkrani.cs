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

namespace WindowsFormsApp1
{
    public partial class SifreEkrani : Form
    {
        public SifreEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;

            con = new SqlConnection("server=MERT-BILGISAYAR\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT SİFRE FROM tbl_kullaniciKayit where  MAİL='" + textBox1.Text + "' AND TCNO='" + textBox2.Text+"'";
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                listBox1.Items.Add(dr["SİFRE"].ToString());





            }
            else
            {

                MessageBox.Show("Lütfen alanları doğru doldurduğunuzdan emin olunuz...");
            }



            }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        //MailMessage mesajim = new MailMessage();
        //SmtpClient istemci = new SmtpClient();
        //istemci.Credentials = new System.Net.NetworkCredential("sberk291@gmail.com", "mert5261..");
        //istemci.Port = 587;
        //istemci.Host = "smtp.live.com";
        //istemci.EnableSsl = true;
        //mesajim.To.Add(textBox1.Text);
        //mesajim.From = new MailAddress ("sberk291@gmail.com");
        //mesajim.Subject = "OTOBÜS OTOMASYON";
        //mesajim.Body = listBox1.Text;






    }
}
