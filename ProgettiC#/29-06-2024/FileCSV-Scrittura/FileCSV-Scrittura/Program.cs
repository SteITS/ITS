using System.Security.Cryptography.X509Certificates;

namespace FileCSV_Scrittura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona();

            Console.WriteLine("Cognome: ");
            persona.Cognome = Console.ReadLine();
            Console.WriteLine("Nome: ");
            persona.Nome = Console.ReadLine();
            Console.WriteLine("Data di nascita [gg/mm/aaaa]: ");
            persona.DataNascita = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Sesso [0 - Altro, 1 - F, 2 - M]: ");
            persona.Sesso = (Sesso)int.Parse(Console.ReadLine());
            Console.WriteLine("Luogo di nascita: ");
            persona.LuogoNascita = Console.ReadLine();

            string path = @"..\..\..\file\Persone.csv";

            StreamWriter sw = new StreamWriter(path);
            sw.Write(persona.FormatStampaCSV());
            sw.Close();

            Console.WriteLine("Operazione eseguita con successo");
        }
    }
}
