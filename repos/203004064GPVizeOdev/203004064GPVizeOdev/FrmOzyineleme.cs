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
    public partial class FrmOzyineleme : Form
    {
        public FrmOzyineleme()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public long Faktoriyel(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            return i * Faktoriyel(i - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int girilenSayi = Convert.ToInt32(textBox1.Text);
            long sonuc = Faktoriyel(girilenSayi);
            label1.Text= sonuc.ToString();
            listBox1.Items.Add(textBox1.Text + "! = " + sonuc);
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void FrmOzyineleme_Load(object sender, EventArgs e)
        {
        
        }
    }
}
