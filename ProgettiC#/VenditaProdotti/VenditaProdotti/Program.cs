namespace VenditaProdotti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vendita Prodotti!");

            ProdottoBiz biz = new ProdottoBiz();
            Prodotto[] elenco = new Prodotto[10] {
                new Alimentare{ codice = 1 , nome = "Pane", prezzo = 1, data = new DateTime (2024,06,2),scadenza = new DateTime(2024,06,10) },
                new Alimentare{ codice = 2 , nome = "Mela", prezzo = 1.6, data = new DateTime (2024,06,2),scadenza = new DateTime(2024,06,15) },
                new Alimentare{ codice = 3 , nome = "Pera", prezzo = 2, data = new DateTime (2024,06,2),scadenza = new DateTime(2024,07,21) },
                new Alimentare{ codice = 4 , nome = "Prosciutto", prezzo = 3.2, data = new DateTime (2024,06,2),scadenza = new DateTime(2024,06,16) },
                new Alimentare{ codice = 5 , nome = "Arancia", prezzo = 2.3, data = new DateTime (2024,06,2),scadenza = new DateTime(2024,07,15) },

                new Oggetto{ codice = 6 , nome = "Giocattolo", prezzo = 10, data = new DateTime (2024,06,2),materiale="plastica" },
                new Oggetto{ codice = 7 , nome = "Tastiera", prezzo = 15, data = new DateTime (2024,06,2),materiale="plastica" },
                new Oggetto{ codice = 8 , nome = "Schermo", prezzo = 35, data = new DateTime (2024,06,2),materiale="Vetro" },
                new Oggetto{ codice = 9 , nome = "Mouse", prezzo =5, data = new DateTime (2024,06,2),materiale="plastica" },
                new Oggetto{ codice = 10 , nome = "Borraccia", prezzo = 11, data = new DateTime (2024,06,2),materiale="Alluminio" }
            };
            biz.prodotto = elenco;

            string menu = "1 - Visualizzare l'elenco dei prodotti\n" +
                "2 - Visualizzare l'elenco dei prodotti in scadenza (minore di 10 giorni)\n" +
                "3 - Visualizzare l'elenco delle materie prime con cui è fatto il prodotto\n" +
                "4 - Uscire dal programma\n";
            int scelta;
            do
            {
                Console.WriteLine(menu);
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1: Console.WriteLine(biz.StampaProdotti()); break;
                    case 2: Console.WriteLine(biz.StampaScadenza()); break;
                    case 3: Console.WriteLine(biz.StampaMateriale()); break;
                    case 4: Console.WriteLine("Programma terminato"); break;
                    default: Console.WriteLine("Errore!"); break;

                }
            }
            while (scelta != 4);
        }

    }
}
