namespace MuratY10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int parola = 123456;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ertuðrul")
            {
                label2.Text = "Hoþ Geldiniz";
                if (textBox2.Text == Convert.ToString(parola))
                {
                    label2.Text = "Hoþ Geldiniz";
                }
                else
                {
                    label2.Text = "Hatalý Kullanýcý adý veya parola";
                }
            }
            else
            {
                label2.Text = "Hatalý Kullanýcý adý veya parola";
            }
        }
    }
}   