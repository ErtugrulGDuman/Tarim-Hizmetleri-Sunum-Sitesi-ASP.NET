using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotBilgiSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgrenci frmOgrenci = new FrmOgrenci();
            frmOgrenci.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgretmen frmOgretmen = new FrmOgretmen();
            frmOgretmen.Show();
            this.Hide();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            FrmDuyuru frmDuyuru = new FrmDuyuru();
            frmDuyuru.Show();
        }
    }
}
