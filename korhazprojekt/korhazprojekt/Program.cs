namespace korhazprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Beteg> betegek = new List<Beteg>();
            List<Orvos> orvosok = new List<Orvos>() { new Orvos("Nagy László", "Belgyógyászat"),
                                                      new Orvos("Kiss Péter", "Sebészet"),
                                                      new Orvos("Szabó Éva", "Neurológia")
                                                    };
            List<Osztaly> osztalyok = new List<Osztaly>() { new Osztaly("Belgyógyászat") };
            List<Nover> noverek = new List<Nover>() { new Nover("Kovács Anna") };
            List<Gyogyszer> gyogyszerek = new List<Gyogyszer>() { new Gyogyszer("Paracetamol", "Lázcsillapítás") };
            new Osztaly("Plasztika");
            new Osztaly("Bőrgyógyászat");
            new Orvos("Szegedi István", "Plasztika");
            new Orvos("Galamb Péter", "Bőrgyógyászat");

            while (true)
            {
                Console.WriteLine("\nKórház Menü:");
                Console.WriteLine("1. Beteg felvétele");
                Console.WriteLine("2. Diagnózis");
                Console.WriteLine("3. Kezelés");
                Console.WriteLine("4. Gyógyszer beadása");
                Console.WriteLine("5. Kilépés");
                Console.Write("Válassz egy lehetőséget: ");
                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "1":
                        Console.Write("Beteg neve: ");
                        string nev = Console.ReadLine();
                        Console.Write("Betegség: ");
                        string betegseg = Console.ReadLine();
                        Beteg ujBeteg = new Beteg(nev, betegseg);
                        betegek.Add(ujBeteg);
                        osztalyok[0].FelveszBeteget(ujBeteg);
                        break;
                    case "2":
                        if (betegek.Count > 0)
                        {
                            orvosok[0].Diagnosztizal(betegek[0]);
                        }
                        else
                        {
                            Console.WriteLine("Nincs diagnosztizálható beteg!");
                        }
                        break;
                }
            }

        }
    }
}
       

