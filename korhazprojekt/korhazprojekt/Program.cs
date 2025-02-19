namespace korhazprojekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Beteg> Betegek = new List<Beteg>()
            {
                new Beteg("Tóth Kendepúz", "Bőrgyógyászat"),
                new Beteg("Sampon PálInt", "Plasztika"),
                new Beteg("Skót Szalma", "Fogászat")
            }    
            ;
            


            List<Orvos> orvosok = new List<Orvos>() { new Orvos("Nagy László", "Belgyógyászat"),
                                                      new Orvos("Kiss Péter", "Sebészet"),
                                                      new Orvos("Szabó Éva", "Neurológia"),
                                                      new Orvos("Pakky Makky", "Fogászat"),
                                                      new Orvos("Szegedi István", "Plasztika"),
                                                      new Orvos("Galamb Péter", "Bőrgyógyászat")
                                                    };
            List<Osztaly> osztalyok = new List<Osztaly>() { new Osztaly("Belgyógyászat"),
                                                            new Osztaly("Plasztika"),
                                                            new Osztaly("Bőrgyógyászat"),
                                                            new Osztaly("Sebészet"),
                                                            new Osztaly("Fogászat"),
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
                        BetegFelvetele(Betegek, osztalyok);
                        break;
                    case "2":
                        Diagnosztizalas(orvosok, osztalyok);
                        break;
                    case "3":
                        Kezeles(orvosok, osztalyok);
                        break;
                    case "4":
                        GyogyszerBeadas(Betegek, gyogyszerek);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Érvénytelen választás!");
                        break;
                }
                Console.WriteLine("\nNyomj Entert a folytatáshoz...");
                Console.ReadLine();
            }

        }
        static void BetegFelvetele(List<Beteg> betegek, List<Osztaly> osztalyok)
        {
            Console.Write("Beteg neve: ");
            string nev = Console.ReadLine();
            Console.Write("Betegség: ");
            string betegseg = Console.ReadLine();
            Beteg ujBeteg = new Beteg(nev, betegseg);
            betegek.Add(ujBeteg);

            int nemjo = 0;
            foreach (var osztaly in osztalyok)
            {
                if (osztaly.Nev.Contains(betegseg, StringComparison.OrdinalIgnoreCase))
                {
                    osztaly.FelveszBeteget(ujBeteg);
                    break;
                }
                else
                {
                   nemjo += 1;
                    
                };
            }
            if (nemjo > 5)
            {
                Console.WriteLine($"Az általad megadott osztály({betegseg}) nem található nálunk ezért nem tudtuk felvenni betegnek.");
            }
            else if (nemjo < 6)
            {
                Console.WriteLine($"{nev}-t felvettük a {betegseg} nevű osztályra.");
            }
        }
        static void Diagnosztizalas(List<Orvos> orvosok, List<Osztaly> osztalyok)
        {
            Console.WriteLine("Válassz egy orvost a diagnózishoz:");
            for (int i = 0; i < orvosok.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Dr. {orvosok[i].Nev} - {orvosok[i].Szak}");
            }
            int valasztottOrvos = Convert.ToInt32(Console.ReadLine()) - 1;
            if (valasztottOrvos >= 0 && valasztottOrvos < orvosok.Count)
            {
                Osztaly orvosOsztalya = osztalyok.Find(o => o.Nev == orvosok[valasztottOrvos].Szak);
                if (orvosOsztalya != null)
                {
                    
                        foreach (var beteg in orvosOsztalya.Betegek)
                        {
                            Console.WriteLine(orvosok[valasztottOrvos].Diagnosztizal(beteg));
                        }
                }
            }
        }
        static void Kezeles(List<Orvos> orvosok, List<Osztaly> osztalyok)
        {
            Console.WriteLine("Válassz egy orvost a kezeléshez:");
            for (int i = 0; i < orvosok.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Dr. {orvosok[i].Nev} - {orvosok[i].Szak}");
            }
            int kezeloOrvos = Convert.ToInt32(Console.ReadLine()) - 1;
            if (kezeloOrvos >= 0 && kezeloOrvos < orvosok.Count)
            {
                Osztaly orvosOsztalya = osztalyok.Find(o => o.Nev == orvosok[kezeloOrvos].Szak)!;
                if (orvosOsztalya != null)
                {
                    foreach (var beteg in orvosOsztalya.Betegek)
                    {
                        Console.WriteLine(orvosok[kezeloOrvos].Kezel(beteg));
                        
                    }
                }

            }

        }
        static void GyogyszerBeadas(List<Beteg> betegek, List<Gyogyszer> gyogyszerek)
        {
            Console.WriteLine("Válassz egy beteget:");
            for (int i = 0; i < betegek.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {betegek[i].Nev} - {betegek[i].Betegseg}");
            }
            int betegValasztas = Convert.ToInt32(Console.ReadLine()) - 1;
            if (betegValasztas >= 0 && betegValasztas < betegek.Count)
            {
                Console.WriteLine("Válassz egy gyógyszert:");
                for (int i = 0; i < gyogyszerek.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {gyogyszerek[i].Nev} - {gyogyszerek[i].Hatas}");
                }
                int gyogyszerValasztas = Convert.ToInt32(Console.ReadLine()) - 1;
                if (gyogyszerValasztas >= 0 && gyogyszerValasztas < gyogyszerek.Count)
                {
                    Console.WriteLine(gyogyszerek[gyogyszerValasztas].Adagol(betegek[betegValasztas]));
                }
            }
        }
    }
}
       

