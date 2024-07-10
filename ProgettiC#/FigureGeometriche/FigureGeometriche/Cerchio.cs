using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Cerchio
    {
		//proprieta
		private double raggio;

		public double Raggio
		{
			get { return raggio; }
			set { 
				if (value <= 0) { throw new Exception("Raggio inserito non valido"); }
                raggio = value;
            }
		}
		public Cerchio(double raggio)
		{
			Raggio = raggio;
		}
		//metodi
		public double Diametro()
		{
			return 2 * Raggio;
		}
		public double Circonferenza()
		{
			return Diametro()*Math.PI;
		}
		public double Area()
		{
			return Math.PI * Math.Pow(Raggio, 2);
		}
        //metodi "usa e getta"

        public override string ToString()
        {
			return $"{nameof(Raggio)}={Raggio.ToString()}" +
				$", Diametro={Diametro()}" +
				$", Circonferenza={Circonferenza()}" +
				$", Area={Area()}";
        }
    }
}
