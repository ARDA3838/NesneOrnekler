namespace U2_SS_55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boy, kilo, sonuc;
            boy = Convert.ToInt32(textBox1.Text);
            kilo = Convert.ToInt32(textBox2.Text);
            sonuc = boy - ((boy / 4) + 50);
            if (kilo > sonuc)
            {
                label1.Text = "KÝLOLU";
            }
            else
            {
                label1.Text = "ZAYIF";
            }
        }
    }
}