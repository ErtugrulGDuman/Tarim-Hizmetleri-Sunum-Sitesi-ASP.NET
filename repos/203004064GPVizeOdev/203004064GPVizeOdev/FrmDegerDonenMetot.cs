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
    public partial class FrmDegerDonenMetot : Form
    {
        public FrmDegerDonenMetot()
        {
            InitializeComponent();
        }
        private string suvBilgi()
        {
            return "Şehir içi kullanıma uygun dört çeker araç";
        }
        private string hatchbackBilgi()
        {
            return "Arkası kısa ve küt olan araba";
        }
        private string sedanBilgi()
        {
            return "Dört kişilik olan, iki ya da dört kapısı bulunan araç";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="SUV")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(suvBilgi());
            }
            else if (comboBox1.Text == "SEDAN")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(sedanBilgi());
            }
            else if (comboBox1.Text == "HATCHBACK")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(hatchbackBilgi());
            }
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

        private void degerDonmeyenMetotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDegerDonmeyenMetot fr = new FrmDegerDonmeyenMetot();
            fr.ShowDialog();
            this.Close();
        }

        private void aşırıYüklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAsiriYukleme fr =new FrmAsiriYukleme();
            fr.ShowDialog();
            this.Close();
        }

        private void özyinelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOzyineleme fr =new FrmOzyineleme();
            fr.ShowDialog();
            this.Close();
        }

        private void FrmDegerDonenMetot_Load(object sender, EventArgs e)
        {

        }
    }
}