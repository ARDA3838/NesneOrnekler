﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Goldsoru10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Lütfen ilk önce ekle butonuna tıklayınız", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 5 == 0)
                    {
                        listBox4.Items.Add(listBox1.Items[i]);
                    }
                    else if (Convert.ToInt32(listBox1.Items[i]) % 3 == 0)
                    {
                        listBox3.Items.Add(listBox1.Items[i]);
                    }
                    else if (Convert.ToInt32(listBox1.Items[i]) % 2 == 0)
                    {
                        listBox2.Items.Add(listBox1.Items[i]);
                    }
                    else
                    {
                        listBox5.Items.Add(listBox1.Items[i]);
                    }
                }
            }
        }
    }
}


