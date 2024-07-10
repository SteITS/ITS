//Visualizzare i dati di un array precaricato

Console.WriteLine("Array di stringhe");

string[] nomi = { "Giulia", "Pietro", "Babu", "Bibi","Papu","Bab"};

for (int i = 0; i < nomi.Length; i++)
{
    Console.WriteLine($"{i}: {nomi[i]}");
}
