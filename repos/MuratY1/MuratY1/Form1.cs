namespace MuratY1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olm T�klamasanaa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "DUMAN";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Ertu�rul";
            label7.Text = "Duman";
            label8.Text = "��renci";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Y�netim Bil�im Sistemleri";
            label9.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text= textBox2.Text;
            label11.Text= textBox3.Text;
        }
    }
}