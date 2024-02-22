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
    public partial class FrmCokBoyutluDizi : Form
    {
        public FrmCokBoyutluDizi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string[,] isimListesi = new string[5, 2];
        int a = 0;
        int b = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            isimListesi[a, 0] = textBox1.Text;
            listBox1.Items.Add(isimListesi[a, 0]);
            a = a+1;
            if (a == 5) 
            { 
                MessageBox.Show("İlk sütuna en fazla 5 kişi eklenebilir"); 
                button1.Enabled = false;
            }
            progressBar1.Value = progressBar1.Value + progressBar1.Step;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isimListesi[b, 1] = textBox1.Text;
            listBox2.Items.Add(isimListesi[b, 1]);
            b = b+1;
            if (b == 5) 
            { 
                MessageBox.Show("İkinci sütuna en fazla 5 kişi eklenebilir");
                button2.Enabled = false;
            }
            progressBar2.Value = progressBar2.Value + progressBar2.Step;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox3.Text);
            listBox3.Items.Add(isimListesi[x, y]);
        }

        private void FrmCokBoyutluDizi_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            textBox1.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            a=0; b=0;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
        }

        private void tekBoyutluDiziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTekBoyutluDizi fr = new FrmTekBoyutluDizi();
            fr.ShowDialog();
            this.Close();
        }

        private void değerDönenMetotToolStripMenuItem_Click(object sender, EventArgs e)
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
            FrmAsiriYukleme fr =  new FrmAsiriYukleme();
            fr.ShowDialog();
            this.Close();
        }

        private void özyinelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOzyineleme fr = new FrmOzyineleme();
            fr.ShowDialog();
            this.Close();
        }
    }
}