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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=EGD\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", Baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();
            }
            Baglanti.Close();


            Baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=1", Baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliPersonel.Text = dr2[0].ToString();
            }
            Baglanti.Close();


            Baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=0", Baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }
            Baglanti.Close();


            Baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel",Baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblFarklıSehirSayısı.Text = dr4[0].ToString();
            }
            Baglanti.Close();


            Baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", Baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblToplamMaas.Text=dr5[0].ToString();
            }
            Baglanti.Close();


            Baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", Baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblOrtalamaMaas.Text = dr6[0].ToString();
            }
            Baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaForm form = new FrmAnaForm();
            this.Close();
            form.ShowDialog();
        }
    }
}
