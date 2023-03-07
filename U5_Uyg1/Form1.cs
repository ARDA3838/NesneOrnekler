using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_Uyg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Acept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("enter tuşu çalışıyo");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esc tışu çalışıyo");
        }

        private void btn_ControlBox_Click(object sender, EventArgs e)
        {
            if (this.ControlBox == true)
                this.ControlBox = false;
            else
                this.ControlBox = true;

            
        }

        private void btn_CenterToScreen_Click(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btn_ShowDialog_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
