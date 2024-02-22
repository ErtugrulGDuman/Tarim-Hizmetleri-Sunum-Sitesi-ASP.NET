using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AliHocaWebS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection Bag = new SqlConnection(ConfigurationManager.ConnectionStrings["baglan"].ConnectionString);
            Bag.Open();
            SqlCommand komut = new SqlCommand("insert into ogrenciler (ad, soyad) values (@ad,@soyad,)", Bag);
            komut.Parameters.AddWithValue("@ad", Ad.Text);
            komut.Parameters.AddWithValue("@soyad", Soyad.Text);
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            Bag.Close();
        }
    }
}