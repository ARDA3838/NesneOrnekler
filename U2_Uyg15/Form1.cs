using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secim = listBox1.SelectedItem.ToString();
            if (secim == "mause" || secim == "klavye" || secim == "kamera" || secim == "tarayıcı")
            {
                MessageBox.Show("bu parça, giriş birimidir!");
            }
            if (secim == "yazıcı" || secim == "projeksion" || secim == "hoperlör")
            {
                MessageBox.Show("bu parça çıkış birimidir!");
            }
        }
    }
}
