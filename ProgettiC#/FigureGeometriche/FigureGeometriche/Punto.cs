using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Punto
    {
        //P(2,3)
        // (2,3) con etichetta non configurata
        public string? Etichetta { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        //overloading
        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Punto(string? etichetta, double x, double y)
        {
            Etichetta = etichetta;
            X = x;
            Y = y;
        }
        //metodi
        public double Distanza()
            //Metodo per calcolare la distanza dall'origine degli assi
        {
            return Distanza(new Punto(0, 0));
        }

        public double Distanza(Punto punto)
        {
            return Math.Sqrt(Math.Pow(X-punto.X, 2)+Math.Pow(Y-punto.Y, 2));
        }

        public string Stampa()
        {
            //P(x,y),x(x,y)
            return $"{Etichetta}({X};{Y})";
        }

        public override string ToString()
        {
            return $"{{{nameof(Etichetta)}={Etichetta}" +
                $", {nameof(X)}={X.ToString()}" +
                $", {nameof(Y)}={Y.ToString()}}}" +
                $", Distanza dall'origine degli assi= {Distanza()}";
        }
    }
}
