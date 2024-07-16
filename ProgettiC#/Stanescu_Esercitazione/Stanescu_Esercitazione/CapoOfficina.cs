using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanescu_Esercitazione
{
    internal class CapoOfficina : Meccanico
    {
        public override double Tredicesima()
        {
            OrdiniBiz Biz = new OrdiniBiz();
            Stipendio = (Stipendio * 2) + (Biz.TotaleFatturato()*0.05);
            return Stipendio;
        }

        public override string ToString()
        {
            return $"{{{nameof(Tipologia)}={Tipologia.ToString()},\n" +
                $" {nameof(Nome)}={Nome},\n" +
                $" {nameof(Cognome)}={Cognome},\n" +
                $" {nameof(Stipendio)}={Stipendio.ToString()}}}\n";
        }
    }
}
