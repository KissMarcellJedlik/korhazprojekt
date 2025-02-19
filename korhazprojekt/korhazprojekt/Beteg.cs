using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korhazprojekt
{
    public class Beteg
    {
        public string Nev { get;  }
        public string Betegseg { get; set; }
        public bool Gyogyult { get; private set; }

        public Beteg(string nev, string betegseg)
        {
            Nev = nev;
            Betegseg = betegseg;
            Gyogyult = false;
        }

        public string Kezeles()
        {
            Gyogyult = true;
            return ($"{Nev} sikeresen meggyógyult a(z) {Betegseg} betegségből.");
        }
    }
}
