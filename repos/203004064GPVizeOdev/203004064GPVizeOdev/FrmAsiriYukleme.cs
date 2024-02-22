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
    public partial class FrmAsiriYukleme : Form
    {
        public FrmAsiriYukleme()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FrmAsiriYukleme_Load(object sender, EventArgs e)
        {
        }
        public static int ortalama (int sayi1, int sayi2)
        {
            int a = sayi1 + sayi2;
            return a / 2;
        }
        public static int ortalama(int sayi1, int sayi2, int sayi3)
        {
            int a = sayi1 + sayi2 + sayi3;
            return a / 3;
        }
        public static int ortalama(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            int a = sayi1 + sayi2 + sayi3 + sayi4;
            return a / 4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(ortalama(Convert.ToInt32(textBox1.Text), 
                Convert.ToInt32(textBox2.Text)));
            label3.Text = Convert.ToString(ortalama(Convert.ToInt32(textBox1.Text), 
                Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
            label4.Text = Convert.ToString(ortalama(Convert.ToInt32(textBox1.Text),
                Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label2.Text = "1. ve 2.";
            label3.Text = "1. 2. ve 3.";
            label4.Text = "1. 2. 3. ve 4.";
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

        private void değerDönmeyenMetotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDegerDonmeyenMetot fr = new FrmDegerDonmeyenMetot();
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