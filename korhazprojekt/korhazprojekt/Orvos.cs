using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhazprojekt
{
    public class Orvos
    {
        public string Név { get;  }
        public string Szakterület { get; set; }
        //mennyiért dolgozik
        public double Ár { get; set; }

        public Orvos(string név, string szakterület, double ár)
        {
            Név = név;
            Szakterület = szakterület;
            Ár = ár;
        }
    }
}
