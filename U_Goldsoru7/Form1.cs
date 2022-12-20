using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U_Goldsoru7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random;
            random = new Random();
            for (int i = 0; i < 20; i++)
            {
                listBox1.Items.Add(random.Next(1, 100));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int enBuyuk = Convert.ToInt32(listBox1.Items[0]);
            int enKucuk = Convert.ToInt32(listBox1.Items[0]);
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int sayi = Convert.ToInt32(listBox1.Items[i]);
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }

                if (sayi < enKucuk)
                {
                    enKucuk = sayi;
                }
            }
            label3.Text = "Listedeki En Büyük Sayı =" + enBuyuk.ToString();
            label4.Text = "Listedeki En Büyük Sayı =" + enKucuk.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random;
            random = new Random();
            for (int i = 0; i < 20; i++)
            {
                listBox1.Items.Add(random.Next(1, 100));
            }
        }
    }
}

