//Dato in input un numero intero stabilire se è pari o dispari

Console.Write("Inserisci numero: ");
int n1 = int.Parse(Console.ReadLine());

if (n1%2 == 0)
{
    Console.Write($"{n1} Numero pari");
}
else
{
    Console.Write($"{n1} Numero dispari");
}