using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImmobili
{
    internal class Appartemento : Immobile
    {
        public int Vani { get; set; }
        public int Bagni { get; set; }

        public override string ToString()
        {
            return $"{{ {nameof(Cod)}={Cod}, {nameof(Indirizzo)}={Indirizzo}, {nameof(Cap)}={Cap.ToString()}, {nameof(Citta)}={Citta}, {nameof(Prezzo)}={Prezzo.ToString()}, {nameof(Metri)}={Metri}, {nameof(Vani)}={Vani.ToString()}, {nameof(Bagni)}={Bagni.ToString()} }}";
        }
    }

}
