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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection("Data Source=EGD\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut0 = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAdi=@p1 and Sifre=@p2", Baglanti);
            komut0.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut0.Parameters.AddWithValue("@p2", TxtSifre.Text);
            try
            {
                SqlDataReader dr0 = komut0.ExecuteReader();
                if (dr0.Read())
                {
                    FrmAnaForm Frm = new FrmAnaForm();
                    Frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
                }
                Baglanti.Close();
            }
            catch(Exception ex)
            {
                if (ex is SqlException)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
