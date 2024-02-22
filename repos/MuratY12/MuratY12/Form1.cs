namespace MuratY12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text= sayac.ToString();
            if (sayac == 20)
            {
                this.BackColor = Color.YellowGreen;
            }
            if (sayac == 40)
            {
                this.BackColor = Color.Violet;
                sayac = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }
    }
}