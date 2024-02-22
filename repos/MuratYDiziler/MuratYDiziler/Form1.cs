namespace MuratYDiziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Kisiler = { "Ali", "Ahmet", "Mehmet" };
            foreach(string K in Kisiler)
            {
                MessageBox.Show(K);
            }
        }
    }
}