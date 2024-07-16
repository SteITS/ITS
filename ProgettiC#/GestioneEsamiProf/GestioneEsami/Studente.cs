using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami
{
    internal class Studente
    {
        public int Matricola { get; set; }
        public string? Cognome { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascita { get; set; }
        public string? LuogoNascita { get; set; }
        public string? Via { get; set; }
        public string? Cap { get; set; }
        public string? Citta { get; set; }
        public string? SiglaProvincia { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? TioloStudio { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Matricola)}={Matricola.ToString()}, {nameof(Cognome)}={Cognome}, {nameof(Nome)}={Nome}, {nameof(DataNascita)}={DataNascita.ToString()}, {nameof(LuogoNascita)}={LuogoNascita}, {nameof(Via)}={Via}, {nameof(Cap)}={Cap}, {nameof(Citta)}={Citta}, {nameof(SiglaProvincia)}={SiglaProvincia}, {nameof(Telefono)}={Telefono}, {nameof(Email)}={Email}, {nameof(TioloStudio)}={TioloStudio}}}";
        }
    }
}
