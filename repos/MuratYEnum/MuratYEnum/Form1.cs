namespace MuratYEnum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler { X, Adana, Adýyaman, Afyon, Aðrý, Amasya, Ankara, Antalya, Artvin, Aydýn }
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);
            sehirler s;
            s = (sehirler)plaka;
            label1.Text = s.ToString();
        }
    }
}