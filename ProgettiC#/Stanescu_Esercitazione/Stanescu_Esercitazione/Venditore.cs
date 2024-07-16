using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanescu_Esercitazione
{
    internal class Venditore : Persona
    {
        public sett Settore { get; set; }
        public override double Tredicesima()
        {
            Stipendio = Stipendio * 1.91;
            return Stipendio;
        }
        public Venditore Clone()
        {
            return (Venditore)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{{{nameof(Settore)}={Settore.ToString()},\n" +
                $" {nameof(Nome)}={Nome},\n" +
                $" {nameof(Cognome)}={Cognome},\n" +
                $" {nameof(Stipendio)}={Stipendio.ToString()}}}\n";
        }
    }
}
