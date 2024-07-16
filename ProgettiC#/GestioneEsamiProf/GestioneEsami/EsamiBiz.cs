using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami
{
    internal class EsamiBiz
    {
        public List<Esame> Elenco { get; set; }

        public EsamiBiz(List<Esame> elenco)
        {
            Elenco = elenco ?? throw new ArgumentNullException(nameof(elenco));
        }

        public string StampaElenco()
        {
            return string.Join(Environment.NewLine, Elenco);
        }
    }
}
