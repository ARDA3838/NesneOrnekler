using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();
        private void txtNumara_Validating(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumara.Text, out int sonuc))
            {
                ep.SetError(txtNumara, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtNumara, "numara giriş hatalı");
            }
        }

        private void txtAdSoyAd_Validating(object sender, EventArgs e)
        {

            if (txtAdSoyAd.Text == "") ;
            {
                e.Cancel = true;
                ep.SetError(txtAdSoyAd, "ad ve soyad giriniz");

            }
            else
            {
                ep.SetError(txtAdSoyAd, "");
            }
        }
        private void txtDersNotu_Validating(object sender, EventArgs e)
        {
            int dersNotu;
            if(int.TryParse(txtDersNotu.Text,out dersNotu))
            {
                e.Cancel = true;
                ep.SetError(txtDersNotu, "0 - 100 arasında değer giriniz.");
            }
            else
            {
                ep.SetError(txtDersNotu, "");
            }
            else
            {
                e.Cancel = true;
                ep.SetError(txtDersNotu, "Sayısal değer giriniz.");
            }
        }
    }
}
