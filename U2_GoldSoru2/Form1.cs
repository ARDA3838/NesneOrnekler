using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                pictureBox1.Left = pictureBox1.Left + random.Next(1, 10);
                pictureBox2.Left = pictureBox2.Left + random.Next(1, 10);
                Thread.Sleep(300);
            }

       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
