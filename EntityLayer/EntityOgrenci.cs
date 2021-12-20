using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string oradsoyad;
        public string ORADSOYAD
        {
            get { return oradsoyad; }
            set { oradsoyad = value; }
        }
        private int orid;
        public int ORID
        {
            get { return orid; }
            set { orid = value; }
        }
        private string ornumara;
        public string ORNUMARA
        {
            get { return ornumara; }
            set { ornumara = value; }
        }
        private string orfotograf;
        public string ORFOTOGRAF
        {
            get { return orfotograf; }
            set { orfotograf = value; }
        }
        private double orbakiye;
        public double ORBAKİYE
        {
            get { return orbakiye; }
            set { orbakiye = value; }
        }

        public string ORSIFRE { get => orsifre; set => orsifre = value; }

        private string orsifre;

    }
}
