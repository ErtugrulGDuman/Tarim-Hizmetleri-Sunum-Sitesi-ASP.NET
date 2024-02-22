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
    public partial class FrmTekBoyutluDizi : Form
    {
        public FrmTekBoyutluDizi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string[] isimListesi = new string[10];
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            isimListesi[a] = textBox1.Text;
            listBox1.Items.Add(isimListesi[a]);
            a = a + 1;
            if (a == 10) 
            { 
                MessageBox.Show("En fazla 10 kişi eklenebilir");
                BtnEkle.Enabled = false;
            }
            progressBar1.Value = progressBar1.Value + progressBar1.Step;
            if(textBox1.Text == "")
            {
                MessageBox.Show("Lütfen isim giriniz !!!");
                progressBar1.Value = 0;
            }
        }

        private void FrmTekBoyutluDizi_Load(object sender, EventArgs e)
        {

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            BtnEkle.Enabled=true;
            a = 0;
            progressBar1.Value = 0;
            listBox2.Items.Clear();
            textBox2.Clear();
        }
        private void çokBoyutluDiziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCokBoyutluDizi fr = new FrmCokBoyutluDizi();
            fr.ShowDialog();
            this.Close();
        }

        private void değerDöndürenMetotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDegerDonenMetot fr = new FrmDegerDonenMetot();
            fr.ShowDialog();
            this.Close();
        }

        private void değerDönmeyenMetotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDegerDonmeyenMetot fr = new FrmDegerDonmeyenMetot();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            listBox2.Items.Add(isimListesi[a]);
        }
    }
}
