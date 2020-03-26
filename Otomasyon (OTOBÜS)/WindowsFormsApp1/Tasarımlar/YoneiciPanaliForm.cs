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
    public partial class YöneticiPaneliForm : Form
    {
        public YöneticiPaneliForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void YöneticiPaneliForm_Load(object sender, EventArgs e)
        {
           
            label4.Text = KullanıcıGirişForm.mert;
            label2.Text= DateTime.Now.ToString();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıKayıtForm kyt = new KullanıcıKayıtForm();
           // this.Hide();
            kyt.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KayıtSilmeForm SİL = new KayıtSilmeForm();
            SİL.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 otobus = new Form7();
            otobus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ıptal = new Form2();
            ıptal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BiletSatForm al = new BiletSatForm();
            al.Show();
        }
    }
}
