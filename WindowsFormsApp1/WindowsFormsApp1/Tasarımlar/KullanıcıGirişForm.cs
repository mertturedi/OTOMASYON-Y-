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

namespace WindowsFormsApp1
{
    public partial class KullanıcıGirişForm : Form
    {
        public KullanıcıGirişForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
           
            string user = textBox1.Text;
            string pass = textBox2.Text;
            con = new SqlConnection("server=MERT-BILGISAYAR\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
           
            cmd.CommandText = "SELECT * FROM tbl_kullanici1 where  KADI='" + textBox1.Text + "' AND KSİFRE='" + textBox2.Text + "'AND KYETKİ = 'Y'";
            
           
            
            
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
            
            MessageBox.Show("Giriş Başarılı Hoşgeldin  "+textBox1.Text);
            YöneticiPaneliForm frm = new YöneticiPaneliForm();
            this.Hide();
            frm.Show();
            }
            
            else if(true)
            {  cmd.CommandText = "SELECT * FROM tbl_kullanici1 where  KADI='" + textBox1.Text + "' AND KSİFRE='" + textBox2.Text + "'AND KYETKİ = 'k'";
                KullaniciPanel sil = new KullaniciPanel();
                this.Hide();
                sil.Show();
                MessageBox.Show("Giriş Başarılı Hoşgeldin  " + textBox1.Text);
            }
            con.Close();


        }

        private void KullanıcıGirişForm_Load(object sender, EventArgs e)
        {

        }
    }
}
