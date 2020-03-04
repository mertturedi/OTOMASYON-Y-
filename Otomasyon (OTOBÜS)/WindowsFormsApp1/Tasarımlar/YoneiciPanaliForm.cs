using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullanıcıKayıtForm kyt = new KullanıcıKayıtForm();
            this.Hide();
            kyt.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KayıtSilmeForm SİL = new KayıtSilmeForm();
            SİL.Show();
        }
    }
}
