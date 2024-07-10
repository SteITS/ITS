using System.Security.Cryptography.X509Certificates;

namespace FileCSV_Lettura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\file\Persone.csv";
            StreamReader sr = new StreamReader(path);
            string testo = sr.ReadToEnd();
            sr.Close();

            string[] linee = testo.Split("\n");
            List<Persona> elenco = new List<Persona>();

            foreach (var linea in linee)
            {
                var persona = new Persona();
                string[] dati = linea.Split(";");
                persona.Cognome = dati[0];
                persona.Nome = dati[1];
                persona.DataNascita = DateOnly.Parse(dati[2]);
                persona.LuogoNascita = dati[3];
                switch (dati[4])
                {
                    case "ALTRO": persona.Sesso = Sesso.Altro; break;
                    case "F": persona.Sesso = Sesso.F; break;
                    case "M": persona.Sesso = Sesso.M; break;
                }
                elenco.Add(persona);
            }

            Console.WriteLine(string.Join("\n", elenco));
            //Console.WriteLine($"Dati della persona: {persona}");
            //Console.WriteLine($"Età della persona: {persona.Eta()}");



          
           

            Console.WriteLine("Operazione eseguita con successo");
        }
    }
}
