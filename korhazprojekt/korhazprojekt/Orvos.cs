using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhazprojekt
{
    public class Orvos
    {
        public string Nev { get; set; }
        public string Szak { get; set; }

        public Orvos(string nev, string szak)
        {
            Nev = nev;
            Szak = szak;
        }

        public void Diagnosztizal(Beteg beteg)
        {
            Console.WriteLine($"Dr. {Nev} diagnosztizálta {beteg.Nev}-t: {beteg.Betegseg}.");
        }

        public void Kezel(Beteg beteg)
        {
            beteg.Kezeles();
            Console.WriteLine($"Dr. {Nev} kezelte {beteg.Nev}-t.");
        }
    }
}
