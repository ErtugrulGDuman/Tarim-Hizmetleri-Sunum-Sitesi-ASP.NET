using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MuratYKitaplikProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Ertugrul Gokay Duman\Desktop\Kitaplik1.accdb");

        void listele()
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter dataAdapter= new OleDbDataAdapter("Select * From Kitaplik",baglanti);
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
