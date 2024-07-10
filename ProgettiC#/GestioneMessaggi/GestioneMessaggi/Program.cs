using Microsoft.VisualBasic;

namespace GestioneMessaggi
{
    internal class Program
    {
        
        static Messaggio InputDati()
        {
            Console.Write("Inserisci mittente: ");
            string mit = Console.ReadLine();
            Console.Write("Inserisci destinatario: ");
            string dest = Console.ReadLine();
            Console.Write("Inserisci oggetto: ");
            string ogg = Console.ReadLine();
            Console.Write("Inserisci testo messaggio: ");
            string text = Console.ReadLine();
            string prio = "";
            while (prio != "bassa" && prio != "media" && prio != "alta")
            {
                 Console.Write("Inserisci priorità messaggio (alta,media,bassa): ");
                 prio = Console.ReadLine().ToLower();
                 Console.WriteLine(prio);
            }

            Messaggio msg =new Messaggio(mit, dest, ogg,text, DateTime.Now, TimeOnly.FromDateTime(DateTime.Now),prio);
            Console.WriteLine(msg);
            return msg;
        }



        static void Main(string[] args)
        {
            List<Messaggio> elenco = new List<Messaggio>();
            elenco.Add(new Messaggio("Capo", "Mio", "Dopodomani", "ci sei dopodomani?", new DateTime(2021, 12, 12), new TimeOnly(11, 20, 10), "alta"));
            elenco.Add(new Messaggio("Matteo", "Grasso", "Hey", "è da tanto che non ci vediamo", new DateTime(2023, 10, 08), new TimeOnly(11, 20, 10), "bassa"));
            elenco.Add(new Messaggio("Marco", "Rosso", "bella", "Andiamo a bere?", new DateTime(2024, 04, 22), new TimeOnly(11, 20, 10), "bassa"));
            elenco.Add(new Messaggio("Alessio", "Tuo", "Partitina", "Fai una partitina?", new DateTime(2024, 07, 24), new TimeOnly(11, 20, 10), "media"));
            elenco.Add(new Messaggio("Ex", "Tua", "Ciao", "Mi manchi", new DateTime(2024, 01, 06), new TimeOnly(11, 20, 10), "alta"));
            elenco.Add(new Messaggio("Qualche", "Duno", "Offerta per fare soldi", "Vuoi fare soldi facili?", new DateTime(2024, 02, 07), new TimeOnly(11, 20, 10), "media"));

            Console.WriteLine("Gestione Messaggi!");

            string menu = "1 - Inserire un nuovo messaggio\n" +
                "2 - Cercare un messaggio per mittente\n" +
                "3 - Cercare un messaggio per destinatario\n" +
                "4 - Contare quanti messaggi sono stati inseriti dopo una certa data\n"+
                "5 - visualizzare l'elenco dei messaggi\n" +
                "6 - Uscita dal programma";
            int scelta;
            do
            {
                Console.WriteLine(menu);
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1: Console.WriteLine("Inserimento dati");
                        Messaggio msg=InputDati();
                        elenco.Add(msg);
                        break;
                    case 2:
                        Console.Write("Inserisci mittente: ");
                        string mit = Console.ReadLine();
                        Console.WriteLine(Messaggio.CercaMittente(elenco, mit)); break;
                    case 3:
                        Console.Write("Inserisci destinatario: ");
                        string dest = Console.ReadLine();
                        Console.WriteLine(Messaggio.CercaDestinatario(elenco, dest)); break;
                    case 4:
                        DateTime data;
                        Console.WriteLine("Inserisci data da cercare in format MM/DD/YYYY: ");
                        data = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Sono stati trovati: " +Messaggio.CercaData(elenco,data)+ "messaggi");
                        break;
                    case 5:
                        foreach(var item in elenco)
                        {
                        Console.WriteLine(item); 
                        }
                        break;
                    case 6:
                        Console.WriteLine("Programma terminato!");
                        break;
                    default: Console.WriteLine("Errore!"); break;

                }
            }
            while (scelta != 6);
        }
    }
}
