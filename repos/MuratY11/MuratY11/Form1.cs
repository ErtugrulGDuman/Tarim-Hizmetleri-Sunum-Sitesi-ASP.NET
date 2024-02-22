namespace MuratY11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string islem = comboBox1.Text;
            int toplama = Convert.ToInt16(textBox1.Text) + Convert.ToInt16(textBox2.Text);
            int fark = Convert.ToInt16(textBox1.Text) - Convert.ToInt16(textBox2.Text);
            int carpma = Convert.ToInt16(textBox1.Text) * Convert.ToInt16(textBox2.Text);
            int bolme = Convert.ToInt16(textBox1.Text) / Convert.ToInt16(textBox2.Text);
            switch (islem)
            {
                case "+": label3.Text =  Convert.ToString(toplama); break;
                case "-": label3.Text = Convert.ToString(fark); break;
                case "x": label3.Text = Convert.ToString(carpma); break;
                case "/": label3.Text = Convert.ToString(bolme); break;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}