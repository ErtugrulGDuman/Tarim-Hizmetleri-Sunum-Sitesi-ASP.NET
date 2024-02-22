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
    public partial class FrmDuyuru : Form
    {
        public FrmDuyuru()
        {
            InitializeComponent();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            this.Hide();
            frmGiris.Show();
        }

        private void FrmDuyuru_Load(object sender, EventArgs e)
        {
            this.tblDuyuruTableAdapter.Fill(this.notBilgiSistemiDataSet2.TblDuyuru);
        }
    }
}
