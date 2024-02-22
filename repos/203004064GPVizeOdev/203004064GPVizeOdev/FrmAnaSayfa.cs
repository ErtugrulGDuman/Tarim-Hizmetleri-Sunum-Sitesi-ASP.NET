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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTekBoyutluDizi fr = new FrmTekBoyutluDizi();
            fr.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCokBoyutluDizi fr = new FrmCokBoyutluDizi();
            fr.ShowDialog();
        }

        private void DegerDonenMetot_Click(object sender, EventArgs e)
        {
            FrmDegerDonenMetot fr = new FrmDegerDonenMetot();
            fr.ShowDialog();
        }

        private void DegerDonmeyenMetot_Click(object sender, EventArgs e)
        {
            FrmDegerDonmeyenMetot fr = new FrmDegerDonmeyenMetot();
            fr.ShowDialog();
        }

        private void AsiriYukleme_Click(object sender, EventArgs e)
        {
            FrmAsiriYukleme fr = new FrmAsiriYukleme();
            fr.ShowDialog();
        }

        private void Ozyineleme_Click(object sender, EventArgs e)
        {
            FrmOzyineleme fr = new FrmOzyineleme();
            fr.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}