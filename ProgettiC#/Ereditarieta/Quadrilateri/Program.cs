namespace Quadrilateri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ereditarietà!");
            Quadrilatero q = new Quadrilatero(1.25, 2.5, 3.2, 1.4);
            Console.WriteLine(q);

            Rettangolo r = new Rettangolo(1.25, 3.2);
            Console.WriteLine(r);

            Quadrato q1 = new Quadrato(5);
            Console.WriteLine(q1);
        }
    }
}
