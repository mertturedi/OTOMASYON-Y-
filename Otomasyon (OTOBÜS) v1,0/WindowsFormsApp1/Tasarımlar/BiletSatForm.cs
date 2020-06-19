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
using System.Data;
using System.Data.OleDb;
using System.Data.Common;


namespace WindowsFormsApp1
{
    public partial class BiletSatForm : Form
    {
       
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string[] koltuklar = new string[11];
        public BiletSatForm()
        {

           
            InitializeComponent();
        }
        private void Koltuk_kontrol()

        {
            int koltuk;
            string cinsiyet;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select KoltukNo,Cinsiyet from tbl_BileterSatis ";
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                koltuk = Convert.ToInt32(dr["KoltukNo"]);
                cinsiyet = Convert.ToString(dr["Cinsiyet"]);
                if (koltuk == 1)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox1.BackColor = Color.Red;
                        checkBox1.Enabled = false;
                    }
                    else
                    {
                        checkBox1.BackColor = Color.Blue;
                        checkBox1.Enabled = false;
                    }
                }
                if (koltuk == 2)
                {
                    if (cinsiyet=="K")
                    {
                    checkBox2.BackColor = Color.Red;
                    checkBox2.Enabled = false;
                    }
                    else
                    {
                        checkBox2.BackColor = Color.Blue;
                        checkBox2.Enabled = false;
                    }
                    
                }
                if (koltuk == 3)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox3.BackColor = Color.Red;
                        checkBox3.Enabled = false;
                    }
                    else
                    {
                        checkBox3.BackColor = Color.Blue;
                        checkBox3.Enabled = false;
                    }
                }
                if (koltuk == 4)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox4.BackColor = Color.Red;
                        checkBox4.Enabled = false;
                    }
                    else
                    {
                        checkBox4.BackColor = Color.Blue;
                        checkBox4.Enabled = false;
                    }
                }
                if (koltuk == 5)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox5.BackColor = Color.Red;
                        checkBox5.Enabled = false;
                    }
                    else
                    {
                        checkBox5.BackColor = Color.Blue;
                        checkBox5.Enabled = false;
                    }
                }
                if (koltuk == 6)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox6.BackColor = Color.Red;
                        checkBox6.Enabled = false;
                    }
                    else
                    {
                        checkBox6.BackColor = Color.Blue;
                        checkBox6.Enabled = false;
                    }
                }
                if (koltuk == 7)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox7.BackColor = Color.Red;
                        checkBox7.Enabled = false;
                    }
                    else
                    {
                        checkBox7.BackColor = Color.Blue;
                        checkBox7.Enabled = false;
                    }
                }
                if (koltuk == 8)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox8.BackColor = Color.Red;
                        checkBox8.Enabled = false;
                    }
                    else
                    {
                        checkBox8.BackColor = Color.Blue;
                        checkBox8.Enabled = false;
                    }
                }
                if (koltuk == 9)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox9.BackColor = Color.Red;
                        checkBox9.Enabled = false;
                    }
                    else
                    {
                        checkBox9.BackColor = Color.Blue;
                        checkBox9.Enabled = false;
                    }
                }
                if (koltuk == 10)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox10.BackColor = Color.Red;
                        checkBox10.Enabled = false;
                    }
                    else
                    {
                        checkBox10.BackColor = Color.Blue;
                        checkBox10.Enabled = false;
                    }
                }
                if (koltuk == 11)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox11.BackColor = Color.Red;
                        checkBox11.Enabled = false;
                    }
                    else
                    {
                        checkBox11.BackColor = Color.Blue;
                        checkBox11.Enabled = false;
                    }
                }
                if (koltuk == 12)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox12.BackColor = Color.Red;
                        checkBox12.Enabled = false;
                    }
                    else
                    {
                        checkBox12.BackColor = Color.Blue;
                        checkBox12.Enabled = false;
                    }
                }
                if (koltuk == 13)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox13.BackColor = Color.Red;
                        checkBox13.Enabled = false;
                    }
                    else
                    {
                        checkBox13.BackColor = Color.Blue;
                        checkBox13.Enabled = false;
                    }
                }
                if (koltuk == 14)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox14.BackColor = Color.Red;
                        checkBox14.Enabled = false;
                    }
                    else
                    {
                        checkBox14.BackColor = Color.Blue;
                        checkBox14.Enabled = false;
                    }
                }
                if (koltuk == 15)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox15.BackColor = Color.Red;
                        checkBox15.Enabled = false;
                    }
                    else
                    {
                        checkBox15.BackColor = Color.Blue;
                        checkBox15.Enabled = false;
                    }
                }
                if (koltuk == 16)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox16.BackColor = Color.Red;
                        checkBox16.Enabled = false;
                    }
                    else
                    {
                        checkBox16.BackColor = Color.Blue;
                        checkBox16.Enabled = false;
                    }
                }
                if (koltuk == 17)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox17.BackColor = Color.Red;
                        checkBox17.Enabled = false;
                    }
                    else
                    {
                        checkBox17.BackColor = Color.Blue;
                        checkBox17.Enabled = false;
                    }
                }
                if (koltuk == 18)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox18.BackColor = Color.Red;
                        checkBox18.Enabled = false;
                    }
                    else
                    {
                        checkBox18.BackColor = Color.Blue;
                        checkBox18.Enabled = false;
                    }
                }
                if (koltuk == 19)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox19.BackColor = Color.Red;
                        checkBox19.Enabled = false;
                    }
                    else
                    {
                        checkBox19.BackColor = Color.Blue;
                        checkBox19.Enabled = false;
                    }
                }
                if (koltuk == 20)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox20.BackColor = Color.Red;
                        checkBox20.Enabled = false;
                    }
                    else
                    {
                        checkBox20.BackColor = Color.Blue;
                        checkBox20.Enabled = false;
                    }
                }
                if (koltuk == 21)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox21.BackColor = Color.Red;
                        checkBox21.Enabled = false;
                    }
                    else
                    {
                        checkBox21.BackColor = Color.Blue;
                        checkBox21.Enabled = false;
                    }
                }
                if (koltuk == 22)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox22.BackColor = Color.Red;
                        checkBox22.Enabled = false;
                    }
                    else
                    {
                        checkBox22.BackColor = Color.Blue;
                        checkBox22.Enabled = false;
                    }
                }
                if (koltuk == 23)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox23.BackColor = Color.Red;
                        checkBox23.Enabled = false;
                    }
                    else
                    {
                        checkBox23.BackColor = Color.Blue;
                        checkBox23.Enabled = false;
                    }
                }
                if (koltuk == 24)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox24.BackColor = Color.Red;
                        checkBox24.Enabled = false;
                    }
                    else
                    {
                        checkBox24.BackColor = Color.Blue;
                        checkBox24.Enabled = false;
                    }
                }
                if (koltuk == 25)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox25.BackColor = Color.Red;
                        checkBox25.Enabled = false;
                    }
                    else
                    {
                        checkBox25.BackColor = Color.Blue;
                        checkBox25.Enabled = false;
                    }
                }
                if (koltuk == 26)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox26.BackColor = Color.Red;
                        checkBox26.Enabled = false;
                    }
                    else
                    {
                        checkBox26.BackColor = Color.Blue;
                        checkBox26.Enabled = false;
                    }
                }
                if (koltuk == 27)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox27.BackColor = Color.Red;
                        checkBox27.Enabled = false;
                    }
                    else
                    {
                        checkBox27.BackColor = Color.Blue;
                        checkBox27.Enabled = false;
                    }
                }
                if (koltuk == 28)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox28.BackColor = Color.Red;
                        checkBox28.Enabled = false;
                    }
                    else
                    {
                        checkBox28.BackColor = Color.Blue;
                        checkBox28.Enabled = false;
                    }
                }
                if (koltuk == 29)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox29.BackColor = Color.Red;
                        checkBox29.Enabled = false;
                    }
                    else
                    {
                        checkBox29.BackColor = Color.Blue;
                        checkBox29.Enabled = false;
                    }
                }
                if (koltuk == 30)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox30.BackColor = Color.Red;
                        checkBox30.Enabled = false;
                    }
                    else
                    {
                        checkBox30.BackColor = Color.Blue;
                        checkBox30.Enabled = false;
                    }
                }
                if (koltuk == 31)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox31.BackColor = Color.Red;
                        checkBox31.Enabled = false;
                    }
                    else
                    {
                        checkBox31.BackColor = Color.Blue;
                        checkBox31.Enabled = false;
                    }
                }
                if (koltuk == 32)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox32.BackColor = Color.Red;
                        checkBox32.Enabled = false;
                    }
                    else
                    {
                        checkBox32.BackColor = Color.Blue;
                        checkBox32.Enabled = false;
                    }
                }
                if (koltuk == 33)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox33.BackColor = Color.Red;
                        checkBox33.Enabled = false;
                    }
                    else
                    {
                        checkBox33.BackColor = Color.Blue;
                        checkBox33.Enabled = false;
                    }
                }
                if (koltuk == 34)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox34.BackColor = Color.Red;
                        checkBox34.Enabled = false;
                    }
                    else
                    {
                        checkBox34.BackColor = Color.Blue;
                        checkBox34.Enabled = false;
                    }
                }
                if (koltuk == 35)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox35.BackColor = Color.Red;
                        checkBox35.Enabled = false;
                    }
                    else
                    {
                        checkBox35.BackColor = Color.Blue;
                        checkBox35.Enabled = false;
                    }
                }
                if (koltuk == 36)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox36.BackColor = Color.Red;
                        checkBox36.Enabled = false;
                    }
                    else
                    {
                        checkBox36.BackColor = Color.Blue;
                        checkBox36.Enabled = false;
                    }
                }
                if (koltuk == 37)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox37.BackColor = Color.Red;
                        checkBox37.Enabled = false;
                    }
                    else
                    {
                        checkBox37.BackColor = Color.Blue;
                        checkBox37.Enabled = false;
                    }
                }
                if (koltuk == 38)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox38.BackColor = Color.Red;
                        checkBox38.Enabled = false;
                    }
                    else
                    {
                        checkBox38.BackColor = Color.Blue;
                        checkBox38.Enabled = false;
                    }
                }
                if (koltuk == 39)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox39.BackColor = Color.Red;
                        checkBox39.Enabled = false;
                    }
                    else
                    {
                        checkBox39.BackColor = Color.Blue;
                        checkBox39.Enabled = false;
                    }
                }
                if (koltuk == 40)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox40.BackColor = Color.Red;
                        checkBox40.Enabled = false;
                    }
                    else
                    {
                        checkBox40.BackColor = Color.Blue;
                        checkBox40.Enabled = false;
                    }
                }
                if (koltuk == 41)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox41.BackColor = Color.Red;
                        checkBox41.Enabled = false;
                    }
                    else
                    {
                        checkBox41.BackColor = Color.Blue;
                        checkBox41.Enabled = false;
                    }
                }
                if (koltuk == 42)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox42.BackColor = Color.Red;
                        checkBox42.Enabled = false;
                    }
                    else
                    {
                        checkBox42.BackColor = Color.Blue;
                        checkBox42.Enabled = false;
                    }
                }
                if (koltuk == 43)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox43.BackColor = Color.Red;
                        checkBox43.Enabled = false;
                    }
                    else
                    {
                        checkBox43.BackColor = Color.Blue;
                        checkBox43.Enabled = false;
                    }
                }
                if (koltuk == 44)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox44.BackColor = Color.Red;
                        checkBox44.Enabled = false;
                    }
                    else
                    {
                        checkBox44.BackColor = Color.Blue;
                        checkBox44.Enabled = false;
                    }
                }
                if (koltuk == 45)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox45.BackColor = Color.Red;
                        checkBox45.Enabled = false;
                    }
                    else
                    {
                        checkBox45.BackColor = Color.Blue;
                        checkBox45.Enabled = false;
                    }
                }
                if (koltuk == 46)
                {
                    if (cinsiyet == "K")
                    {
                        checkBox46.BackColor = Color.Red;
                        checkBox46.Enabled = false;
                    }
                    else
                    {
                        checkBox46.BackColor = Color.Blue;
                        checkBox46.Enabled = false;
                    }
                }












            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            try
            {

                #region kodlar
                if (textBox1.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox10.Text != "" || comboBox5.Text != "" ||  comboBox1.Text != "" || textBox2.Text != "" || comboBox3.Text != "" || comboBox4.Text != "")
                {


                   
                    string AdiSoyadi = textBox1.Text;
                    string cinsiyet = comboBox4.Text;
                    string TcNo = textBox3.Text;
                    string TelNo = textBox4.Text;
                    string kangrubu = comboBox5.Text;
                    string koltukno = textBox2.Text;
                    string Biletsatıştarihi = dateTimePicker1.Text;
                    string Otobüskalkişyeri = comboBox1.Text;
                    string OtobüsVarışYeri = comboBox3.Text;
                    string BiletFiyati = textBox10.Text;
                    con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into tbl_BileterSatis(AdıSoyadı,Cinsiyet,TcNo,TelNo,KanGrubu,KoltukNo,Tarih,KalkışYeri,VarışYeri,BiletFiyati) values (@AdiSoyadi,@cinsiyet,@TcNo,@TelNo,@kangrubu,@koltukno,@Biletsatıştarihi,@Otobüskalkişyeri,@OtobüsVarışYeri,@BiletFiyati)";
                    cmd.Parameters.AddWithValue("@AdiSoyadi", textBox1.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", comboBox4.Text);
                    cmd.Parameters.AddWithValue("@TcNo", textBox3.Text);
                    cmd.Parameters.AddWithValue("@TelNo", textBox4.Text);
                    cmd.Parameters.AddWithValue("@kangrubu", comboBox5.Text);
                    cmd.Parameters.AddWithValue("@koltukno", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Biletsatıştarihi", dateTimePicker1.Text);
                    cmd.Parameters.AddWithValue("@Otobüskalkişyeri", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@OtobüsVarışYeri", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@BiletFiyati", textBox10.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                   // MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");







                    //       baglanti.Close();
                    label12.Text = "kayıt Altına Alınmıstır";
                    label12.ForeColor = Color.Green;
                    griddoldur();
                    Koltuk_kontrol();
                }

                else
                {

                    MessageBox.Show("Lütfen  boş alanları doldurunuz!!..");
                    //label12.Text = "Hata !!";
                    //label12.ForeColor = Color.Red;

                }
                #endregion
            }
            catch (Exception rr)
            {

                MessageBox.Show("hata" + rr.Message);
            }
        }

        void griddoldur()
        {
            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select * From tbl_BileterSatis", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kayıtlar");
            Grdoldur.DataSource = ds.Tables["kayıtlar"];
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            Color[] c = { Color.SeaShell, Color.WhiteSmoke, Color.Red };

            label13.BackColor = c[rand.Next(2, c.Length)];

            {

                label13.Text = label13.Text.Substring(1) + label13.Text.Substring(0, 1);

            }
        }

        private void BiletSatForm_Load(object sender, EventArgs e)
        {
            Koltuk_kontrol();
            timer1.Start();
            griddoldur();
            // checkBox10.BackColor = Color.Red;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Koltuk_kontrol();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                checkBox1.BackColor = Color.Red;
                textBox2.Text = "1";
            }
            else
            {
                checkBox1.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.BackColor = Color.Red;
                textBox2.Text = "2";
            }
            else
            {
                checkBox2.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox3.BackColor = Color.Black;
                textBox2.Text = "3";
            }
            else
            {
                checkBox3.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox4.BackColor = Color.Black;
                textBox2.Text = "4";
            }
            else
            {
                checkBox4.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox5.BackColor = Color.Black;
                textBox2.Text = "5";
            }
            else
            {
                checkBox5.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox6.BackColor = Color.Black;
                textBox2.Text = "6";
            }
            else
            {
                checkBox6.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox7.BackColor = Color.Black;
                textBox2.Text = "7";
            }
            else
            {
                checkBox7.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox8.BackColor = Color.Black;
                textBox2.Text = "8";
            }
            else
            {
                checkBox8.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox9.BackColor = Color.Black;
                textBox2.Text = "9";
            }
            else
            {
                checkBox9.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox10.BackColor = Color.Black;
                textBox2.Text = "10";
            }
            else
            {
                checkBox10.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                checkBox11.BackColor = Color.Black;
                textBox2.Text = "11";
            }
            else
            {
                checkBox11.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                checkBox12.BackColor = Color.Black;
                textBox2.Text = "12";
            }
            else
            {
                checkBox12.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                checkBox13.BackColor = Color.Black;
                textBox2.Text = "13";
            }
            else
            {
                checkBox13.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                checkBox14.BackColor = Color.Black;
                textBox2.Text = "14";
            }
            else
            {
                checkBox14.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                checkBox15.BackColor = Color.Black;
                textBox2.Text = "15";
            }
            else
            {
                checkBox15.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                checkBox16.BackColor = Color.Black;
                textBox2.Text = "16";
            }
            else
            {
                checkBox16.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                checkBox17.BackColor = Color.Black;
                textBox2.Text = "17";
            }
            else
            {
                checkBox17.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                checkBox18.BackColor = Color.Black;
                textBox2.Text = "18";
            }
            else
            {
                checkBox18.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                checkBox19.BackColor = Color.Black;
                textBox2.Text = "19";
            }
            else
            {
                checkBox19.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                checkBox20.BackColor = Color.Black;
                textBox2.Text = "20";
            }
            else
            {
                checkBox20.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                checkBox21.BackColor = Color.Black;
                textBox2.Text = "21";
            }
            else
            {
                checkBox21.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                checkBox22.BackColor = Color.Black;
                textBox2.Text = "22";
            }
            else
            {
                checkBox22.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                checkBox23.BackColor = Color.Black;
                textBox2.Text = "23";
            }
            else
            {
                checkBox23.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                checkBox24.BackColor = Color.Black;
                textBox2.Text = "24";
            }
            else
            {
                checkBox24.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked == true)
            {
                checkBox25.BackColor = Color.Black;
                textBox2.Text = "25";
            }
            else
            {
                checkBox25.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked == true)
            {
                checkBox26.BackColor = Color.Black;
                textBox2.Text = "26";
            }
            else
            {
                checkBox26.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {
                checkBox27.BackColor = Color.Black;
                textBox2.Text = "27";
            }
            else
            {
                checkBox27.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {
                checkBox28.BackColor = Color.Black;
                textBox2.Text = "28";
            }
            else
            {
                checkBox28.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                checkBox29.BackColor = Color.Black;
                textBox2.Text = "29";
            }
            else
            {
                checkBox29.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                checkBox30.BackColor = Color.Black;
                textBox2.Text = "30";
            }
            else
            {
                checkBox30.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                checkBox33.BackColor = Color.Black;
                textBox2.Text = "33";
            }
            else
            {
                checkBox33.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked == true)
            {
                checkBox34.BackColor = Color.Black;
                textBox2.Text = "34";
            }
            else
            {
                checkBox34.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked == true)
            {
                checkBox31.BackColor = Color.Black;
                textBox2.Text = "31";
            }
            else
            {
                checkBox31.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked == true)
            {
                checkBox32.BackColor = Color.Black;
                textBox2.Text = "32";
            }
            else
            {
                checkBox32.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked == true)
            {
                checkBox37.BackColor = Color.Black;
                textBox2.Text = "37";
            }
            else
            {
                checkBox37.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked == true)
            {
                checkBox38.BackColor = Color.Black;
                textBox2.Text = "38";
            }
            else
            {
                checkBox38.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox39.Checked == true)
            {
                checkBox39.BackColor = Color.Black;
                textBox2.Text = "39";
            }
            else
            {
                checkBox39.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked == true)
            {
                checkBox40.BackColor = Color.Black;
                textBox2.Text = "40";
            }
            else
            {
                checkBox40.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked == true)
            {
                checkBox41.BackColor = Color.Black;
                textBox2.Text = "41";
            }
            else
            {
                checkBox41.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked == true)
            {
                checkBox42.BackColor = Color.Black;
                textBox2.Text = "42";
            }
            else
            {
                checkBox42.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox43.Checked == true)
            {
                checkBox43.BackColor = Color.Black;
                textBox2.Text = "43";
            }
            else
            {
                checkBox43.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked == true)
            {
                checkBox44.BackColor = Color.Black;
                textBox2.Text = "44";
            }
            else
            {
                checkBox44.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox45.Checked == true)
            {
                checkBox45.BackColor = Color.Black;
                textBox2.Text = "45";
            }
            else
            {
                checkBox45.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked == true)
            {
                checkBox46.BackColor = Color.Black;
                textBox2.Text = "46";
            }
            else
            {
                checkBox46.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked == true)
            {
                checkBox35.BackColor = Color.Black;
                textBox2.Text = "35";
            }
            else
            {
                checkBox35.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked == true)
            {
                checkBox36.BackColor = Color.Black;
                textBox2.Text = "36";
            }
            else
            {
                checkBox36.BackColor = Color.White;
                textBox2.Text = " ";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "İstanbul (A) Şubesi" && comboBox3.Text== "İzmir")
            {
                textBox10.Text="100";
            }
            else if(comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Aydın")
            {
                textBox10.Text = "150";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Ankara")
            {
                textBox10.Text = "200";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Tokat")
            {
                textBox10.Text = "250";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Ordu")
            {
                textBox10.Text = "350";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Sinop")
            {
                textBox10.Text = "180";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Trabzon")
            {
                textBox10.Text = "400";
            }
            if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "İzmir")
            {
                textBox10.Text = "180";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Aydın")
            {
                textBox10.Text = "250";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Ankara")
            {
                textBox10.Text = "100";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Tokat")
            {
                textBox10.Text = "350";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Ordu")
            {
                textBox10.Text = "150";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Sinop")
            {
                textBox10.Text = "200";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Trabzon")
            {
                textBox10.Text = "90";
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "İzmir")
            {
                textBox10.Text = "100";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Aydın")
            {
                textBox10.Text = "150";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Ankara")
            {
                textBox10.Text = "200";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Tokat")
            {
                textBox10.Text = "250";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Ordu")
            {
                textBox10.Text = "350";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Sinop")
            {
                textBox10.Text = "180";
            }
            else if (comboBox1.Text == "İstanbul (A) Şubesi" && comboBox3.Text == "Trabzon")
            {
                textBox10.Text = "400";
            }
            if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "İzmir")
            {
                textBox10.Text = "180";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Aydın")
            {
                textBox10.Text = "250";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Ankara")
            {
                textBox10.Text = "100";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Tokat")
            {
                textBox10.Text = "350";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Ordu")
            {
                textBox10.Text = "150";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Sinop")
            {
                textBox10.Text = "200";
            }
            else if (comboBox1.Text == "İstanbul (B) Şubesi" && comboBox3.Text == "Trabzon")
            {
                textBox10.Text = "90";
            }
        }
    }
}
