using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class Amministrativo : Dipendente
    {
        public Mansione mansione {  get; set; }

        public override int stipendio()
        {
            var bonus = 0;
            switch (mansione)
            { 
                case Mansione.CONTABILE:bonus = 150; break;
                case Mansione.RISORSEUMANE:bonus = 75; break;
                case Mansione.DIRETTORE:bonus = 250; break;
            }
            return base.stipendio() + bonus;
        }

        public override string ToString()
        {
            return $"{{{base.ToString()}" +
                $", {nameof(Mansione)} ={mansione.ToString()}}}";
        }
    }
}
