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
    public partial class Turislemeleri : Form
    {
        public Turislemeleri()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veriTabani = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;
        private void Turislemeleri_Load(object sender, EventArgs e)
        {
            TurleriListele();
        }
        private void TurleriListele()
        {
            try
            {
                baglanti = veriTabani.baglan();
                komutSatiri = "Select * from kitap_turleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridTur.DataSource = dataTable;
                dataGridTur.Columns["tur_id"].HeaderText = "ID";
                dataGridTur.Columns["tur_id"].Width = 100;
                dataGridTur.Columns["tur_adi"].HeaderText = "Tür Adı";
                dataGridTur.Columns["tur_adi"].Width = 300;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Yükleme Hatası oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                komut = new MySqlCommand();
                komut.Connection = (MySqlConnection)baglanti;
                komut.CommandText = "INSERT INTO kitap_turleri (tur_adi) VALUES(@tur_adi)";
                komut.Parameters.AddWithValue("@tur_adi", txtTuradi.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTuradi.Clear();
                MessageBox.Show("islem basarıl", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable DataTable()
        {
            throw new NotImplementedException();
        }

        private void dataGridTur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTuradi.Text = dataGridTur.CurrentRow.Cells["tur_adi"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM kitap_turleri WHERE tur_adi = @tur_adi";

                komut.Parameters.AddWithValue("tur_adi", dataGridTur.CurrentRow.Cells["tur_adi"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTuradi.Clear();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE kitap_turleri set tur_adi=@tur_adi where tur_adi=@tur_adi";
                komut.Parameters.AddWithValue("@tur_adi", int.Parse(dataGridTur.CurrentRow.Cells["tur_adi"].Value.ToString()));

                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTuradi.Clear();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
