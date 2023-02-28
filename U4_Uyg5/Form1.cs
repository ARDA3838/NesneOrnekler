using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4_Uyg5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] diziOluştur = new int[100];
        int[] diziKopyala = new int[100];

        private void dizioluştur_btn_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            for (int i = 0; i < diziOluştur.Length; i++)
            {
                diziOluştur[i] = rastgele.Next(0, 101);
            }
            for (int i = 0; i < diziOluştur.Length; i++)
            {
                listBox_dizioluştur.Items.Add(diziOluştur[i]);
            }
        }

        private void dizikopyala_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diziKopyala.Length; i++)
            {
                diziKopyala[i] = diziOluştur[i];
            }
            for (int i = 0; i < diziKopyala.Length; i++)
            {
                listBox_dizikopyala.Items.Add(diziKopyala[i]);
            }
        }
    }
}
