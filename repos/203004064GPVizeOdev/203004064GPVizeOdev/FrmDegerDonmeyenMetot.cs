using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _203004064GPVizeOdev
{
    public partial class FrmDegerDonmeyenMetot : Form
    {
        public FrmDegerDonmeyenMetot()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int count = 5;
        int sayi;
        void asagıHata()
        {
            MessageBox.Show("Aşağı");
        }
        void yukariHata()
        {
            MessageBox.Show("Yukarı");
        }
        void tebrik()
        {
            MessageBox.Show("Tebrikler..:)");
        }
        void bitis()
        {
            MessageBox.Show("GAME OVER!!!!!");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(1,10);
            MessageBox.Show("1 ile 10 Arasında Bir Sayı Tuttum");
            button1.Enabled = true;
            count = 5;
            textBox1.Clear();
            progressBar1.Value = 0;
            label4.Text = "5";
            button1.Enabled=true;   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(textBox1.Text);
            if (tahmin < sayi)
            {
                yukariHata();
                count = count - 1;
            }
            else if (tahmin > sayi)
            {
                asagıHata();
                count = count - 1;
            }
            else
            {
                tebrik();
                progressBar1.Value=0;
                button1.Enabled = false;
            }

            if (count == 0)
            {
                bitis();
                button1.Enabled = false;
                progressBar1.Value = 0;
            }
            progressBar1.Value = progressBar1.Value + progressBar1.Step;
            label4.Text=Convert.ToString(count);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tekBoyutluDiziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTekBoyutluDizi fr = new FrmTekBoyutluDizi();
            fr.ShowDialog();
            this.Close();
        }

        private void çokBoyutluDiziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCokBoyutluDizi fr = new FrmCokBoyutluDizi();
            fr.ShowDialog();
            this.Close();
        }

        private void değerDönenMetotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDegerDonenMetot fr = new FrmDegerDonenMetot();
            fr.ShowDialog();
            this.Close();
        }

        private void aşırıYüklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsiriYukleme fr = new FrmAsiriYukleme();
            fr.ShowDialog();
            this.Close();
        }

        private void özyinelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOzyineleme fr = new FrmOzyineleme();
            fr.ShowDialog();
            this.Close();
        }

        private void FrmDegerDonmeyenMetot_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}