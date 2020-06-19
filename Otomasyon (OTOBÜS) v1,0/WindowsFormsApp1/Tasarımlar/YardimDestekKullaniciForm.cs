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
using System.Data.OleDb;
using System.Data.Common;


namespace WindowsFormsApp1
{
    public partial class YardimDestekKullaniciForm : Form
    {
        public YardimDestekKullaniciForm()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();

        DataSet ds = new DataSet();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
     
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void oTOBÜS1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = KullanıcıGirişForm.mert;
            griddoldur();
            griddoldur1();
            mail();
            getir();
            griddoldur1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
       

        }

        private void button8_Click(object sender, EventArgs e)
        {
       
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //SqlConnection con;
            //SqlCommand cmd;
            //SqlDataReader dr;
            //string NERDEN = comboBox1.Text;
            //string NEREYE = comboBox2.Text;
            //string KOLTUKADETİ = textBox2.Text;
            //string FİYAT = textBox1.Text;
            //string KALKISSAAT = comboBox3.Text;
            //string KALKISGÜNÜ = monthCalendar2.Text;
            //string DONUSGÜNÜ = monthCalendar1.Text;
            //string KOLTUKNO = listBox1.Text;
            //string BİLETNO = textBox3.Text;
            //con = new SqlConnection("server=MERT-BILGISAYAR\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;

            //if (textBox1.Text == "" && textBox2.Text == "")
            //{
            //    MessageBox.Show("Lütfen ilgili alanları doldurunuz");
            //}
            //else
            //{
            //    cmd.CommandText = "insert into tbl_bilet(NERDEN,NEREYE,KOLTUKADET,FİYAT,KALKISSAAT,KALKISGUNU,DONUSGUNU,KOLTUKNO,BİLETNO) values (@NERDEN,@NEREYE,@KOLTUKADETİ,@FİYAT,@KALKISSAAT,@KALKISGÜNÜ,@DONUSGÜNÜ,@KOLTUKNO,@BİLETNO  )";
            //    cmd.Parameters.AddWithValue("@NERDEN", comboBox1.Text);
            //    cmd.Parameters.AddWithValue("@NEREYE", comboBox2.Text);
            //    cmd.Parameters.AddWithValue("@KOLTUKADETİ", textBox2.Text);
            //    cmd.Parameters.AddWithValue("@FİYAT", textBox1.Text);
            //    cmd.Parameters.AddWithValue("@KALKISSAAT", comboBox3.Text);
            //    cmd.Parameters.AddWithValue("@KALKISGÜNÜ", monthCalendar2.Text);
            //    cmd.Parameters.AddWithValue("@DONUSGÜNÜ", monthCalendar1.Text);
            //    cmd.Parameters.AddWithValue("@KOLTUKNO", listBox1.Items);
            //    cmd.Parameters.AddWithValue("@BİLETNO", textBox3.Text);

            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    Form3 biletsatis = new Form3();
            //    this.Hide();
            //    biletsatis.Show();

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        void griddoldur()
        {
            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            da = new SqlDataAdapter("select AD+''+SOYAD AS AdSoyad,KYETKİ,MAİL from tbl_kullaniciKayit", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "otobüs");
            dataGridView3.DataSource = ds.Tables["otobüs"];
            con.Close();
        }

        void griddoldur1()
        {
            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            da = new SqlDataAdapter("select Mesajİçerik as SordugunSoru,Cevap,GönderenMail as GönderenKişi from tbl_GelenMesaj WHERE AlıcıMail='" + textBox2.Text + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "otobüs");
            dataGridView4.DataSource = ds.Tables["otobüs"];
            con.Close();
        }

        void mail()
        {
            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            da = new SqlDataAdapter("select MAİL from tbl_kullaniciKayit WHERE KADI='" + label1.Text + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "otobüs");
            grmail.DataSource = ds.Tables["otobüs"];
            con.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string deger = dataGridView3.CurrentRow.Cells["MAİL"].Value.ToString();
            textBox1.Text = deger;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" &&  textBox2.Text !="" && richTextBox1.Text != "")
            {
                

                    SqlConnection con;
                    SqlCommand cmd;
                    SqlDataReader dr;
                    string gönderici = textBox1.Text;
                    string alıcı = textBox2.Text;
                    string mesaj = richTextBox1.Text;
                    string başlık = textBox3.Text;

                con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into tbl_GidenMesaj(AlıcıMail,Mesaj,GönderenMail,KonuBaşlık) values (@gönderici,@mesaj,@alıcı,@başlık)";
                    cmd.Parameters.AddWithValue("@gönderici", textBox1.Text);
                    cmd.Parameters.AddWithValue("@alıcı", textBox2.Text);
                    cmd.Parameters.AddWithValue("@mesaj", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@başlık", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Mail Gönderilmiştir...");
                   
               

            }
            else
            {
                MessageBox.Show("Alanları doldurunuz...");
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             string deger1 = grmail.CurrentRow.Cells["MAİL"].Value.ToString();
            textBox2.Text = deger1;
           
        }
        void getir()
        {
            string deger1 = grmail.CurrentRow.Cells["MAİL"].Value.ToString();
            textBox2.Text = deger1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form112 frm112 = new Form112();
            frm112.Show();

        }

        private void button3_Click(object sender, EventArgs e)
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
            cmd.CommandText = "Delete tbl_GelenMesaj where  Cevap='" + textBox4.Text + "'";
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            MessageBox.Show("SİLME İŞLEMİ BAŞARILI");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            griddoldur();
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string deger2 = dataGridView4.CurrentRow.Cells["Cevap"].Value.ToString();
            textBox4.Text = deger2;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

