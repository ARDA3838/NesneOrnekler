namespace U2_SS_56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2 ,sayi3;

            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);

            sayi3 = Convert.ToInt32(textBox3.Text);


            if (sayi1 < sayi2)
            {
                MessageBox.Show("1. sayý KÜÇÜKTÜR");
            }
            if (sayi1 < sayi3)
            {
                MessageBox.Show("1. sayý KÜÇÜKTÜR");
            }
            if (sayi2 < sayi1)
            {
                MessageBox.Show("2. sayý KÜÇÜKTÜR");
            }
            if (sayi2 < sayi3)
            {
                MessageBox.Show("2. sayý KÜÇÜKTÜR");
            }
            if (sayi3 < sayi1)
            {
                MessageBox.Show("3. sayý KÜÇÜKTÜR");
            }
            else
            {
                MessageBox.Show("3. sayý KÜÇÜKTÜR");
            }
        }
    }
}