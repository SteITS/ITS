//Verificare se un numero intero è primo
Console.Write("Inserisci imponibile: ");
int n = int.Parse(Console.ReadLine());
int c = 0;
for (int i = 1; i <= n; i++)
{
    if(n%i == 0)
        c++;
}
if (c > 2)
    Console.Write($"Il numero {n} non è primo");
else
    Console.Write($"Il numero {n} è primo");