﻿//simulare l'estrazione dei numeri del lotto di una ruota qualsiasi
//numeri casuali [1,90], non ordinati
//NOTA: non si possono usare gli array

Random random = new Random();

int e1, e2, e3, e4, e5;

e1=random.Next(0,90)+1;
do {
    e2 = random.Next(0, 90) + 1;
}while (e1 == e2);
do {
    e3 = random.Next(0, 90) + 1;
} while (e1 == e3 || e2==e3);
do
{
    e4 = random.Next(0, 90) + 1;
} while (e1 == e4 || e2 == e4 || e3==e4);
do
{
    e5 = random.Next(0, 90) + 1;
} while (e1 == e5 || e2==e5 || e3==e5 || e4==e5);

Console.WriteLine($"{e1} {e2} {e3} {e4} {e5}");