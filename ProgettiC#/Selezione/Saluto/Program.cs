//Visualizzare uno dei seguenti messaggi:
//Buongiorno, Buon pomeriggio, Buona sera, Buona notte
// 6-14   14-18  18-22 22-6,errore

Console.WriteLine("Saluti!");

Console.Write("Inserisci la componente ora: ");
int h = int.Parse(Console.ReadLine());

if (h < 0 || h > 23)
    Console.WriteLine("Errore");
else if (h >= 6 && h < 14)
    Console.WriteLine("Buongiorno");
else if (h >= 14 && h < 18)
    Console.WriteLine("Buon pomeriggio");
else if (h >= 18 && h < 22)
    Console.WriteLine("Buonasera");
else
    Console.WriteLine("Buonanotte");

DateTime localDate = DateTime.Now;
Console.Write(localDate.ToString());