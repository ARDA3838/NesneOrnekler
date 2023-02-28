using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = textBox1.Text;
                notlar[index] = int.Parse(textBox2.Text);
                index++;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    listBox1.Items.Add(isimler[i] + " > " + notlar[i]);
                }
                int[] sayilar = { 20, 30, 40, 50 };
                foreach (int sayi in sayilar)
                {
                    Console.WriteLine(sayi);
                }
            }
        }

        private void en_yüksek_btn_Click(object sender, EventArgs e)
        {
            int enyüksek = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] > enyüksek)
                {
                    enyüksek = notlar[i];
                }
            }
            textBox_enyüksek.Text = enyüksek.ToString();
        }

        private void en_düşük_btn_Click(object sender, EventArgs e)
        {
            int endüşük = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < endüşük)
                    endüşük = notlar[0];
                {
                    textBox_endüşük.Text = endüşük.ToString();
                }
            }
        }

        private void ortalama_btn_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            textBox_ortalama.Text = ortalama.ToString();
        }
    }
}
