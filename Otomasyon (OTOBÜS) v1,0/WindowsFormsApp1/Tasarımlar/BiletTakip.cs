using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;

namespace WindowsFormsApp1
{
    public partial class BiletTakip : Form
    {
        public BiletTakip()
        {
            InitializeComponent();
        }

        private void BiletTakip_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand com = new SqlCommand();
            DataSet ds = new DataSet();
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection("server=DESKTOP-8JE6KH6\\SQLEXPRESS; Initial Catalog=MertTT;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select * From tbl_BileterSatis where Tarih= '" + dateTimePicker1.Text + "' ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "otobüs");
            dataGridView3.DataSource = ds.Tables["otobüs"];
            con.Close();
        }
    }
}
