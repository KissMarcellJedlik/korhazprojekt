using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhazprojekt
{
    public class Gyogyszer
    {
        public string Nev { get; set; }
        public string Hatas { get; set; }

        public Gyogyszer(string nev, string hatas)
        { 
            Nev = nev;
            Hatas = hatas;
        }

        public string Adagol(Beteg beteg)
        {
            return($"{Nev} gyógyszer beadva {beteg.Nev}-nek, hatás: {Hatas}");
        }
    }
}
