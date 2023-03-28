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
        private void Form3_Load(object sender, EventArgs e)
        {         
            
            label14.Enabled = false;

            tablo.Columns.Add("T.C Kimlik No", typeof(string));
            tablo.Columns.Add("Ad Soyad", typeof(string));
            tablo.Columns.Add("Telefon No", typeof(string));
            tablo.Columns.Add("Branş Adı", typeof(string));
            tablo.Columns.Add("Hastane Adı", typeof(string));
            tablo.Columns.Add("Randevu Tarih", typeof(string));
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, comboBox2.Text, dateTimePicker1.Text);
            dataGridView1.DataSource = tablo;
        }

        private void button2_Click(object sender, EventArgs e)
        {        
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz .");
            }
        }
    }
}

