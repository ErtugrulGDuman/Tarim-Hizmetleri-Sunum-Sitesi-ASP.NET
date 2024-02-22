using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuratYEOkul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOgrenciNotlar fr = new FrmOgrenciNotlar();
            fr.numara = textBox1.Text;
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgretmen FR = new FrmOgretmen();
            FR.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYeni frmYeni = new FrmYeni();
            frmYeni.Show();
        }
    }
}
