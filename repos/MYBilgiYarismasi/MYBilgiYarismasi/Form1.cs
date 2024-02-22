namespace MYBilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                Dogru++;
                lblDogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        int SoruNo = 0, Dogru = 0, Yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled= false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                Dogru++;
                lblDogru.Text=Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlis.Text=Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                Dogru++;
                lblDogru.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlis.Text = Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnA.Text;
            if (label4 == label5)
            {
                Dogru++;
                lblDogru.Text=Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlis++;
                lblYanlis.Text=Yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled=false;
            pictureBox1.Visible=false;
            pictureBox2.Visible=false;
            SoruNo++;
            lblSoruNo.Text = SoruNo.ToString();
            if (SoruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet ne zaman ilan edilmiþtir";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }
            if(SoruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz";
                btnA.Text = "Ýzmir";
                btnB.Text = "Balýkesir";
                btnC.Text = "Aydýn";
                btnD.Text = "Manisa";
                label4.Text = "Balýkesir";
            }
            if (SoruNo == 3)
            {
                richTextBox1.Text = "Son Kuþlar hangi yazarýmýza aittir";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreyya";
                btnC.Text = "Atilla Ýlhan";
                btnD.Text = "Reþat Nuri";
                label4.Text = "Sait Faik";
                btnSonraki.Text = "Sonuçlar : ";
            }
            if (SoruNo == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                panel1.Visible = true;
                richTextBox1.Visible = false;
                MessageBox.Show("Doðru :" + Dogru + "Yanlýþ :" + Yanlis);
            } 
        }
    }
}