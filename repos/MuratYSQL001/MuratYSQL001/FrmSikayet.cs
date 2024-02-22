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

namespace MuratYSQL001
{
    public partial class FrmSikayet : Form
    {
        public FrmSikayet()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=EGD\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Sikayet (Tbl_Sikayet) values (@p1)", Baglanti);
            sqlCommand.Parameters.AddWithValue("@p1", richTextBox1.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            Baglanti.Close();
            MessageBox.Show("ŞİKAYET Eklendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm frm = new FrmAnaForm();
            this.Close();
            frm.ShowDialog();
        }

        private void FrmSikayet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet2.Tbl_Sikayet' table. You can move, or remove it, as needed.
            this.tbl_SikayetTableAdapter.Fill(this.personelVeriTabaniDataSet2.Tbl_Sikayet);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_SikayetTableAdapter.Fill(this.personelVeriTabaniDataSet2.Tbl_Sikayet);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Sikayet Set Tbl_Sikayet=@s1 where Sikayet_id=@s2", Baglanti);
            komutGuncelle.Parameters.AddWithValue("@s1", richTextBox1.Text);
            komutGuncelle.Parameters.AddWithValue("@s2", textBox1.Text);
            komutGuncelle.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Şikayet Bilgisi Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komutSil = new SqlCommand("Delete From Tbl_Sikayet Where Sikayet_id=@s1", Baglanti);
            komutSil.Parameters.AddWithValue("@s1", textBox1.Text);
            komutSil.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Şikayet Silndi");
        }
    }
}