﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                anakart.Items.Add("işlemci");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");
            anakart.Items.Add("islemci");

        }
    }
}
