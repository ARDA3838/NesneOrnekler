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


    public partial class Ogrenciislemleri : Form
    {
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutsatiri;
        private void Kitapislemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutsatiri = "select * From ogrenci";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                GridOgrenci.DataSource = dataTable;
                GridOgrenci.Columns["ogrenci_no"].HeaderText = "öğrenci Numarası";
                GridOgrenci.Columns["ad"].HeaderText = "Ad";
                GridOgrenci.Columns["soyad"].HeaderText = "Soyad";
                GridOgrenci.Columns["sinif"].HeaderText = "Sınıf";
                GridOgrenci.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                GridOgrenci.Columns["telefon"].HeaderText = "Telefon";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

