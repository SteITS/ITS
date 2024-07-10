/*
 * Avendo prezzo e quantità del prodotto, calcolare il prezzo finale
*/
Console.Write("Inserisci prezzo articolo: ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Inserisci quantità articolo: ");
int n2 = int.Parse(Console.ReadLine());

double pf = n1*n2;

string msg = $"Risultati: " +
    $"\nPrezzo finale: {pf}";

Console.Write(msg);