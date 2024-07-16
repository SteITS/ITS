namespace Stanescu_Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VenditoriBiz venditoriBiz = new VenditoriBiz();
            OrdiniBiz ordiniBiz = new OrdiniBiz();

            Venditore venditore1 = new Venditore { Nome = "Mario", Cognome = "Rossi", Stipendio = 3000, Settore = sett.Auto };
            Venditore venditore2 = new Venditore { Nome = "Luigi", Cognome = "Bianchi", Stipendio = 2800, Settore = sett.Auto };
            Venditore venditore3 = new Venditore { Nome = "Anna", Cognome = "Verdi", Stipendio = 3200, Settore = sett.Auto };
            //NON FUNZIONA :D
            venditoriBiz.AggiungiVenditore(venditore1);
            venditoriBiz.AggiungiVenditore(venditore2);
            venditoriBiz.AggiungiVenditore(venditore3);



            Meccanico meccanico1 = new Meccanico { Nome = "Giovanni", Cognome = "Neri", Stipendio = 2500, Tipologia = tip.Carrozzeria };
            Meccanico meccanico2 = new Meccanico { Nome = "Paolo", Cognome = "Rossi", Stipendio = 2700, Tipologia =tip.Meccanica };
                    
            List<Meccanico> meccanici = new List<Meccanico>();

            string menu = "\n1 - Visualizza l'elenco dei venditori\n" +
                "2 - Visualizzare l’elenco dei meccanici\n" +
                "3 - Stampa di un certo ordine, da cercare in base al codice ordine dato in input\n" +
                "4 - Visualizzare l'elenco degli ordini effettuato da un certo venditore. Da input viene fornito il cognome del venditore\n" +
                "5 - Visualizzare l'elenco degli ordine in cui è presente un certo prodotto, da cercare in base al codice prodotto dato in input\n" +
                "6 - Uscita dal programma";
            int scelta;
            do
            {
                Console.WriteLine(menu);
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Elenco Venditori: ");
                        foreach (Venditore item in venditoriBiz.ElencoVenditori)
                        { 
                        Console.WriteLine(item); 
                        }
                        break;
                    case 2:
                        Console.Write("Elenco Meccanici: \n");
                         foreach(Meccanico item in meccanici)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        Console.Write("Ordine in base al codice Ordine \n");
                        Console.WriteLine("Inserisci codice da cercare");
                        string cod = Console.ReadLine();
                        foreach(Ordine item in ordiniBiz.ElencoOrdine)
                        {
                            if(item.CodiceOrdine == cod)
                                Console.WriteLine(item);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ordini In base al venditore: \n");
                        Console.WriteLine("Inserisci Cognome Venditore da cercare");
                        string vend = Console.ReadLine();
                        foreach(Venditore item in venditoriBiz.ElencoVenditori)
                        {
                            if(item.Cognome == vend)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ordine in base al codice prodotto: \n");
                        Console.WriteLine("Inserisci Codice Prodotto da cercare");
                        int codp = int.Parse(Console.ReadLine());
                        foreach(var ordine in ordiniBiz.ElencoOrdine)
                        {
                            foreach(var prodotto in ordine.ElencoProdotti)
                            {
                                if(prodotto.Codice == codp)
                                {
                                    Console.WriteLine(prodotto);
                                }
                            }
                        }
                        break;
                    case 6:
                        Console.Write("Uscita dal programma... ");
                        break;

                        
                    default: Console.WriteLine("Errore!"); break;

                }
            }
            while (scelta != 6);
        }
    }
}
