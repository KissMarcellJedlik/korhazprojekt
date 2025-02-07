using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhazprojekt
{
    public class Beteg
    {
        public string Név { get;  }
        public string Betegség { get; set; }
        public string Vértípus { get;  }

        public Beteg(string név, string betegség, string vértípus)
        {
            Név = név;
            Betegség = betegség;
            Vértípus = vértípus;
        }
    }
}
