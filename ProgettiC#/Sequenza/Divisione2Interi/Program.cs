

Console.Write("Inserisci n1: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Inserisci n2: ");
int n2 = int.Parse(Console.ReadLine());



int div = n1 / n2;
//Console.WriteLine($"{n1}/{n2}={div} intero");

int res= n1 % n2;
//Console.WriteLine($"{n1}/{n2}={div} resto");

double divf = (double)n1 / n2;
//Console.WriteLine($"{n1}/{n2}={divf} reale");

string msg = $"Risultati: "+
    $"\nQuoziente intero: {div}"+
    $"\nResto: {res}"+
    $"\nQuoziente reale: {divf}";

Console.WriteLine(msg);