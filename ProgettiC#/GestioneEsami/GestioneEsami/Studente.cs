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
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public DateOnly Nascita { get; set; }
        public string Via { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string Luogo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Titolo { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Matricola)}={Matricola.ToString()}, {nameof(Cognome)}={Cognome}, {nameof(Nome)}={Nome}, {nameof(Nascita)}={Nascita.ToString()}, {nameof(Via)}={Via}, {nameof(Cap)}={Cap}, {nameof(Citta)}={Citta}, {nameof(Provincia)}={Provincia}, {nameof(Luogo)}={Luogo}, {nameof(Telefono)}={Telefono}, {nameof(Email)}={Email}, {nameof(Titolo)}={Titolo}}}";
        }
    }


}
