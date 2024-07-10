using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    internal class Oggetto : Prodotto
    {
        public string materiale { get; set; }


        public override string ToString()
        {
            return $"{{{nameof(materiale)}={materiale}," +
                $" {nameof(codice)}={codice.ToString()}," +
                $" {nameof(nome)}={nome}," +
                $" {nameof(prezzo)}={prezzo.ToString()}," +
                $" {nameof(data)}={data.ToString()}}}";
        }
    }
}
