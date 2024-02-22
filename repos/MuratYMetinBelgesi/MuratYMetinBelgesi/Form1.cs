using System.IO;



namespace MuratYMetinBelgesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaAdý, dosyaYolu;
        StreamWriter sw;

        private void button2_Click(object sender, EventArgs e)
        {
            dosyaAdý=textBox2.Text;
            sw = File.CreateText(dosyaYolu + "\\" + dosyaAdý + ".txt");
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) ;
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyaYolu;
            }
        }
    }
}