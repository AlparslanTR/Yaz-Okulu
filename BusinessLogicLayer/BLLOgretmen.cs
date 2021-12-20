using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccesLayer;

namespace BusinessLogicLayer
{
   public class BLLOgretmen
    {
        public static List<EntityOgretmen> BLListele()
        {
            return DataOgretmen.OgretmenListesi();
        }
    }
}
