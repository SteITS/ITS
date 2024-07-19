namespace GestioneProveITS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Esame> esami = new List<Esame>
        {
            new Esame { Studente = "Studente1", ProvaTeorica = 28, ProvaPratica = 29, Colloquio = 38 },
            new Esame { Studente = "Studente2", ProvaTeorica = 25, ProvaPratica = 27, Colloquio = 35 },
            new Esame { Studente = "Studente3", ProvaTeorica = 30, ProvaPratica = 30, Colloquio = 40 },
            new Esame { Studente = "Studente4", ProvaTeorica = 22, ProvaPratica = 25, Colloquio = 33 },
            new Esame { Studente = "Studente5", ProvaTeorica = 27, ProvaPratica = 28, Colloquio = 37 },
            new Esame { Studente = "Studente6", ProvaTeorica = 24, ProvaPratica = 26, Colloquio = 34 },
            new Esame { Studente = "Studente7", ProvaTeorica = 29, ProvaPratica = 30, Colloquio = 39 },
            new Esame { Studente = "Studente8", ProvaTeorica = 26, ProvaPratica = 25, Colloquio = 36 },
            new Esame { Studente = "Studente9", ProvaTeorica = 23, ProvaPratica = 24, Colloquio = 32 },
            new Esame { Studente = "Studente10", ProvaTeorica = 21, ProvaPratica = 22, Colloquio = 30 }
        };

            var query1 = from tutti in esami 
                         select tutti;
            Console.WriteLine(string.Join("\n", query1));

            Console.WriteLine("------------------------");

            Console.WriteLine(string.Join("\n", query1.Average(x=> x.VotoFinale())));

            Console.WriteLine("------------------------");

            Console.WriteLine(string.Join("\n", query1.OrderByDescending(x=>x.VotoFinale())));
        }
    }
}
