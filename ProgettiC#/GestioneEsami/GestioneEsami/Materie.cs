using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami
{
    internal class Materie
    {
        public int Cod { get; set; }
        public string Denominazione { get; set; }
        public string Descrizione { get; set; }
        public int Ore { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Cod)}={Cod.ToString()}, {nameof(Denominazione)}={Denominazione}, {nameof(Descrizione)}={Descrizione}, {nameof(Ore)}={Ore.ToString()}}}";
        }
    }
}
