using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAccesLayer
{
    public class DataOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Ogrenci(AdSoyad,Numara,Foto,Sifre)values(@p1,@p2,@p3,@p4)", baglanti.bgl);
            //Eğer bağlantı açılmazsa bağlantıyı aç
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", parametre.ORADSOYAD);
            komut.Parameters.AddWithValue("@p2", parametre.ORNUMARA);
            komut.Parameters.AddWithValue("@p3", parametre.ORFOTOGRAF);
            komut.Parameters.AddWithValue("@p4", parametre.ORSIFRE);
            return komut.ExecuteNonQuery();
        }
        public static List<EntityOgrenci> OgrenciListesi()
        {
            // Liste Yöntemiyle Öğrenci Listesini Çekme
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select*from Tbl_Ogrenci", baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ORID = Convert.ToInt32(dr["OgrID"].ToString());
                ent.ORADSOYAD = dr["AdSoyad"].ToString();
                ent.ORNUMARA = dr["Numara"].ToString();
                ent.ORSIFRE = dr["Sifre"].ToString();
                ent.ORFOTOGRAF = dr["Foto"].ToString();
                ent.ORBAKİYE = Convert.ToDouble(dr["Bakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete from Tbl_Ogrenci where OgrID=@p1", baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            // Liste Yöntemiyle Öğrenci Listesini Güncelleme Sayfasına Çekme
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select*from Tbl_Ogrenci where OgrID=@p1", baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.ORADSOYAD = dr["AdSoyad"].ToString();
                ent.ORNUMARA = dr["Numara"].ToString();
                ent.ORSIFRE = dr["Sifre"].ToString();
                ent.ORFOTOGRAF = dr["Foto"].ToString();
                ent.ORBAKİYE = Convert.ToDouble(dr["Bakiye"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update Tbl_Ogrenci set AdSoyad=@p1,Numara=@p2,Foto=@p3,Sifre=@p4 where OgrID=@p5", baglanti.bgl);
            if (komut5.Connection.State!=ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@p1", deger.ORADSOYAD);
            komut5.Parameters.AddWithValue("@p2", deger.ORNUMARA);
            komut5.Parameters.AddWithValue("@p3", deger.ORFOTOGRAF);
            komut5.Parameters.AddWithValue("@p4", deger.ORSIFRE);
            komut5.Parameters.AddWithValue("@p5", deger.ORID);
            return komut5.ExecuteNonQuery() > 0;

        }
    }

}
