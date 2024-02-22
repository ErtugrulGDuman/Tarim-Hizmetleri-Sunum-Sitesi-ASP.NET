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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notBilgiSistemiDataSet.TblOgrenci' table. You can move, or remove it, as needed.
            this.tblOgrenciTableAdapter.Fill(this.notBilgiSistemiDataSet.TblOgrenci);

        }
    }
}
