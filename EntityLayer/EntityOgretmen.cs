using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int otid;
        public int OTID
        {
            get { return otid; }
            set { otid = value; }
        }
        private string otadsoyad;
        public string OTADSOYAD
        {
            get { return otadsoyad; }
            set { otadsoyad = value; }
        }
        private int otbrans;
        public int OTBRANS
        {
            get { return otbrans; }
            set { otbrans = value; }
        }
    }
}
