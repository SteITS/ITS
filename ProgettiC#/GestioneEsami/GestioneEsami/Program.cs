namespace GestioneEsami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studentis =new List<string>();
            Console.WriteLine("Gestione Esami!");

            string path = @"..\..\..\File\StudentiITS.csv";
            using (StreamReader streamReader = new StreamReader(path))
            {
                int counter = 0;
                while (streamReader.ReadLine() != null)
                {
                    studentis.Add(streamReader.ReadLine());
                }
                streamReader.Close();
            }

            List<string> esamis = new List<string>();

            string pathe = @"..\..\..\File\EsamiITS.csv";
            using (StreamReader streamReader = new StreamReader(pathe))
            {
                int counter = 0;
                while (streamReader.ReadLine() != null)
                {
                    esamis.Add(streamReader.ReadLine());
                }
                streamReader.Close();
            }

            List<string> materies = new List<string>();;

            string pathm = @"..\..\..\File\MaterieITS.csv";
            using (StreamReader streamReader = new StreamReader(pathm))
            {
                int counter = 0;
                while (streamReader.ReadLine() != null)
                {
                    materies.Add(streamReader.ReadLine());
                }
                streamReader.Close();
            }

            /*  path = @"..\..\..\file\MaterieITS.csv";
              sr = new StreamReader(path);
              string Materie = sr.ReadToEnd();
              sr.Close();
              path = @"..\..\..\file\EsamiITS.csv";
              sr = new StreamReader(path);
              string Esami = sr.ReadToEnd();
              sr.Close();
            */
            string menu = "1 - visualizzazione dell'elenco degli studenti con tutti e solo i dati disponibili\n" +
                "2 - visualizzazione dell'elenco delle materie con tutti e solo i dati disponibilin\n" +
                "3 - visualizzazione dell'elenco degli esami sostenuti: Nominativo studente, materia, data e voto\n" +
                "4 - Esci dal programma\n";
            int scelta;
            do
            {
                Console.WriteLine(menu);
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        foreach (var s in studentis) {  Console.WriteLine(s); }
                        break;
                    case 2:
                        foreach (var s in esamis) { Console.WriteLine(s); }
                        break;
                    case 3:
                        foreach (var s in materies) { Console.WriteLine(s); }
                        break;
                    case 4:
                        break;
                    default: Console.WriteLine("Errore!"); break;
                }
            }
            while (scelta != 4);
        }
    }
}
