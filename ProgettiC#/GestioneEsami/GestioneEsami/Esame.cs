using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami
{
    internal class Esame
    {
        public DateOnly Data { get; set; }
        public int Voto { get; set; }
        public int Matricola { get; set; }
        public int Cod { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Data)}={Data.ToString()}, {nameof(Voto)}={Voto.ToString()}, {nameof(Matricola)}={Matricola.ToString()}, {nameof(Cod)}={Cod.ToString()}}}";
        }
    }

}
