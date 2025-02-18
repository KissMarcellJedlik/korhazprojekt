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
        public List<Beteg> Betegek { get; set; } = new List<Beteg>();

        public Osztaly(string nev)
        {
            Nev = nev;
        }

        public void FelveszBeteget(Beteg beteg)
        {
            Betegek.Add(beteg);
        }
    }
}
