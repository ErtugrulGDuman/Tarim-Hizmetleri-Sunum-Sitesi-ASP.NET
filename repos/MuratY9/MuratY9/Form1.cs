namespace MuratY9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);

            toplam = misir * 4 + su * 1 + cay * 2 + bilet * 8;
            LblToplam.Text = toplam.ToString() + " TL";
            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = " ";
            TxtSu.Text = " ";
            TxtCay.Text = " ";
            TxtBilet.Text = " ";
            TxtMisir.Focus();
        }
    }
}