using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhazprojekt
{
    public class Osztaly
    {
        public string Nev { get; set; }
        private List<Beteg> Betegek { get; set; }

        public Osztaly(string nev)
        {
            Nev = nev;
            Betegek = new List<Beteg>();
        }

        public void FelveszBeteget(Beteg beteg)
        {
            Betegek.Add(beteg);
            Console.WriteLine($"{beteg.Nev} felvéve a {Nev} osztályra.");
        }
    }
}
