using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObject
{
    internal class Cliente
    {
        public string CodiceFiscale { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public DateOnly DataNascita { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(CodiceFiscale)}={CodiceFiscale}, {nameof(Cognome)}={Cognome}, {nameof(Nome)}={Nome}, {nameof(DataNascita)}={DataNascita.ToString()}}}";
        }
    }
}
