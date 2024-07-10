/* imponibile +calcolo dell'iva(22%)=totale lordo
 ritenuta d'acconto(20% dell'imponibile)*/

//input

Console.Write("Inserisci imponibile: ");
double n1 = double.Parse(Console.ReadLine());

//operazione
double tl = n1 + (n1 *22 / 100);
double ra= n1 * 20 / 100;
double tf = tl - ra;

string msg = $"Risultati: " +
    $"\nImponibile: {n1:#.##}" +
    $"\nTotale lordo: {tl:#.##}" +
    $"\nRitenuta di acconto: {ra:#.##}" +
    $"\nTotale netto: {tf:#.##}";

Console.Write(msg);