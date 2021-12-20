using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityBasvuru
    {
        private int basvuruid;
        private int orbasvuruid;
        private int basvurudersid;

        public int BASVURUID { get => basvuruid; set => basvuruid = value; }
        public int ORBASVURUID { get => orbasvuruid; set => orbasvuruid = value; }
        public int BASVURUDERSID { get => basvurudersid; set => basvurudersid = value; }
    }
}
