using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami
{
    internal class Materia
    {
        public int Codice { get; set; }
        public string? Denominazione { get; set; }
        public string? Descrizione { get; set; }
        public int NumeroOre {  get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Codice)}={Codice.ToString()}, {nameof(Denominazione)}={Denominazione}, {nameof(Descrizione)}={Descrizione}, {nameof(NumeroOre)}={NumeroOre.ToString()}}}";
        }
    }
}
