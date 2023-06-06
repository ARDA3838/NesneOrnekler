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

namespace PROJE_ÖDEVİ
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        DataTable tablo = new DataTable();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutsatiri;

        private void Form3_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                baglanti = tablo.baglan();
                komutsatiri = "Select * Form randevu";
                MySqlDataAdapter dataAdapter = MySqlDataAdapter (komutsatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["tc"].HeaderText = "Tc";
                dataGridView1.Columns["ad"].HeaderText = "Ad";
                dataGridView1.Columns["soyad"].HeaderText = "Soyad";
                dataGridView1.Columns["telefon"].HeaderText = "Telefon";
                dataGridView1.Columns["ay_gün_saat"].HeaderText = "Ay Gün Saat";
                dataGridView1.Columns["branş_bölüm"].HeaderText = "Branş Bölüm";
                dataGridView1.Columns["hastane"].HeaderText = "Hastane";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private MySqlDataAdapter MySqlDataAdapter(string komutsatiri, MySqlConnection baglanti)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "INSERT INTO randevu(tc,ad,soyad,telefon,ay_gün_saat,branş_bölüm,hastane)VALUES(@tc, @ad, @soyad, @telefon, @ay_gün_saat, @branş_bölüm, @hastane)";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@tc", int.Parse(textBox1.Text));
                komut.Parameters.AddWithValue("@ad", textBox2.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", int.Parse(textBox3.Text));
                komut.Parameters.AddWithValue("@branş_bölüm", comboBox1.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@hastane", comboBox2.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@ay_gün_saat", int.Parse(dateTimePicker1.Text));

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtSoyad.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
                txtSoyad.Text = dataGridView1.CurrentRow.Cells["soyad"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells["branş_bölüm"].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells["hastane"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["ay_gün_saat"].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("hata oluştu", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State!=ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutsatiri = "DELETE FROM randevu WHERE tc = @tc";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata ouştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open);
                {
                    baglanti.Open();
                }
                komutsatiri = "UPDATE hasta_katıt SET ad=@ad, soyad=@soyad, telefon=@telefon, branş_bölüm=@branş_bölüm, hastane=@hastane, ay_gün_saat=@ay_gün_saat where tc=@tc";
                komut = new MySqlCommand(komutsatiri, baglanti);
                komut.Parameters.AddWithValue("@tc", int.Parse(dataGridView1.CurrentRow.Cells["tc"].Value.ToString()));
                komut.Parameters.AddWithValue("@ad", textBox2.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", int.Parse(textBox3.Text));
                komut.Parameters.AddWithValue("@branş_bölüm", comboBox1.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@hastane", comboBox2.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@ay_gün_saat", int.Parse(dateTimePicker1.Text));

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

