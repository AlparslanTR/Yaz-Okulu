using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccesLayer;

namespace BusinessLogicLayer
{
   public class BLLDers
    {
        public static List<EntityDers> BLLListele()
        {
            return DataDers.DersListesi();
        }
        public static int TalepEkleBLL(EntityBasvuru p)
        {
            if (p.ORBASVURUID!=null && p.BASVURUDERSID!=null)
            {
                return DataDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
