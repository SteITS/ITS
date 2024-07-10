//Simulare il lancio di un dado a 6 facce per n volte.
//Calcolare la frequenza delle uscite (in percentuale)
//Non usare gli array

using System;

Random random = new Random();
Console.Write("Quante volte vuoi lanciare il dado? ");
int r = int.Parse(Console.ReadLine());
int n = 0;
int c1=0, c2=0, c3=0, c4=0,c5=0, c6=0;
for (int i = 0; i < r; i++)
{
    n = random.Next(1, 7);
    if (n == 1) c1++;
    if (n == 2) c2++;
    if (n == 3) c3++;
    if (n == 4) c4++;
    if (n == 5) c5++;
    if (n == 6) c6++;
}

Console.Write($"1: {100 * c1 / r}%\n2: {100 * c2 / r}%\n3: {100 * c3 / r}%\n4: {100 * c4 / r}%\n5: {100 * c5 / r}%\n6: {100 * c6 / r}%\n" );