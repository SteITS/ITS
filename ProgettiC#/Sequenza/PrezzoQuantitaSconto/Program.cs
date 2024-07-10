/*
 Dati in input il prezzo, la quantità e la percentuale di sconto
 di un prodotto, calcolare il totale non scontato, lo sconto
 effetuato e il totale scontato. visualizzare tutti i ris


*/

//input
Console.Write("Inserisci prezzo articolo: ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Inserisci quantità articolo: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Inserisci percentuale sconto: ");
int s = int.Parse(Console.ReadLine());

//operazioni

double pf = n1 * n2;
double cs = pf * ((double)s/100);
double ps = pf-cs;

//output

string msg = $"Risultati: " +
    $"\nTotale: {pf:#.##}" +
    $"\nSconto effetuato: {cs:#.##}" +
    $"\nPrezzo scontato: {ps:#.##}";

Console.Write(msg);