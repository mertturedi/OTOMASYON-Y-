using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            string markası = textBox1.Text;
            string modeli = textBox3.Text;
            string yakıttürü = textBox2.Text;
            string km  = textBox4.Text;
            string koltuksayisi = textBox5.Text;
            string plaka = textBox6.Text;
            string Bilgi = richTextBox1.Text;
            con = new SqlConnection("server=MERT-BILGISAYAR\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_OtobusKayit(Marka,Model,YakitTürü,Km,Koltuksayisi,Plaka,Bilgi) values (@markası,@modeli,@yakıttürü,@km,@koltuksayisi,@plaka,@Bilgi)";
            cmd.Parameters.AddWithValue("@markası", textBox1.Text);
            cmd.Parameters.AddWithValue("@modeli", textBox3.Text);
            cmd.Parameters.AddWithValue("@yakıttürü", textBox2.Text);
            cmd.Parameters.AddWithValue("@km", textBox4.Text);
            cmd.Parameters.AddWithValue("@koltuksayisi", textBox5.Text);
            cmd.Parameters.AddWithValue("@plaka", textBox6.Text);
            cmd.Parameters.AddWithValue("@Bilgi", richTextBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
        }
    }
}
