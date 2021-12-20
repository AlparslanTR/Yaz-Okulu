using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccesLayer;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.ORADSOYAD!=null && p.ORNUMARA!=null && p.ORSIFRE!=null && p.ORFOTOGRAF!=null)
            {
                return DataOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> BLLListele()
        {
            return DataOgrenci.OgrenciListesi();
        }
        public static bool OgrenciSilBll(int p)
        {
            if (p != null)
            {
                return DataOgrenci.OgrenciSil(p);
            }
            return false;
        }
        public static List<EntityOgrenci> BLLLDetay(int p)
        {
            return DataOgrenci.OgrenciDetay(p);
        }
        public static bool OgrenciGuncelle(EntityOgrenci p)
        {
            if (p.ORADSOYAD != null && p.ORNUMARA != null && p.ORSIFRE != null && p.ORFOTOGRAF != null && p.ORID>0)
            {
                return DataOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
