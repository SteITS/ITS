using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImmobili
{
    internal class Immobile
    {
        public string Cod { get; set; }
        public string Indirizzo { get; set; }
        public int Cap { get; set; }
        public string Citta { get; set; }
        public double Prezzo  { get; set; }
        public int Metri { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Cod)}={Cod}, {nameof(Indirizzo)}={Indirizzo}, {nameof(Cap)}={Cap.ToString()}, {nameof(Citta)}={Citta}, {nameof(Prezzo)}={Prezzo.ToString()} , {nameof(Metri)}={Metri}}}";
        }
    }
}
