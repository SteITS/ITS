namespace LinqLambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            //estremi dell'intervallo
            Console.Write("Inserisci estremo inferiore: ");
            int inf = Convert.ToInt32(Console.ReadLine());
            int sup;
            do
            {
                Console.Write("Inserisci estremo superiore: ");
                sup = Convert.ToInt32(Console.ReadLine());
                if (inf >= sup)
                    Console.WriteLine("Estremo sup non valido!");
                else
                    break;
            } while (true);
            int tappo;
            do
            {
                Console.Write($"Inserisci il tappo terminatore della generazione della sequenza [{inf},{sup}]: ");
                tappo = Convert.ToInt32(Console.ReadLine());
                if (tappo < inf || tappo > sup)
                    Console.WriteLine($"Errore! Devi inserire un numero appartenente all'intervallo [{inf},{sup}]");
                else
                    break;
            } while (true);
            //creo la lista
            var lista = new List<int>();
            //riempio la lista - l'ultimo numero della lista deve essere il tappo
            int estratto;
            do
            {
                estratto = random.Next(inf, sup + 1);
                lista.Add(estratto);
            } while (estratto != tappo);

            var query1 = from tutti in lista
                         select tutti;
            Console.WriteLine(string.Join(",", query1));

            Console.WriteLine("\n");

            var query2 = from conta in lista
                         select conta;
            Console.WriteLine(string.Join(",", query2.Count()));

            Console.WriteLine("\n");

            var query3 = from max in lista
                         select max;
            Console.WriteLine(string.Join(",", query3.Max()));

            Console.WriteLine("\n");

            var query4 = from min in lista
                         select min;
            Console.WriteLine(string.Join(",", query4.Min()));

            Console.WriteLine("\n");

            var query5 = from somma in lista
                         select somma;
            Console.WriteLine(string.Join(",", query5.Sum()));

            Console.WriteLine("\n");

            var query6 = from sommaPos in lista
                         where sommaPos >= 0
                         select sommaPos;
            Console.WriteLine(string.Join(",", query6.Sum()));

            Console.WriteLine("\n");

            var query7 = from dis in lista
                         where dis % 2 != 0
                         select dis;
            Console.WriteLine(string.Join(",", query7));

            Console.WriteLine("\n");

            var query8 = from mul3 in lista
                         where mul3 % 3 == 0
                         select mul3;
            Console.WriteLine(string.Join(",", query8));




        }
    }
}
