using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Azienda
{
    internal class Dipendente
    {
        public string cognome { get; set; }
        public string nome { get; set; }
        public int pagaOraria { get; set; }
        public int oreLavoro { get; set; }
        public virtual int stipendio() 
        {
            return pagaOraria * oreLavoro;
        }

        public override string ToString()
        {
            return $"{{{nameof(cognome)}={cognome}, {nameof(nome)}={nome}, {nameof(pagaOraria)}={pagaOraria.ToString()}, {nameof(oreLavoro)}={oreLavoro.ToString()}}}";
        }
    }
}
