namespace Azienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DipendentiBiz biz = new DipendentiBiz();
            Dipendente[] elenco = new Dipendente[10]
            {
                new Amministrativo{ cognome = "Avdiu", nome = "Eand", oreLavoro = 40, pagaOraria = 34, mansione = Mansione.RISORSEUMANE},
                new Amministrativo{ cognome = "Bibu", nome = "Babu", oreLavoro = 40, pagaOraria = 34, mansione = Mansione.CONTABILE},
                new Amministrativo{ cognome = "Josea", nome = "Enrico", oreLavoro = 40, pagaOraria = 34, mansione = Mansione.DIRETTORE},
                new Operaio{ cognome = "Poco", nome = "Xiaomi", oreLavoro = 40, pagaOraria = 34, settore = Settore.INSALLATORE},
                new Operaio{ cognome = "Samsung", nome = "Galaxy", oreLavoro = 40, pagaOraria = 34, settore = Settore.MANUTENTORE},
                new Operaio{ cognome = "AltGr", nome = "Ctrl", oreLavoro = 40, pagaOraria = 34, settore = Settore.MANUTENTORE},
                new Specializzato{ cognome = "Hanns", nome = "Monica", oreLavoro = 40, pagaOraria = 34, numeroMissioni = 4, indennitaMissione = 8, settore = Settore.INSALLATORE},
                new Specializzato{ cognome = "Despar", nome = "Carefur", oreLavoro = 40, pagaOraria = 34, numeroMissioni = 6, indennitaMissione = 8, settore = Settore.INSALLATORE},
                new Specializzato{ cognome = "Pronto", nome = "Pronto", oreLavoro = 40, pagaOraria = 34, numeroMissioni = 14, indennitaMissione = 18, settore = Settore.INSALLATORE},
                new Amministrativo{ cognome = "Ilcazzo", nome = "Gustavo", oreLavoro = 40, pagaOraria = 34, mansione = Mansione.RISORSEUMANE},
            };
            biz.dipendenti = elenco;

            string menu = "1 - Visualizzare l'elenco dei dipendenti con tutti i loro dati\n" +
                "2 - Visualizzare l'elenco degli amministrativi\n" +
                "3 - Visualizzare l'elenco degli operai\n" +
                "4 - Visualizzare l'elenco degli operai specializzati\n" +
                "5 - Visualizzare l'elenco degli operai che hanno stipendio superiore a 2000,00 euro\n" +
                "6 - Visualizzare l'elenco degli operai manutentori\n" +
                "7 - Visualizzare la scheda in dettaglio del direttore amministrativo\n" +
                "8 - Uscire dal programma\n";
            int scelta;

            do
            {
                Console.WriteLine(menu);
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1: Console.WriteLine(biz.StampaDipendenti()); break;
                    case 2: Console.WriteLine(biz.StampaAmministrativi()); break;
                    case 3: Console.WriteLine(biz.StampaOperai()); break;
                    case 4: Console.WriteLine(biz.StampaSpecializzati()); break;
                    case 5: Console.WriteLine(biz.StampaOperaiStipendio()); break;
                    case 6: Console.WriteLine(biz.StampaOperaiManutentori()); break;
                    case 7: Console.WriteLine(biz.StampaSchedaDirettoreAmministrativo()); break;
                    case 8: Console.WriteLine("Programma terminato"); break;
                    default: Console.WriteLine("Errore!"); break;

                }
            }
            while (scelta != 8);


        }
    }
}
