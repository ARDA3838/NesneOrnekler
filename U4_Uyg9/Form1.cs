using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] dizi;
        int diziSayisi;
        int sutunSayısı;
        private void button_DiziOlustur_Click(object sender, EventArgs e)
        {
            int RasgeleEnDusuk = int.Parse(textBox_enDusuk.Text);
            int RasgeleEnBuyuk = int.Parse(textBox_enBuyuk.Text);
            diziSayisi = int.Parse(textBox_diziSayisi.Text);
            sutunSayısı = int.Parse(textBox_sutunSayisi.Text);
            dizi = new int[diziSayisi, sutunSayısı];
            Random random = new Random();
            for (int x = 0; x < sutunSayısı; x++)
            {
                dizi[x, y] = random.Next(RasgeleEnDusuk, RasgeleEnBuyuk);
            }
        }

        private void button_DiziGoster_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < diziSayisi; x++)
            {
                for (int y= 0; y< sutunSayısı; x++)
                {
                    listBox_DiziGöster.Items.Add(x + "," + y + "==>" + dizi[x, y]);
                }
            }
        }
    }
}
