// Dati in input giorno,mese e anno a>=1582
//restituire uno dei seguenti messaggi:
//Errore || gg/mm/aaaa

Console.Write("Inserisci la componente giorno: ");
int g = int.Parse(Console.ReadLine());

Console.Write("Inserisci la componente mese: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Inserisci la componente anno: ");
int a = int.Parse(Console.ReadLine());
string msg = "";

if (g < 1 || g > 31 || m < 1 || m > 12 || a < 1582)
    msg = "Errore";
else if (m == 4 || m == 6 || m == 9 || m == 11 && g > 30)
    msg = "Errore";
else if (m == 2 && g > 29)
    msg = "Errore";
else if (m == 2 && a % 100 == 0 && a % 400 != 0 && g == 29)
    msg = "Errore";
else if (m == 2 && a % 4 != 0 && g == 29)
    msg = "Errore";
else
{
    msg = $"" +
        (g < 10 ? "0" : "") + $"{g}/" +
        (m < 10 ? "0" : "") + $"{m}/{a}";
    Console.Write(msg);


}
