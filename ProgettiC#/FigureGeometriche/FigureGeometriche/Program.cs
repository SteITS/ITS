namespace FigureGeometriche
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Quadrato q = new Quadrato();
            q.Lato = 12;
            Console.WriteLine(q);

            Cerchio c = new Cerchio(1.2);
            Console.WriteLine(c);

            Rettangolo r = new Rettangolo()
            {
                Lato = 1.2,
                Altezza = 3.1
            };
            Console.WriteLine(r);

            Triangolo t = new Triangolo() { Lato1 = 2.3, Lato2 = 3.2, Lato3 = 2.2 };
            Console.WriteLine(t);

            Punto a = new Punto("A", 1.2, 2.3);
            Console.WriteLine(a.Stampa());
            Punto b = new Punto("B", -1.2, -1.1);
            Console.WriteLine(b);

            Console.WriteLine($"AB={a.Distanza(b)}");
            Console.WriteLine($"BA={b.Distanza(a)}");

            Punto z = new Punto(1, 6);
            Console.WriteLine(z.Stampa());

            //Costruzione del triangolo tramite tre punti
            Triangolo t1 = new Triangolo(a, b, z);
            Console.WriteLine(t1);
            
        }
    }
}
