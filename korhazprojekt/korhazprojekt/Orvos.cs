using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhazprojekt
{
    public class Orvos
    {
        public string Nev { get;  }
        public string Szak { get; set; }

        public Orvos(string nev, string szak)
        {
            Nev = nev;
            Szak = szak;
        }

        public string Diagnosztizal(Beteg beteg)
        {
            return ($"Dr. {Nev} diagnosztizálta {beteg.Nev}-t: {beteg.Betegseg}.");
        }

        public string Kezel(Beteg beteg)
        {
            return beteg.Kezeles();
            
        }
    }
}
