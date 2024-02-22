namespace CanSıkıntısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = rnd.Next(10);
            textBox2.Text = sayi.ToString();

            if (Convert.ToInt16(textBox1.Text) == Convert.ToInt16(textBox2.Text))
            {
                label3.Text = "TEBRİKLER DOĞRU CEVAP";
            }
            if(Convert.ToInt16(textBox1.Text) < Convert.ToInt16(textBox2.Text))
            {
                label3.Text = "YUKARI";
            }
            if(Convert.ToInt16(textBox1.Text) > Convert.ToInt16(textBox2.Text))
            {
                label3.Text = "AŞAĞI";
            }
        }
    }
}