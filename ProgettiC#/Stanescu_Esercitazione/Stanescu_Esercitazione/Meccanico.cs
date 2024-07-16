using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanescu_Esercitazione
{
    internal class Meccanico : Persona
    {
        public tip Tipologia { get; set; }
        public override double Tredicesima()
        {
            Stipendio = Stipendio * 1.93;
            return Stipendio;
        }

        public bool Equals(Meccanico mec)
        {
            if (Nome == mec.Nome && Cognome == mec.Cognome && Stipendio == mec.Stipendio && Tipologia == mec.Tipologia) 
            {
                return true;
            }
            else 
            {
                return false;
            }
                
        }

        public override string ToString()
        {
            return $"{{{nameof(Tipologia)}={Tipologia.ToString()},\n" +
                $" {nameof(Nome)}={Nome},\n" +
                $" {nameof(Cognome)}={Cognome},\n" +
                $" {nameof(Stipendio)}={Stipendio.ToString()}}}\n";
        }

    }
}
