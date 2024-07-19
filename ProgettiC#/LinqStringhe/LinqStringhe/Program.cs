namespace LinqStringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinQ");
            string[] nomi = {"Pietro","Mario","Giulia","Francesca","Laura","Piero","antonio","Vito","Antonella","Giada","Rossella",
                "Simone","Saverio","Rosa","Michela","Andrea","Mattia","Ilaria","Alex","Vanessa","Ciro", "Elia", "Giuditta", "Stefano",
                "Alessandro", "Carlo", "Drusilla", "Dorothea", "Lucilla", "Marialuisa", "Marcolino", "Pietrangelo", "Ermenegildo",
                "Catalin","Mauro","Maria","Catalina","Fabio","Marco","Eand","May","Elisa","Piero","Lucia","Floriana","Pippo","Ramlethal","Baiken"};

            var count = nomi.Count();
            Console.WriteLine($"Numeri di elementi presenti: {count}");

            Console.WriteLine();

            Console.WriteLine("Stampa elenco nomi: ");
            var query1 = from tutti in nomi select tutti;
            Console.WriteLine(string.Join(", ", query1)); 
            

            Console.WriteLine();
            Console.WriteLine("Elenco dei nomi che iniziano con A");
            var query2 = from iniziaA in nomi
                         where iniziaA.StartsWith("A")
                         select iniziaA;
            Console.WriteLine(string.Join(", ",query2));

            Console.WriteLine();

            Console.WriteLine("Stampa elenco dei nomi in ordine alfabetico crescente");
            var query3 = from ordineAsc in nomi
                         orderby ordineAsc
                         select ordineAsc;
            Console.WriteLine(string.Join(", ", query3));

            Console.WriteLine();

            Console.WriteLine("Stampa elenco nomi con lunghezza pari a 7 e in ordine decrescente");
            var query4 = from lung7 in nomi
                         where lung7.Length == 7
                         orderby lung7 descending
                         select lung7;
            Console.WriteLine(string.Join (", ", query4));

            Console.WriteLine();

            Console.WriteLine("Stampa elenco nomi tutti in maiuscolo");
            var query5 = from maius in nomi
                         select maius.ToUpper();
            Console.WriteLine(string.Join(", ", query5));

        }
    }
}
