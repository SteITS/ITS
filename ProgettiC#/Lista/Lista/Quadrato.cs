using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Quadrato
    {
        //attributi o campi
        private double lato;

        //proprieta
        public double Lato
        {
            get { return lato; }
            set {
                if (value <= 0)
                    throw new Exception("Lato non valido!");
                lato = value; }
        }



        //public double GetLato() {  return lato; }
        //public void SetLato(double lato) {
        //    if (lato <= 0)
        //        throw new Exception("Lato non valido!");
        //    this.lato = lato; 

        //}

        //costruttori

        //metodi
       public double Perimetro()
        {
            return lato * 4;
        }
        public double Area()
        { return lato*lato; }
        
        public double Diagonale()
        { return lato * Math.Sqrt(2); }

        public override string ToString() {
            return $"Lato: {Lato}" +
                $". Perimetro: {Perimetro()}" +
                $", Area: {Area()}" +
                $", Diagonale: {Diagonale()}";
        }
    }
}
