using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImmobili
{
    internal class Villa:Appartemento
    {
        public int Giardino { get; set; }

        public override string ToString()
        {
            return $"{{ {nameof(Vani)}={Vani.ToString()}, {nameof(Bagni)}={Bagni.ToString()}, {nameof(Cod)}={Cod}, {nameof(Indirizzo)}={Indirizzo}, {nameof(Cap)}={Cap.ToString()}, {nameof(Citta)}={Citta}, {nameof(Prezzo)}={Prezzo.ToString()},{nameof(Metri)}={Metri},{nameof(Giardino)}={Giardino.ToString()}}}";
        }
    }
}
