using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEsami
{
    internal class MaterieBiz
    {
        public List<Materia> Elenco { get; set; }

        public MaterieBiz(List<Materia> elenco)
        {
            Elenco = elenco ?? throw new ArgumentNullException(nameof(elenco));
        }

        public string StampaElenco()
        {
            return string.Join(Environment.NewLine, Elenco);
        }
    }
}
