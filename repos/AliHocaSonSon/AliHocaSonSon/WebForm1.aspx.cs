using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AliHocaSonSon
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection bag = new SqlConnection(ConfigurationManager.ConnectionStrings["baglan"].ConnectionString);

        protected void Button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Ogrenci (Ad, Soyad) values (@Ad, @Soyad)",bag);
            komut.Parameters.AddWithValue("@Ad",TextBox1.Text);
            komut.Parameters.AddWithValue("@Soyad", TextBox2.Text);
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut1 = new SqlCommand("UPDATE Tbl_Ogrenci SET Ad=@Ad, Soyad=@Soyad where id=@id",bag);
            komut1.Parameters.AddWithValue("@id", 1);
            komut1.Parameters.AddWithValue("@Ad", TextBox1.Text);
            komut1.Parameters.AddWithValue("@Soyad", TextBox2.Text);
            komut1.ExecuteNonQuery();
            komut1.Parameters.Clear();
        }
    }
}