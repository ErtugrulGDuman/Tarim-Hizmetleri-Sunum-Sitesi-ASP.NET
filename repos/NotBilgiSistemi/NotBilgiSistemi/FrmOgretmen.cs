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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("Data Source=EGD\\SQLEXPRESS;Initial Catalog=NotBilgiSistemi;Integrated Security=True");


        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tblOgrenciTableAdapter.Fill(this.notBilgiSistemiDataSet1.TblOgrenci);
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            this.Hide();
            frmGiris.Show();
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurularOgr frmDuyurularOgr = new FrmDuyurularOgr();
            this.Hide();
            frmDuyurularOgr.Show();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOgrenci (OgrAd, OgrSoyad, OgrSehir, VizeNot, FinalNot) values (@p2, @p3, @p4, @p5, @p6)", bag);
            cmd.Parameters.AddWithValue("@p2",TxtAd.Text);
            cmd.Parameters.AddWithValue("@p3",TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p4",TxtSehir.Text);
            cmd.Parameters.AddWithValue("@p5",TxtVizeN.Text);
            cmd.Parameters.AddWithValue("@p6",TxtFinalN.Text);
            cmd.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Kaydedildi !!!");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand cmd = new SqlCommand("Delete from TblOgrenci where OgrNo=@p1", bag);
            cmd.Parameters.AddWithValue("@p1",TxtOgrNo.Text);
            cmd.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Silindi !!!");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand cmd = new SqlCommand("Update TblOgrenci Set OgrAd=@p1, OgrSoyad=@p2, OgrSehir=@p3, VizeNot=@p4, FinalNot=@p5 where OgrNo=@p6", bag);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSehir.Text);
            cmd.Parameters.AddWithValue("@p4", TxtVizeN.Text);
            cmd.Parameters.AddWithValue("@p5", TxtFinalN.Text);
            cmd.Parameters.AddWithValue("@p6", TxtOgrNo.Text);
            cmd.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Güncellendi !!!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            TxtOgrNo.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            TxtSehir.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            TxtVizeN.Text = dataGridView1.Rows[secili].Cells[4].Value.ToString();
            TxtFinalN.Text = dataGridView1.Rows[secili].Cells[5].Value.ToString();
         }
    }
}
