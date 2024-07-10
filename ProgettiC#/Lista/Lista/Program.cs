using FigureGeometriche;
using System.Collections;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uso di ArrayList!");

            //lista di oggetti
            var lista = new ArrayList();

            //capacita
            Console.WriteLine($"Capacità: {lista.Capacity}");

            //dimensione
            Console.WriteLine($"Dimensione: {lista.Count}");

            //aggiunta di un elemento alla lista
            lista.Add("Piero");
            lista.Add(12);
            lista.Add(12.5);
            lista.Add(true);
            lista.Add("a");
            lista.Add(new Quadrato() { Lato = 1.25 });

            foreach (var i in lista)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            lista.RemoveAt(2);

        }
    }
}
