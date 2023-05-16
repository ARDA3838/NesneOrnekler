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


    public partial class formOgrenciler : Form
    {
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutsatiri;

        private void formOgrenciler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutsatiri = "select * From ogrenciler";
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "INSERT INTO ogrenciler (ogrenci_no, ad, soyad, sinif, cinsiyet, telefon) VAUES(@no, @ad, @soyad, @cinisyet, @telefon)";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(txtOkulno.Text));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(cboSinif.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", cboCinsiet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı", "Messaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtOkulno.Clear();
            txtTelefon.Clear();
        }

        private void GridOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtOkulno.Text = GridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString();
                txtAd.Text = GridOgrenci.CurrentRow.Cells["ad"].Value.ToString();
                txtSoyad.Text = GridOgrenci.CurrentRow.Cells["soyad"].Value.ToString();
                txtTelefon.Text = GridOgrenci.CurrentRow.Cells["telefon"].Value.ToString();
                cboCinsiet.SelectedItem = GridOgrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();
                cboSinif.SelectedItem = GridOgrenci.CurrentRow.Cells["sinif"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "DELETE FROM ogrenciler WHERE ogrenci_no = @no";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@no", GridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "UPDATE ogrenciler SET ad=@ad, soyad=@soyad, sinif=@sinif, cinsiyet=@cinsiyet, telefon=@telefon where ogrenci_no=@no";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(GridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString()));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(cboSinif.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAramaOgrenci_TextChanged(object sender, EventArgs e)
        {
            OgrenciArama(txtAramaOgrenci.Text);
        }

        private void OgrenciArama(string aranacakKelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "Select * From ogrenciler Where ad LİKE'" + aranacakKelime + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                GridOgrenci.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

