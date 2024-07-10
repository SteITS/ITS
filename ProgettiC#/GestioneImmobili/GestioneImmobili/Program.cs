namespace GestioneImmobili
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ImmobileBiz biz = new ImmobileBiz();
            Immobile[] elenco = new Immobile[6]
            {
            new Box{ Cod = "Bo1", Indirizzo = "Corso Pippo 12", Cap=10100, Citta="Torino", Prezzo=10000, Auto=2,Metri=30},
            new Box{ Cod = "Bo2", Indirizzo = "Corso Baudo 15", Cap=10101, Citta="Torino", Prezzo=15000, Auto=3,Metri=40},
            new Appartemento{ Cod = "Ap1", Indirizzo = "Via Giuseppino 23", Cap=10101, Citta="Genova", Prezzo=50000, Vani=6, Bagni=2,Metri=70},
            new Appartemento{ Cod = "Ap2", Indirizzo = "Via Cesariano 44", Cap=15021, Citta="Roma", Prezzo=100000, Vani=10, Bagni=3,Metri=80},
            new Villa{ Cod = "Vi1", Indirizzo = "Via Cesariano 44", Cap=15021, Citta="Pianezza", Prezzo=1000000, Vani=23 ,Bagni=5, Giardino=1000,Metri=350},
            new Villa{ Cod = "Vi2", Indirizzo = "Via Cesariano 44", Cap=15021, Citta="Napoli", Prezzo=500000, Vani=25, Bagni=7, Giardino=10000,Metri=500}
            };
            biz.Immobile = elenco;

            Console.WriteLine("Gestione Immobili!");
            string menu = "\n1 - visualizzazione del numero di immobili\n" +
                "2 - visualizzazione dell'elenco degli immobili\n" +
                "3 - visualizzazione dell'elenco di appartamenti\n" +
                "4 - visualizzazione dell'elenco delle ville\n" +
                "5 - visualizzazione dell'elenco dei box\n" +
                "6 - visualizzazione dell'elenco degli immobili ubicati in una certa città\n" +
                "7 - visualizzazione della scheda di dettaglio di un certo immobile individuato tramite codice\n" +
                "8 - Uscita dal programma";
            int scelta;
            do
            {
                Console.WriteLine(menu);
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Numero Immobili: ");
                        Console.Write( biz.ContaImmobili()+"\n");
                        break;
                    case 2:
                        Console.Write("Lista Immobili: \n");
                        Console.Write( biz.StampaImmobili());
                        break;
                    case 3:
                        Console.Write("Lista Appartamenti: \n");
                        Console.Write(biz.StampaAppartamenti());
                        break;
                    case 4:
                        Console.WriteLine("Lista Ville: \n");
                        Console.Write(biz.StampaVille());
                        break;
                    case 5:
                        Console.WriteLine("Lista Box: \n");
                        Console.Write(biz.StampaBox());
                        break;
                    case 6:
                        Console.WriteLine("Inserisci Citta'");
                        string cit = Console.ReadLine();
                        cit = char.ToUpper(cit[0]) + cit.Substring(1);
                        Console.WriteLine(biz.StampaPerCitta(cit));
                        break;
                    case 7:
                        Console.WriteLine("Inserisci Codice");
                        string cod = Console.ReadLine();
                        Console.WriteLine(biz.StampaPerCodice(cod));
                        break;
                    case 8:
                        Console.Write("Uscita dal programma... ");
                        break;
                    default: Console.WriteLine("Errore!"); break;

                }
            }
            while (scelta != 8);
        }
    }
}
