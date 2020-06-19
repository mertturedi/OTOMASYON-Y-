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
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form112 : Form
    {   
       
        public Form112()
        {
            InitializeComponent();
        }
      SqlDataAdapter da = new SqlDataAdapter();

        DataSet ds = new DataSet();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void Form112_Load(object sender, EventArgs e)
        {
            label1.Text = KullanıcıGirişForm.mert;
            griddoldur();
            mail();
            string deger1 = dataGridView4.CurrentRow.Cells["MAİL"].Value.ToString();
            textBox2.Text = deger1;
      
            griddoldur();
        }
        void mail()
        {
            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            da = new SqlDataAdapter("select MAİL from tbl_kullaniciKayit WHERE KADI='" + label1.Text + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "otobüs");
            dataGridView4.DataSource = ds.Tables["otobüs"];
            con.Close();
        }
        void griddoldur()
        {
            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            da = new SqlDataAdapter("select KonuBaşlık,Mesaj,GönderenMail from tbl_GidenMesaj where AlıcıMail= '" + textBox2.Text + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "otobüs");
            dataGridView3.DataSource = ds.Tables["otobüs"];
            con.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string deger1 = dataGridView3.CurrentRow.Cells["GönderenMail"].Value.ToString();
            textBox1.Text = deger1;
            string deger2 = dataGridView3.CurrentRow.Cells["Mesaj"].Value.ToString();
            textBox3.Text = deger2;
            textBox4.Text = deger2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && richTextBox1.Text != "")
            {


                SqlConnection con;
                SqlCommand cmd;
                SqlDataReader dr;
                string gönderici = textBox1.Text;
                string alıcı = textBox2.Text;
                string mesaj = richTextBox1.Text;
                string mesajiçerik = textBox3.Text;
                con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into tbl_GelenMesaj(AlıcıMail,Cevap,GönderenMail,Mesajİçerik) values (@gönderici,@mesaj,@alıcı,@mesajiçerik)";
                cmd.Parameters.AddWithValue("@gönderici", textBox1.Text);
                cmd.Parameters.AddWithValue("@alıcı", textBox2.Text);
                cmd.Parameters.AddWithValue("@mesaj", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@mesajiçerik", textBox3.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" İşlem Gerçekleşmiştir...");



            }
            else
            {
                MessageBox.Show("Alanları doldurunuz...");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {




            SqlConnection con;
            SqlCommand cmd, cmk;
            SqlDataReader dr;
            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmk = new SqlCommand();
            con.Open();
            cmd.Connection = con;


            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Delete tbl_GidenMesaj where  Mesaj='" + textBox4.Text + "'";
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Silinmiştir. İŞLEM BAŞARILI");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            griddoldur();






        }
    }
    }


