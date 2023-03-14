using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "form sınıfı uygulaması 2";
            this.BackColor = Color.Green;
            this.ForeColor = Color.Black;
            this.Size = new Size(150, 300);

            lbAdSoyad.Text = "adınız?";
            lbAdSoyad.Location = new Point(10, 10);
            lbAdSoyad.Size = new Size(65, 15);
            lbAdSoyad.ForeColor = Color.White;

            txtAdSoyad.Location = new Point(75, 10);
            txtAdSoyad.Size = new Size(150, 15);
            txtAdSoyad.TabIndex = 1;

            btnGiris.Text = "Tıkla";
            btnGiris.Location = new Point(100, 60);
            btnGiris.Size = new Size(100, 30);
            btnGiris.ForeColor = Color.White;
            btnGiris.BackColor = Color.Black;
            btnGiris.TabIndex = 2;

            txtAdSoyad.KeyPress += TxtAdSoyad_KeyPress;
            btnGiris.Click += BtnGiris_Click;

            this.Controls.Add(lbAdSoyad);
            this.Controls.Add(txtAdSoyad);
            this.Controls.Add(btnGiris);
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("merhaba" + txtAdSoyad.Text);
        }
    }
}
