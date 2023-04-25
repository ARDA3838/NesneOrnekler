using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList kaynakVeri = new ArrayList();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.KitapAdi = txtAd.Text;
            kitap.KitapTuru = txtTür.Text;
            kitap.KitapYazari = txtYazar.Text;
            kaynakVeri.Add(kitap);
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            listeVeri.DataSource = null;
            listeVeri.DataSource = kaynakVeri;
            listeVeri.DisplayMember = "kitapAdi";
        }
    }
}
