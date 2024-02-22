using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AliHocaFinalDeneme1
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection bag =new SqlConnection(ConfigurationManager.ConnectionStrings["baglan"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("insert into Tbl_OgrBilgi (AD, SOYAD, OKUL, BOLUM, YAS, TELNO) values (@p1,@p2,@p3,@p4,@p5,@p6)",bag);
            bag.Open();
            komut1.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut1.Parameters.AddWithValue("@p3", TxtOkul.Text);
            komut1.Parameters.AddWithValue("@p4", TxtBolum.Text);
            komut1.Parameters.AddWithValue("@p5", TxtYas.Text);
            komut1.Parameters.AddWithValue("@p6", TxtTelNo.Text);
            komut1.ExecuteNonQuery();
            Response.Write("Kayıt Başarılı");
            komut1.Parameters.Clear();
            bag.Close();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from Tbl_OgrBilgi where ID=@p7", bag);
            bag.Open();
            komut2.Parameters.AddWithValue("@p7",int.Parse(TxtID.Text));
            komut2.ExecuteNonQuery();
            Response.Write("Silme Başarılı");
            komut2.Parameters.Clear();
            bag.Close();
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update Tbl_OgrBilgi set (AD, SOYAD, OKUL, BOLUM, YAS, TELNO) values (@p1,@p2,@p3,@p4,@p5,@p6) where ID=@p7", bag);
            bag.Open();
            komut3.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut3.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut3.Parameters.AddWithValue("@p3", TxtOkul.Text);
            komut3.Parameters.AddWithValue("@p4", TxtBolum.Text);
            komut3.Parameters.AddWithValue("@p5", Convert.ToInt16(TxtYas.Text));
            komut3.Parameters.AddWithValue("@p6", TxtTelNo.Text);
            komut3.Parameters.AddWithValue("@p7", Convert.ToInt16(TxtID1.Text));
            komut3.ExecuteNonQuery();
            Response.Write("Güncelleme Başarılı");
            komut3.Parameters.Clear();
            bag.Close();
        }
    }
}