using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCVuoto.Models
{
    internal class Prodotto
    {
        public int codice { get; set; }
        public string? nome { get; set; }
        public double prezzo { get; set; }
        public DateTime data { get; set; }


        public override string ToString()
        {
            return $"{{{nameof(codice)}={codice.ToString()}," +
                $" {nameof(nome)}={nome}," +
                $" {nameof(prezzo)}={prezzo.ToString()}" +
                $", {nameof(data)}={data.ToString()}}}";
        }
    }
}
