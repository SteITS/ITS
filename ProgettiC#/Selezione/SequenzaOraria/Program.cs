//Dati in input ora, minuti e secondi,
//restituire in output uno dei seguenti messaggi
//Errore || hh:mm:ss

using Microsoft.VisualBasic;

Console.Write("Inserisci la componente ora: ");
int h = int.Parse(Console.ReadLine());

Console.Write("Inserisci la componente minuti: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Inserisci la componente secondi: ");
int s = int.Parse(Console.ReadLine());
string msg = "";

if (h < 0 || h > 23 || m < 0 || m > 60 || s < 0 || s > 60){
    Console.WriteLine("Errore");
msg = "Errore";
}
else
{
    Console.Write($"{h}:{m}:{s}");
    msg = $"" +
        (h < 10 ? "0" : "") + $"{h}:" +
        (m < 10 ? "0" : "") + $"{m}:" +
        (s < 10 ? "0" : "") + $"{s}";
}

Console.WriteLine (msg);