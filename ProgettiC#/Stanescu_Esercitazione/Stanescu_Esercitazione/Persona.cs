using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanescu_Esercitazione
{
    internal abstract class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public double Stipendio { get; set; }

        public abstract double Tredicesima();

        public override string ToString()
        {
            return $"{{{nameof(Nome)}={Nome},\n" +
                $" {nameof(Cognome)}={Cognome},\n" +
                $" {nameof(Stipendio)}={Stipendio.ToString()}}}\n";
        }
    }
}
