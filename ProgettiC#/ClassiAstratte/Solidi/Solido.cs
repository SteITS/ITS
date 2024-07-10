using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidi
{
    internal abstract class Solido
    {
        private Materiale materiale;

        //costruttore con passaggio di parametri
        public Solido(Materiale materiale)
        {
            this.materiale = materiale;
        }

        public double Peso()
        {
            return materiale.PesoSpecifico * Volume();
        }
        public abstract double Volume();
            
        public override string ToString()
        {
            return 
                $"materiale: {materiale}" +
                $", Peso: {Peso()}" +
                $", Volume: {Volume()}"
                ;
        }
    }
}
