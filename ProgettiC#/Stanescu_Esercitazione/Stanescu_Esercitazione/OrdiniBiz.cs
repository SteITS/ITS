using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanescu_Esercitazione
{
    internal class OrdiniBiz
    {
        public List<Ordine> ElencoOrdine { get; set; }

        public void AggiungiOrdine(Ordine ordine, int i)
        {
            ElencoOrdine.Insert(i,ordine);
        }

        public int NumeroOrdini()
        {
            int i = 0;
            foreach(Ordine o in ElencoOrdine)
            {
                i++;
            }
            return i;
        }
        public double TotaleFatturato()
        {
            double tot = 0;
            foreach(var o in ElencoOrdine)
            {
                if(o.Data.Year == System.DateTime.Now.Year)
                {
                    tot = tot + o.Totale();
                }
            }
            return tot;
        }
    }
}
