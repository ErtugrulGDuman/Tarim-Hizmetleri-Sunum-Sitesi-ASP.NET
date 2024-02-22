using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalDenemeHasan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox3.Text);
            listBox1.Items.Add(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox5.Text + "+" + textBox6.Text + " = " + (int.Parse(textBox5.Text) + int.Parse(textBox6.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox5.Text + "-" + textBox6.Text + " = " + (int.Parse(textBox5.Text) - int.Parse(textBox6.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox5.Text + "x" + textBox6.Text + " = " + (int.Parse(textBox5.Text) * int.Parse(textBox6.Text)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox5.Text + "/" + textBox6.Text + " = " + (int.Parse(textBox5.Text) / int.Parse(textBox6.Text)));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox3.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            listBox2.Items.Clear();
        }
    }
}
