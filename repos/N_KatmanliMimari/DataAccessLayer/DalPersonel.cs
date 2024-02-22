﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DalPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * From Tbl_Bilgi",Baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dataReader= komut1.ExecuteReader();
            while (dataReader.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dataReader["ID"].ToString());
                ent.Ad = dataReader["AD"].ToString();
                ent.Soyad = dataReader["SOYAD"].ToString();
                ent.Gorev = dataReader["GOREV"].ToString();
                ent.Sehir = dataReader["SEHIR"].ToString();
                ent.Maas = short.Parse(dataReader["MAAS"].ToString());
                degerler.Add(ent);
            }
            dataReader.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Bilgi (AD,SOYAD,GOREV,SEHIR,MAAS) VALUES (@P1,@P2,@P3,@P4,@P5)",Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1",p.Ad);
            komut2.Parameters.AddWithValue("@P2",p.Soyad);
            komut2.Parameters.AddWithValue("@P3",p.Gorev);
            komut2.Parameters.AddWithValue("@P4",p.Sehir);
            komut2.Parameters.AddWithValue("@P5",p.Maas);
            return komut2.ExecuteNonQuery();
        }

        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From Tbl_Bilgi Where ID=@p1",Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("p1",p);
            return komut3.ExecuteNonQuery() > 0;
        }

        public static bool PersonelGuncelle(EntityPersonel ent)
        {
            SqlCommand komut4 = new SqlCommand("Update Tbl_Bilgi Set AD=@P1,SOYAD=@P2,MAAS=@P3,SEHIR=@P4,GOREV=@P5 WHERE ID=@P6",Baglanti.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("P1",ent.Ad);
            komut4.Parameters.AddWithValue("P2",ent.Soyad);
            komut4.Parameters.AddWithValue("P3",ent.Maas);
            komut4.Parameters.AddWithValue("P4",ent.Sehir);
            komut4.Parameters.AddWithValue("P5",ent.Gorev);
            komut4.Parameters.AddWithValue("P6",ent.Id);
            return komut4.ExecuteNonQuery() > 0;
        }
    }
}
