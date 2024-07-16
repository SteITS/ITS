using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanescu_Esercitazione
{
    internal class VenditoriBiz
    {
        public List<Venditore> ElencoVenditori { get; set; }


        public void AggiungiVenditore(Venditore venditore) //Questo metodo fa schifo ma non ho piu tempo
        {
 /*           if(ElencoVenditori.Count == 0)
            {
                if (venditore is ResponsabileVenditori)
                {
                    ElencoVenditori.Add(venditore);
                }
                else
                {
                    Console.WriteLine("Aggiungi un Responsabile venditori prima pls");
                }
            }
            else
            {*/
                ElencoVenditori.Add(venditore);
           // }
            
        }
        public Venditore RestituisciVenditore(int i)
        {
            return ElencoVenditori[i];
        }
        public string CancellaVenditore(int i)
        {
            string st= "";
            try
            {
                ElencoVenditori.RemoveAt(i);
                st = "Eliminazione Riuscita";
            }catch(Exception e)
            {
                st = "Index non presente in lista";
            }
            return st;
        }

    }
}
