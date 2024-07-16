namespace GestioneEsami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestione Esami!");

            string pathStudentiITS = @"..\..\..\file\StudentiITS.csv";
            string pathMaterieITS = @"..\..\..\file\MaterieITS.csv";
            string pathEsamiITS = @"..\..\..\file\EsamiITS.csv";

            var studentiITS = MyLibrary.LoadStudentiCSV(pathStudentiITS);
            var materieITS = MyLibrary.LoadMaterieCSV(pathMaterieITS);
            var esamiITS = MyLibrary.LoadEsamiCSV(pathEsamiITS);

            var studentiBiz = new StudentiBiz(studentiITS);
            var materieBiz = new MaterieBiz(materieITS);
            var esamiBiz = new EsamiBiz(esamiITS);

            string msg = "Scegli una delle seguenti opzioni:" +
                Environment.NewLine + 
                "1 - visualizza elenco studenti" +
                Environment.NewLine + 
                "2 - visualizza elenco materie" +
                Environment.NewLine + 
                "3 - visualizza elenco esami" +
                Environment.NewLine + 
                "4 - esci dal programma" +
                Environment.NewLine +
                Environment.NewLine +
                "Scelta: ";

            int scelta = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(msg);
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1: Console.WriteLine(studentiBiz.StampaElenco()); break;
                    case 2: Console.WriteLine(materieBiz.StampaElenco()); break;
                    case 3: Console.WriteLine(esamiBiz.StampaElenco()); break;
                    case 4: Console.WriteLine("Programma terminato!"); break;
                    default: Console.WriteLine("Errore! Dato inserito non corretto"); break;
                }
            } while (scelta != 4);
        }
    }
}
