namespace FileTesto_Scrittura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\file\Frase.txt";
            
            Console.WriteLine("Inserisci la frase del giorno: ");
            string frase = Console.ReadLine();

            StreamWriter sw = new StreamWriter(path);
            sw.Write(frase);
            sw.Close();

            Console.WriteLine("Sucess!");
        }
    }
}
