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
            if (textBox1.Text == "Ertu�rul")
            {
                label2.Text = "Ho� Geldiniz";
                if (textBox2.Text == Convert.ToString(parola))
                {
                    label2.Text = "Ho� Geldiniz";
                }
                else
                {
                    label2.Text = "Hatal� Kullan�c� ad� veya parola";
                }
            }
            else
            {
                label2.Text = "Hatal� Kullan�c� ad� veya parola";
            }
        }
    }
}   