﻿namespace FileTesto_Lettura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\file\Frase.txt";

            StreamReader sr = new StreamReader(path);
            string frase = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(frase);

        }
    }
}
