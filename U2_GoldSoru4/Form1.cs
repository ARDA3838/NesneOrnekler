using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
        private void button1_Click_1(object sender, EventArgs e)
        {
            int i1, i2;
            try
            {
                i1 = Convert.ToInt32(textBox1.Text);
                i2 = Convert.ToInt32(textBox2.Text);
                if (i1 > i2)
                {
                    MessageBox.Show("küçük sayıyı küçük olarakgiriniz");
                }
                else
                {
                    for (int i = i1; i < i2; i++)
                    {
                        if (i % 2 == 0)
                        {
                            listBox2.Items.Add(i);
                        }
                        else
                        {
                            listBox1.Items.Add(i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("en büyük sayı bölümüne büyükbir sayı giriniz lütfen !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("lütfen bir sayı giriniz !");
            
            }
        }   
    }
}
