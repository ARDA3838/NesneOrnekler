﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList sehirler = new ArrayList();
        private void button_ekle_Click(object sender, EventArgs e)
        {
            {
                sehirler.Add(txt_SehirAdi.Text);

            }
        }

        private void button_listele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sehirler.Count; i++)
            {
            listBox1.Items.Add(sehirler[i]);
            }
        }
    }
}
