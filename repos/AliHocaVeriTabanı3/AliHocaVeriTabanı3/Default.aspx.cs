using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AliHocaVeriTabanı3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection(ConfigurationManager.ConnectionStrings["baglan"].ConnectionString);
            bag.Open();

            //Veritabanına Kayıt Ekleme

            /*SqlCommand komut = new SqlCommand("insert into Tbl_Ogrenciler (OgrenciAd,OgrenciSoyad,Bolumu) values (@p1,@p2,@p3)",bag);
            komut.Parameters.AddWithValue("@p1",Adi.Text);
            komut.Parameters.AddWithValue("@p2",Soyadi.Text);
            komut.Parameters.AddWithValue("@p3",Bolumu.Text);
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            Response.Write("Kayıt Başarılı");
            Response.Redirect("/Default.aspx");*/

            //Kayıt Güncelleme

            SqlCommand komut2 = new SqlCommand("Update Tbl_Ogrenciler set OgrenciAd=@OgrenciAd where id=@id",bag);
            komut2.Parameters.AddWithValue("@ogrenciAd", Adi.Text);
            komut2.Parameters.AddWithValue("@id", "3");
            komut2.ExecuteNonQuery();
            komut2.Parameters.Clear();
            Response.Write("Güncelleme Başarılı");
            Response.Redirect("/Default.aspx");

            //Kayıt Silme

            /*SqlCommand komut3 = new SqlCommand("Delete From Tbl_Ogrenciler where id=@id", bag);
            komut3.Parameters.AddWithValue("@id", "3");
            komut3.ExecuteNonQuery();
            komut3.Parameters.Clear();
            Response.Write("Silme Başarılı");
            Response.Redirect("/Default.aspx");*/
        }
    }
}