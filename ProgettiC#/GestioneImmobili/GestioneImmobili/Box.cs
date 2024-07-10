using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImmobili
{
    internal class Box : Immobile
    {
        public int Auto { get; set; }

        public override string ToString()
        {
            return $"{{ {nameof(Cod)}={Cod}, {nameof(Indirizzo)}={Indirizzo}, {nameof(Cap)}={Cap.ToString()}, {nameof(Citta)}={Citta}, {nameof(Prezzo)}={Prezzo.ToString()}, {nameof(Metri)}={Metri} , {nameof(Auto)}={Auto.ToString()}}}";
        }
    }
}
