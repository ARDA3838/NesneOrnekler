﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("form2 yükleniyor . . .");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("form2 kapanıyor . . .");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("form2 kapandı.");
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("form2'nin click olayı çalışıyor");
        }
    }
}
