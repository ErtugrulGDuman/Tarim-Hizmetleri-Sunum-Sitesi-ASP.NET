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
	public partial class FrmGrafik : Form
	{
		public FrmGrafik()
		{
			InitializeComponent();
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=EGD\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");

		private void FrmGrafik_Load(object sender, EventArgs e)
		{
			//İlçe adlarını combobox a çekme
			baglanti.Open();	
			SqlCommand cmd = new SqlCommand("select ILCEAD from TBLILCE",baglanti);
			SqlDataReader dataReader = cmd.ExecuteReader();
			while (dataReader.Read())
			{
				comboBox1.Items.Add(dataReader[0]);
			}
			baglanti.Close();

			//Grafiğe toplam sonuçları getirme

			baglanti.Open();
			SqlCommand cmd2 = new SqlCommand("SELECT SUM(APARTI),SUM(BPARTI),SUM(CPARTI),SUM(DPARTI),SUM(EPARTI) FROM TBLILCE", baglanti);
			SqlDataReader dataReader2 = cmd2.ExecuteReader();
			while (dataReader2.Read())
			{
				chart1.Series["Partiler"].Points.AddXY("A PARTİ", dataReader2[0]);
				chart1.Series["Partiler"].Points.AddXY("B PARTİ", dataReader2[1]);
				chart1.Series["Partiler"].Points.AddXY("C PARTİ", dataReader2[2]);
				chart1.Series["Partiler"].Points.AddXY("D PARTİ", dataReader2[3]);
				chart1.Series["Partiler"].Points.AddXY("E PARTİ", dataReader2[4]);
			}
			baglanti.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			baglanti.Open();
			SqlCommand cmd = new SqlCommand("Select * From TBLILCE Where ILCEAD=@p1", baglanti);
			cmd.Parameters.AddWithValue("@p1", comboBox1.Text);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				progressBar1.Value= int.Parse(reader[2].ToString());
				progressBar2.Value= int.Parse(reader[3].ToString());
				progressBar3.Value= int.Parse(reader[4].ToString());
				progressBar4.Value= int.Parse(reader[5].ToString());
				progressBar5.Value= int.Parse(reader[6].ToString());

				LblA.Text = reader[2].ToString();
				LblB.Text = reader[3].ToString();
				LblC.Text = reader[4].ToString();
				LblD.Text = reader[5].ToString();
				LblE.Text = reader[6].ToString();
			}
			baglanti.Close();
		}
	}
}