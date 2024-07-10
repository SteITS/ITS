// Somma di due interi, dati in input
Console.Write("Somma di due numeri interi \n");

//input
int n1, n2;

Console.Write("n1: \n");
string tmp = Console.ReadLine();
n1= int.Parse(tmp);

Console.Write("n2: ");
tmp = Console.ReadLine();
n2 = int.Parse(tmp);

//operazioni da eseguire

int somma = n1 + n2;

//output

Console.Write(n1+" + "+n2+" = "+somma+"\n");
Console.WriteLine("Somma: {0}", somma);
Console.WriteLine("{0}+{1}+{2}", n1, n2, somma);

Console.WriteLine($"{n1}+{n2}={somma}"); 