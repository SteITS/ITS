using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanescu_Esercitazione
{
    internal class ResponsabileVenditori: Venditore
    {
        public override double Tredicesima()
        {
            VenditoriBiz venditoriBiz = new VenditoriBiz();
            double j = 0;
            foreach(Venditore v in venditoriBiz.ElencoVenditori)
            {
                j = j + (v.Stipendio / 24) * 0.15;  //24 giorni di lavoro
            }
            Stipendio = Stipendio * 2 + j;
            return Stipendio;
        }

        public override string ToString()
        {
            return $"{{{nameof(Settore)}={Settore.ToString()},\n" +
                $" {nameof(Nome)}={Nome},\n" +
                $" {nameof(Cognome)}={Cognome},\n" +
                $" {nameof(Stipendio)}={Stipendio.ToString()}}}\n";
        }
    }
}
