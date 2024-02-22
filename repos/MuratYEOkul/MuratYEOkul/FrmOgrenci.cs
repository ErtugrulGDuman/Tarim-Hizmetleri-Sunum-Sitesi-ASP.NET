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
using System.Data.SqlClient;

namespace MuratYEOkul
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=EGD\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }
        DataSet1TableAdapters.TBLOGRENCILERTableAdapter ds = new DataSet1TableAdapters.TBLOGRENCILERTableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "KULUPAD";
            comboBox1.ValueMember= "KULUPID";
            comboBox1.DataSource = dt;
            baglanti.Close();

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.IndianRed;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        string c = "";
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "KIZ";
            }
            if (radioButton2.Checked == true) 
            {
                c = "ERKEK";
            }
            ds.OgrenciEkle(TxtOgrAd.Text,TxtOgrSoyad.Text,byte.Parse(comboBox1.SelectedValue),c);
            MessageBox.Show("Ekleme Başarılı");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TxtOgrid.Text = comboBox1.SelectedValue.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(TxtOgrid.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtOgrid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtOgrAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtOgrSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(TxtOgrAd.Text, TxtOgrSoyad.Text, byte.Parse(comboBox1.SelectedValue.ToString()), c, int.Parse(TxtOgrid.Text));

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "KIZ";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                c = "ERKEK";
            }
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciGetir(TxtAra.Text);
        }
    }
}
