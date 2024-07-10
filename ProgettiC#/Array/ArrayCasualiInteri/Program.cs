// Generare un array di numeri interi casuali a dimensione casuali con le seguenti ipotesi:
// 1. dimensione dell'array : [inf,sup], inf e sup presi da input
// 2. riempimento dell'array: [inf1,sup1], con inf1 e sup1 presi in input

//stampare i seguenti risultati:
//1. posizione e valore dei num multipli di m, con m dato in input
//2. posizione e valore dei numeri primi generati
//3. media aritmetica dei soli numeri strettamente positivi
//0. esci

//usare le funzioni
//creare un menu testuale per scegliere una delle seguenti 
//operazioni

static bool IsPrimo(int numero)
{   if (numero < 1)
    { return false; }
    for (int i = 2; i < numero; i++)
        if (numero % i == 0)
            return false;
    return true;
}

static double MediaSoloPositivi(int[] x)
{
    int somma = 0;
    int contaPositivi = 0;
    for (int i = 2; i< x.Length;i++)
        if (x[i] > 0)
        {
            somma += x[i];
            contaPositivi++;
        }
    return (double)somma / contaPositivi;
}

static void RiempiArray(int[] numeri, int sup1, int inf1)
{
    Random random = new Random();
    for (int i = 0; i < numeri.Length; i++)
    {
        int rInt1 = random.Next(inf1,sup1);
        numeri[i] = rInt1;
    }
}

static void TrovaMultiplo(int[] x, int m)
{
    for(int i = 0;i < x.Length; i++)
    {
        if (x[i] % m == 0)
        {
            Console.WriteLine($"Multiplo di {m} pos{i}: {x[i]} ");
        }
    }
}

static void TrovaPrimo(int[] x)
{
    for (int i = 0;i<x.Length ; i++) 
    {
        if (IsPrimo(x[i]) == true)
        {
            Console.WriteLine($"Numero primo: pos{i}: {x[i]} ");
        }
    }
}


static void Main()
{
    Console.Write("Lunghezza minima array ");
    int inf = int.Parse(Console.ReadLine());
    Console.Write("Lunghezza massima array ");
    int sup = int.Parse(Console.ReadLine());
    Console.Write("num minimo ");
    int inf1 = int.Parse(Console.ReadLine());
    Console.Write("num massimo ");
    int sup1 = int.Parse(Console.ReadLine());

    Random random = new Random();
    int rInt = random.Next(inf, sup);
    int[] numeri = new int[rInt];

    RiempiArray(numeri, sup1, inf1);

    Console.Write("inserisci multiplo ");
    int m = int.Parse(Console.ReadLine());

    TrovaMultiplo(numeri, m);
    TrovaPrimo(numeri);
    double media = MediaSoloPositivi(numeri);
    Console.WriteLine($"Media aritmetica dei numeri positivi: {media}");

}
Main();