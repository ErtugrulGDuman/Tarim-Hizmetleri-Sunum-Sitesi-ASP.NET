namespace MuratYFormArasıTasima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.mesaj = textBox1.Text;
            form2.Show();
            this.Hide();

        }
    }
}