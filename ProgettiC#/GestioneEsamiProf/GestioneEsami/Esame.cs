using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami
{
    internal class Esame
    {
        public int MatricolaStudente { get; set; }
        public int CodiceMateria { get; set; }
        public DateTime Data { get; set; }
        public int Voto { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(MatricolaStudente)}={MatricolaStudente}, {nameof(CodiceMateria)}={CodiceMateria}, {nameof(Data)}={Data.ToString()}, {nameof(Voto)}={Voto.ToString()}}}";
        }
    }
}
