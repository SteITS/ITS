using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    internal class Alimentare : Prodotto
    {
        public DateTime scadenza { get; set; }

        public bool InScadenza() 
        {
            return DateTime.Now.AddDays(10) >= scadenza;
        }

        public override string ToString()
        {
            return $"{{{nameof(scadenza)}={scadenza.ToString()}," +
                $" {nameof(codice)}={codice.ToString()}," +
                $" {nameof(nome)}={nome}," +
                $" {nameof(prezzo)}={prezzo.ToString()}," +
                $" {nameof(data)}={data.ToString()}}}";
        }
    }
}
