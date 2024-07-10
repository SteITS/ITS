using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Rettangolo
    {
        private double lato;
        private double altezza;

        public double Lato
        {
            get { return lato; }
            set
            {
                if (value <= 0) { throw new Exception("Raggio inserito non valido"); }
                lato = value;
            }
        }
        public double Altezza
        {
            get { return altezza; }
            set
            {
                if (value <= 0) { throw new Exception("Raggio inserito non valido"); }
                altezza = value;
            }
        }


        public double Perimetro()
        {
            return (2 * Lato) + (2 * Altezza);
        }
        public double Area()
        {
            return Lato * Altezza / 2;
        }
        public double Diagonale()
        {
            return Math.Sqrt(Math.Pow(Lato, 2) + Math.Pow(Altezza, 2));
        }
    }
}
