using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaccia
{
    internal class Class1 : Interfaccia,Interfaccia2,InterfacciaGenerale
    {
        public string Metodo1()
        {
            return "Nulla";
        }

        public int Metodo2()
        {
            return 155;
        }

        public void Metodo3()
        {
            Console.Write("Metodo 3");
        }

        public double Metodo4()
        {
            throw new NotImplementedException("Metodo non implementato");
        }

        public bool Metodo5(int numero)
        {
            throw new NotImplementedException();
        }
    }
}
