using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami
{
    internal class StudentiBiz
    {
        public List<Studente> Elenco { get; set; }

        public StudentiBiz(List<Studente> elenco)
        {
            Elenco = elenco ?? throw new ArgumentNullException(nameof(elenco));
        }

        public string StampaElenco()
        {
            return string.Join(Environment.NewLine, Elenco);
        }
    }
}
