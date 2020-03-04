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
    public partial class KayıtSilmeForm : Form
    {
        public KayıtSilmeForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection("server=MERT-BILGISAYAR\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Delete tbl_kullaniciKayit where  KADI='" + textBox1.Text + "' AND TCNO='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Kullanıcı Silinmiştir.");





            }
            else
            {
                MessageBox.Show("HATA.");
            }
        }
    }
}
