using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class Operaio :Dipendente
    {
        public Settore settore {  get; set; }

        public override int stipendio()
        {
            int bonus = 0;
            switch (settore)
            {
                case Settore.INSALLATORE:bonus = 185;break;
                case Settore.MANUTENTORE:bonus = 230;break;
            }
            return base.stipendio();
        }
        public override string ToString()
        {
            return $"{{{base.ToString()}" +
                $", {nameof(Settore)} ={settore.ToString()}}}";
        }


    }
}
