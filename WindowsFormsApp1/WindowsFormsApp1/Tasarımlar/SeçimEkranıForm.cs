﻿using System;
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
    public partial class SeçimEkranıForm : Form
    {
        public SeçimEkranıForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            //this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıGirişForm frm = new KullanıcıGirişForm();
            frm.Show();
         


        }

        private void SeçimEkranıForm_Load(object sender, EventArgs e)
        {
            
        }

      
    }
}
