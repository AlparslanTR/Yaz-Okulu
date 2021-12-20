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
    public class DataOgretmen
    {
        public static List<EntityOgretmen> OgretmenListesi()
        {
            List<EntityOgretmen> degerler = new List<EntityOgretmen>();
            SqlCommand komut = new SqlCommand("Select*From Tbl_Ogretmen", baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgretmen ent = new EntityOgretmen();
                ent.OTID = Convert.ToInt32(dr["OgretmenID"].ToString());
                ent.OTADSOYAD = dr["AdSoyad"].ToString();
                ent.OTBRANS = Convert.ToInt32(dr["Brans"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
