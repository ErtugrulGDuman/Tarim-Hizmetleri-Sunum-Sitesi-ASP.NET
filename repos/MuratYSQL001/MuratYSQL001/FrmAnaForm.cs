using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MuratYSQL001
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti =new SqlConnection("Data Source=EGD\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        void temizle()
        {
            Txtid.Text = " ";
            TxtAd.Text = " ";
            TxtSoyad.Text = " ";
            TxtMeslek.Text = " ";
            MskMaas.Text = " ";
            CmbSehir.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtAd.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet1.Tbl_Personel' table. You can move, or remove it, as needed.
            //this.tbl_PersonelTableAdapter3.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",Baglanti);
            sqlCommand.Parameters.AddWithValue("@p1", TxtAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", CmbSehir.Text);
            sqlCommand.Parameters.AddWithValue("@p4", MskMaas.Text);
            sqlCommand.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            sqlCommand.Parameters.AddWithValue("@p6", label8.Text);
            sqlCommand.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter3.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komutSil = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", Baglanti);
            komutSil.Parameters.AddWithValue("@k1",Txtid.Text);
            komutSil.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Kayıt Silndi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@u1,PerSoyad=@u2,PerSehir=@u3,PerMaas=@u4,PerDurum=@u5,PerMeslek=@u6 where Perid=@u7", Baglanti);
            komutGuncelle.Parameters.AddWithValue("@u1", TxtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@u2", TxtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@u3", CmbSehir.Text);
            komutGuncelle.Parameters.AddWithValue("@u4",MskMaas.Text);
            komutGuncelle.Parameters.AddWithValue("@u5", label8.Text);
            komutGuncelle.Parameters.AddWithValue("@u6",TxtMeslek.Text);
            komutGuncelle.Parameters.AddWithValue("@u7", Txtid.Text);
            komutGuncelle.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Personel Bilgisi Güncellendi");
        }

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik fr = new FrmIstatistik();
            fr.Show();
            this.Hide();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSikayet frm = new FrmSikayet();
            frm.Show();
            this.Hide();
        }
    }
}
