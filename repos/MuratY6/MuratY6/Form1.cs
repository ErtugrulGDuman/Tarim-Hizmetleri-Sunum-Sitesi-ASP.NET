namespace MuratY6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + 
                " - " + comboBox2.Text + 
                " Tarih: " + dateTimePicker1.Text + 
                " Saat: " + maskedTextBox1.Text + 
                " Yolcu Bilgileri ~ Ad : " + textBox1.Text + 
                " TC: " + maskedTextBox2.Text + " Telefon: " + maskedTextBox3);
            MessageBox.Show("Yolcu Kydý Yapýldý");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
        }
    }
}