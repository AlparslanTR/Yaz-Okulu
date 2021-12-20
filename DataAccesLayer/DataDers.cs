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
    public class DataDers
    {
        public static List<EntityDers> DersListesi()
        {
            // Liste Yöntemiyle Derslerin Listesini Çekme
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut = new SqlCommand("Select*from Tbl_Dersler", baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.ID = Convert.ToInt32(dr["DersID"].ToString());
                ent.DERSAD = dr["Ad"].ToString();
                ent.MIN = Convert.ToInt32(dr["MinKontenjan"].ToString());
                ent.MAX = Convert.ToInt32(dr["MaxKontenjan"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuru parametre)
        {
            SqlCommand komut2 = new SqlCommand("Insert into Tbl_Basvuru(OgrenciID,DersID)values(@p1,@p2)", baglanti.bgl);
            komut2.Parameters.AddWithValue("@p1", parametre.ORBASVURUID);
            komut2.Parameters.AddWithValue("@p2", parametre.BASVURUDERSID);
            if (komut2.Connection.State!=ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            return komut2.ExecuteNonQuery();
        }
    }
}
