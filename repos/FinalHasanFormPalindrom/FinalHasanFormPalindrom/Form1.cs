using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHasanFormPalindrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pali_sayi;
            label1.Text = "";
            pali_sayi = Convert.ToInt16(/*dördüncü boşluk*/textBox1.Text);
            /*beşinci boşluk*/listBox1.Items.Add(pali_sayi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            void palindrom(int psayi/*ikl boşluk*/)
            {
                for (int say = psayi - 1; say >= 0; say--)
                {
                    /*label1.Text += textBox1.Text(say, 1);*/
                }
                if (textBox1.Text == label1.Text)
                {
                    listBox1.Items.Add(textBox1.Text);
                }
                else
                {
                    /*üçüncü boşluk*/MessageBox.Show("Palindrom Sayı Değildir");
                }
            }
        }
    }
}
