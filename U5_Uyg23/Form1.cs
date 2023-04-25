using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Şehirler> listSehirler = new List<Şehirler>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Şehirler şehir = new Şehirler();
            şehir.Plaka = txtPlaka.Text;
            şehir.SehirAdi = txtŞehir.Text;
            listSehirler.Add(şehir);
            Bagla();
        }

        private void Bagla()
        {
            cbSehirler.DataSource = null;
            cbSehirler.DataSource = listSehirler;
            cbSehirler.DisplayMember = "Şehir Adı";
            cbSehirler.ValueMember = "Plaka";
        }
    }
}
