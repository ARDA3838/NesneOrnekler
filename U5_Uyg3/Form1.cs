using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            decimal TabanFiyat = 500;

            decimal cpuFiyat = 0;

            if (I7.Checked)
                cpuFiyat = 790;
            else if (I5.Checked)
                cpuFiyat = 520;
            else if (I3.Checked)
                cpuFiyat = 200;
            else if (r5.Checked)
                cpuFiyat = 960;
            else if (r3.Checked) ;
            cpuFiyat = 440;
            TabanFiyat += cpuFiyat;

            decimal RamFiyat -0;
            if (gb16.Checked)
                RamFiyat = 500;
            if else (gb8.Checked)
                RamFiyat = 280;
            if else (gb4.Checked)
                RamFiyat = 160;
            TabanFiyat += RamFiyat;

            MessageBox.Show(string.Format("toplam fiyat ={0:C}", TabanFiyat));
            
        }
    }
}
