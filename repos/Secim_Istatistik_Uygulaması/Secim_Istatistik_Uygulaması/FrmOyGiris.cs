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

namespace Secim_Istatistik_Uygulaması
{
	public partial class FrmOyGiris : Form
	{
		public FrmOyGiris()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=EGD\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");

		private void BtnOyVer_Click(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO TBLILCE (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) values (@p1, @p2, @p3, @p4, @p5, @p6)",baglanti);
			cmd.Parameters.AddWithValue("@p1", TxtIlceAd.Text);
			cmd.Parameters.AddWithValue("@p2", TxtA.Text);
			cmd.Parameters.AddWithValue("@p3", TxtB.Text);
			cmd.Parameters.AddWithValue("@p4", TxtC.Text);
			cmd.Parameters.AddWithValue("@p5", TxtD.Text);
			cmd.Parameters.AddWithValue("@p6", TxtE.Text);
			cmd.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Oy Girişi Gerçekleşti");
		}

		private void BtnGrafik_Click(object sender, EventArgs e)
		{
			FrmGrafik frmGrafik = new FrmGrafik();
			frmGrafik.Show();
		}
	}
}