using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Bgl = new SqlConnection("Data Source=EGD\\SQLEXPRESS;Initial Catalog=GPFinal;Integrated Security=True");

        void temizle()
        {
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            radioErkek.Checked = false;
            radioKadın.Checked = false;
            textBox7.Text = " ";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gPFinalDataSet1.TblOgrenci' table. You can move, or remove it, as needed.
            this.tblOgrenciTableAdapter.Fill(this.gPFinalDataSet1.TblOgrenci);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tblOgrenciTableAdapter.Fill(this.gPFinalDataSet1.TblOgrenci);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tblOgrenciTableAdapter.Fill(this.gPFinalDataSet1.TblOgrenci);
        }

        private void BtnKAydet_Click(object sender, EventArgs e)
        {
            Bgl.Open();
            SqlCommand sqlkomut = new SqlCommand("insert into TblOgrenci(TCNo, OgrenciAd, OgrenciSoyad, Sehir, Yas, Cinsiyet, Ihtiyac) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", Bgl);
            sqlkomut.Parameters.AddWithValue("@p1", textBox2.Text);
            sqlkomut.Parameters.AddWithValue("@p2", textBox3.Text);
            sqlkomut.Parameters.AddWithValue("@p3", textBox4.Text);
            sqlkomut.Parameters.AddWithValue("@p4", textBox5.Text);
            sqlkomut.Parameters.AddWithValue("@p5", textBox6.Text);
            sqlkomut.Parameters.AddWithValue("@p6", Convert.ToInt16(label20.Text));
            sqlkomut.Parameters.AddWithValue("@p7", textBox7.Text);
            sqlkomut.ExecuteNonQuery();
            Bgl.Close();
            MessageBox.Show("Kaydedildi");
        }

        private void radioErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioErkek.Checked == true)
            {
                label20.Text = "0";
            }
        }

        private void radioKadın_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKadın.Checked == true)
            {
                label20.Text = "1";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
