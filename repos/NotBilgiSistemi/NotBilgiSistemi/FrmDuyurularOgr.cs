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

namespace NotBilgiSistemi
{
    public partial class FrmDuyurularOgr : Form
    {
        public FrmDuyurularOgr()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=EGD\\SQLEXPRESS;Initial Catalog=NotBilgiSistemi;Integrated Security=True");

        private void FrmDuyurularOgr_Load(object sender, EventArgs e)
        {
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tblDuyuruTableAdapter.Fill(this.notBilgiSistemiDataSet5.TblDuyuru);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand cmd = new SqlCommand("insert into TblDuyuru (DuyuruTarih, Duyuru) values (@p1, @p2)", bag);
            cmd.Parameters.AddWithValue("@p1", MskTarih.Text);
            cmd.Parameters.AddWithValue("@p2", RchTxtDuyuru.Text);
            cmd.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kaydedildi !!!");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand cmd = new SqlCommand("update TblDuyuru set DuyuruTarih=@p1, Duyuru=@p2 where ID=@p3", bag);
            cmd.Parameters.AddWithValue("@p1", MskTarih.Text);
            cmd.Parameters.AddWithValue("@p2", RchTxtDuyuru.Text);
            cmd.Parameters.AddWithValue("@p3", TxtID.Text);
            cmd.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Güncellendi !!!");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand cmd = new SqlCommand("delete from TblDuyuru where ID=@p1", bag);
            cmd.Parameters.AddWithValue("@p1", TxtID.Text);
            cmd.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Silindi !!!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            MskTarih.Text = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            RchTxtDuyuru.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmOgretmen frmOgretmen = new FrmOgretmen();
            this.Hide();
            frmOgretmen.Show();
        }
    }
}
