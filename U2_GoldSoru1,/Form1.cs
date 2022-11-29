using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int i = 0; 1 < L1.Items.Count; i++)
            { 
                MessageBox.Show("lütfen ilk önce doldur butonuna tıklayınız.", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < L1.Items.Count; i++)
                {
                    if (Convert.ToInt32(L1.Items[i]) % 5 == 0)
                    {
                        L4.Items.Add(L1.Items[i]);
                    }
                    else if (Convert.ToInt32(L1.Items[i]) % 3 ==0)
                    {
                        L3.Items.Add(L1.Items[i]);
                    }
                    else if (Convert.ToInt32(L1.Items[i])%2==0)
                    {
                        L2.Items.Add(L1.Items[i]);
                    }
                    else
                    {
                        L5.Items.Add(L1.Items[i]);
            }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

