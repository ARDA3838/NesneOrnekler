﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Goldsoru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi;
        int skor;
        private void button1_Click(object sender, EventArgs e)
        {
            skor = 100;
            label2.Text = "Skor : " + skor.ToString();
            
            button2.Enabled = true;
            
            Random rastgele = new Random();
            sayi = rastgele.Next(101);
            
            MessageBox.Show("Aklımdan Bir Sayı Tuttum.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(textBox1.Text);
            if (tahmin < sayi)
           
            {
                MessageBox.Show("Yukarı");
                skor = skor - 10;
            }

            else if (tahmin > sayi)

            { 
                MessageBox.Show("Aşağı");
                skor = skor - 10;
            }

            else

            {
                MessageBox.Show("Tebrikler..:))");
            }

            if (skor == 0)

            {
                MessageBox.Show("GAME OVER!!!!!");
                button1.Enabled = false;
            }

            label2.Text = "Skor : " + skor.ToString();
            textBox1.Clear();
        }
    }
}
