using MySql.Data.MySqlClient;
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
    public partial class formKitap : Form
    {
        public formKitap()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veriTabani = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutsatiri;
        private void formKitap_Load(object sender, EventArgs e)
        {
            KitapTurYukle();
            KitapListele();

        }

        private void KitapTurYukle()
        {
            try
            {
                baglanti = veriTabani.baglan();
                komutsatiri = "Select * from kitap_turleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
