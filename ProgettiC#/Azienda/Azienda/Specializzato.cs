using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class Specializzato : Operaio
    {
        public int numeroMissioni { get; set; }
        public int indennitaMissione { get; set; }
        public override int stipendio()
        {
            return base.stipendio() + numeroMissioni * indennitaMissione;
        }

        public override string ToString()
        {
            return $"{{{base.ToString()}" +
                $", {nameof(Settore)} ={settore.ToString()}" +
                $", Nmuero missioni = {numeroMissioni}" +
                $", Indennita missione = {indennitaMissione}}}";
        }

    }
}
