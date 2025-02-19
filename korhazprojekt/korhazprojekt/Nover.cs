using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhazprojekt
{
    public class Nover
    {
        public string Nev { get;  }

        public Nover(string nev)
        {
            Nev = nev;
        }
        public string Segit(Beteg beteg)
        {
            return ($"{Nev} segitett {beteg.Nev}-nek a kezelés során.");

        }
    }
}
