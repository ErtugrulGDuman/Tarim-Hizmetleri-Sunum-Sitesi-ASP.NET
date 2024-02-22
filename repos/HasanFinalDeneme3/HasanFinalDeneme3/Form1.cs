using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HasanFinalDeneme3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Convert.ToInt16(textBox1.Text));
            label1.Text= ("Eklenen Sayı : " + Convert.ToString(textBox1.Text));
        }
    }
}
