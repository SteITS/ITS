//Inserire e visualizzare un elenco di numeri interi
//usare gli array

Console.WriteLine("Array di numeri interi");

Console.Write("Numeri interi da inserire: ");
int n = int.Parse(Console.ReadLine());
//dichiarazione
int[] numeri = new int[n];
//input
for (int i = 0; i <numeri.Length; i++)
{
    Console.Write("Inserisci un numero intero: ");
    numeri[i] = int.Parse(Console.ReadLine()); //scrittura in una cella di un array
}
//output
Console.WriteLine("Stampa dei valori memorizzati");
for (int i = 0;i < numeri.Length; i++)
{
    Console.WriteLine($"{i}: {numeri[i]}");
}