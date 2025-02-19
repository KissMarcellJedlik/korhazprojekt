namespace korhazprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Beteg> betegek = new List<Beteg>();
            List<Orvos> orvosok = new List<Orvos>() { new Orvos("Nagy László", "Belgyógyászat"),
                                                      new Orvos("Kiss Péter", "Sebészet"),
                                                      new Orvos("Szabó Éva", "Neurológia"),
                                                      new Orvos("Szegedi István", "Plasztika"),
                                                      new Orvos("Galamb Péter", "Bőrgyógyászat")
                                                    };
            List<Osztaly> osztalyok = new List<Osztaly>() { new Osztaly("Belgyógyászat"),
                                                            new Osztaly("Plasztika"),
                                                            new Osztaly("Bőrgyógyászat"),
                                                            new Osztaly("Sebészet"),
                                                            new Osztaly("Neurológia") };
            List<Nover> noverek = new List<Nover>() { new Nover("Kovács Anna") };
            List<Gyogyszer> gyogyszerek = new List<Gyogyszer>() { new Gyogyszer("Paracetamol", "Lázcsillapítás"), 
                                                                  new Gyogyszer("Kenőcs", "Bőrgyógyítás"),
                                                                  new Gyogyszer("Ibuprofen", "Gyulladáscsökkentő"),
                                                                  new Gyogyszer("Amoxicillin", "Antibiotikum"),
                                                                  new Gyogyszer("Lidocain", "Érzéstelenítés")
                                                                };
            
            

            while (true)
            {
                Console.Clear();
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

                        foreach (var osztaly in osztalyok)
                        {
                            if (osztaly.Nev.Contains(betegseg, StringComparison.OrdinalIgnoreCase))
                            {
                                osztaly.FelveszBeteget(ujBeteg);
                                break;
                            }
                        }
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
       

