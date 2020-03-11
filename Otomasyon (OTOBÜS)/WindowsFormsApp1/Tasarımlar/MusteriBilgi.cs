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
    public partial class MüşteriBilgi : Form
    {
        public MüşteriBilgi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            string Adi = textBox1.Text;
            string Soyadi = textBox2.Text;
            string Mail = textBox4.Text;
            string TelNo = textBox3.Text;
            string TcNo = textBox8.Text;
            con = new SqlConnection("server=MERT-BILGISAYAR\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Lütfen ilgili alanları doldurunuz");
            }
            else {
            cmd.CommandText = "insert into tbl_MusteriBilgi(AD,SOYAD,MAİL,TELNO,TCNO) values (@adi,@soyadi,@mail,@telno,@tcno)";
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyadi", textBox2.Text);
            cmd.Parameters.AddWithValue("@mail", textBox4.Text);
            cmd.Parameters.AddWithValue("@telno", textBox3.Text);
            cmd.Parameters.AddWithValue("@tcno", textBox8.Text); 
            
            cmd.ExecuteNonQuery();
            con.Close();
            Form3 biletsatis = new Form3();
            this.Hide();
            biletsatis.Show();

            }
        
           
            
        }
    }
}
