namespace LinqObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinqObject");

            List<Cliente> clienti = new List<Cliente>
            {
                new Cliente { CodiceFiscale = "RSSMRA85M01H501Z", Cognome = "Rossi", Nome = "Mario", DataNascita = new DateOnly(1985, 1, 1) },
                new Cliente { CodiceFiscale = "BNCGPP90A41F205X", Cognome = "Bianchi", Nome = "Giuseppe", DataNascita = new DateOnly(1990, 10, 10) },
                new Cliente { CodiceFiscale = "VRDLGI95M01H501Y", Cognome = "Verdi", Nome = "Luigi", DataNascita = new DateOnly(1995, 3, 25) },
                new Cliente { CodiceFiscale = "FRNMNL88L09C352M", Cognome = "Ferrari", Nome = "Manuela", DataNascita = new DateOnly(1988, 12, 9) },
                new Cliente { CodiceFiscale = "NVRGNS80C13L219A", Cognome = "Neri", Nome = "Giovanni", DataNascita = new DateOnly(1980, 3, 13) },
                new Cliente { CodiceFiscale = "SLLCRL85E01F839S", Cognome = "Sala", Nome = "Carla", DataNascita = new DateOnly(1965, 5, 1) },
                new Cliente { CodiceFiscale = "CMPLRA90M01E258D", Cognome = "Campoli", Nome = "Lara", DataNascita = new DateOnly(1990, 8, 15) },
                new Cliente { CodiceFiscale = "RBBLBR95R01E202W", Cognome = "Rubbi", Nome = "Alberto", DataNascita = new DateOnly(1995, 11, 21) },
                new Cliente { CodiceFiscale = "SNTGPP80A01F839N", Cognome = "Santi", Nome = "Giuseppe", DataNascita = new DateOnly(1970, 1, 1) },
                new Cliente { CodiceFiscale = "VLLLBR75B10C351Y", Cognome = "Valli", Nome = "Laura", DataNascita = new DateOnly(1975, 2, 10) }
            };
            /*
                foreach (var cliente in clienti)
            {
                Console.WriteLine(cliente.ToString());
            
            foreach (var cliente in clienti)
            {
                if (cliente.DataNascita.Year>1980)
                    Console.WriteLine(cliente.ToString());
            }
            */
            Console.WriteLine("Stampa elenco clienti: ");
            var query1 = from CodFisc in clienti
                         select CodFisc.CodiceFiscale;
            Console.WriteLine(string.Join("\n", query1));

            Console.WriteLine("------------------------");
            var query2 = from Annata in clienti
                         where Annata.DataNascita.Year>1980
                         select Annata.Nome + " " + Annata.Cognome;
            Console.WriteLine(string.Join("\n", query2));

        }
        }
}
