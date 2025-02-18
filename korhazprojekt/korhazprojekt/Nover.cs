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
        public void Segit(Beteg beteg)
        {
            Console.WriteLine($"{Nev} segitett {beteg.Nev}-nek a kezelés során.");

        }
    }
}
