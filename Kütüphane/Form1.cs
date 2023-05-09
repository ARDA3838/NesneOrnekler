using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            Kitapislemleri kitap = new Kitapislemleri();
            kitap.ShowDialog();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            Ogrenciislemleri ogrenci = new Ogrenciislemleri();
            ogrenci.ShowDialog();
        }

        private void btnTur_Click(object sender, EventArgs e)
        {
            Turislemeleri kitapturu = new Turislemeleri();
            kitapturu.ShowDialog();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            OduncKitapislemleri odunc = new OduncKitapislemleri();
            odunc.ShowDialog();
        }
    }
}
