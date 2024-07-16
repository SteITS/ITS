using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanescu_Esercitazione
{
    internal class Prodotto
    {
        public int Codice { get; set; }
        public string Denominazione { get; set; } //Chiamata Prod perchè non posso chiamare un proprietà allo stesso modo della classe
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Codice)}={Codice.ToString()},\n" +
                $" {nameof(Denominazione)}={Denominazione},\n" +
                $" {nameof(Descrizione)}={Descrizione},\n" +
                $" {nameof(Prezzo)}={Prezzo.ToString()}}}\n";
        }
    }
}
