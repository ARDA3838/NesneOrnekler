﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim;
            bool cevap1, cevap2;
            secim = listBox1.SelectedItem.ToString();
            cevap1 = radioButton1.Checked;
            cevap2 = radioButton2.Checked;
            if (cevap1 == true && (secim == "MP4" || secim == "MOV"))
            {
                MessageBox.Show("CEVABINIZ DOĞRU :)");
            }
            if (cevap1 == false && (secim == "MP4" || secim == "MOV"))
            {
                MessageBox.Show("CEVABINIZ YANLIŞTIR :(");
            }
            if (cevap2 == true && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("CEVANINIZ DOĞRU :)");
            }
            if (cevap2 == false && (secim == "JPG" || secim == "PNG"))
            {
                MessageBox.Show("CEVABINI YANLIŞ :(");
            }
        }
    }
}
