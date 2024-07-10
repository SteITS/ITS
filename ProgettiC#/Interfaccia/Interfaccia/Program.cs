namespace Interfaccia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uso di Interface!");

            try
            {
                //n istruzioni
                //3 exception
                Class1 c1 = new Class1();
                c1.Metodo4();
            }catch(NotImplementedException e) { Console.WriteLine(e.Message); }
            catch(NullReferenceException e) { Console.WriteLine(e.Message); }
            catch(IndexOutOfRangeException e) { Console.WriteLine(e.Message); }
            catch(Exception e) { Console.WriteLine(e.ToString()); }
            finally { }

        }
    }
}
