using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stanescu_Esercitazione
{
    internal sealed class Ordine
    {
        public List<string> CodiciGenerati { get; set; }
        public string CodiceOrdine { get; set; }
        public DateOnly Data { get; set; }
        public List<Prodotto> ElencoProdotti { get; set; }
        public Venditore Venditore { get; set; }

        public string GeneraCodiceOrdine()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            string nuovoCodice;

            do
            {
                var stringChars = new char[8];
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                nuovoCodice = new string(stringChars);
            }
            while (CodiciGenerati.Contains(nuovoCodice));

            CodiciGenerati.Add(nuovoCodice);
            return nuovoCodice;
        }
        public int NumeroProdotto()
        {
            int i = 0;
            foreach(var p in ElencoProdotti)
            {
                i++;
            }
            return i;
        }
        public double Totale()
        {
            double i= 0;
            foreach (Prodotto p in ElencoProdotti)
            {
                i = i + p.Prezzo;
            }
            return i;
        }

        public void StampaOrdine()
        {
            List<Prodotto> prodottiTrovati = new List<Prodotto>();
            string path = @$"..\..\..\file\{CodiceOrdine}.txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine($"Codice Ordine: {CodiceOrdine}");
            sw.WriteLine($"Data: {Data.ToShortDateString()}");
            sw.WriteLine($"Venditore: {Venditore.Nome}");
            sw.WriteLine("Prodotti:");
            foreach (Prodotto p in ElencoProdotti)
            {
                if (!prodottiTrovati.Contains(p))
                {
                    sw.WriteLine($"Codice:{p.Codice}\tNome:{p.Denominazione}\tQuantità:{trovaQuantita(p)}\tPrezzo Unitario:{p.Prezzo}\tSubtotale");
                    prodottiTrovati.Add(p);
                }
            }
            sw.WriteLine($"Totale: {Totale}");
        }

        private int trovaQuantita(Prodotto trovaProdotto)
        {
            int count = 0;
            foreach(var prodotto in ElencoProdotti)
            {
                if (prodotto.Equals(trovaProdotto))
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            return $"{{{nameof(CodiceOrdine)}={CodiceOrdine},\n" +
                $" {nameof(Data)}={Data.ToString()},\n" +
                $" {nameof(ElencoProdotti)}={ElencoProdotti},\n" +
                $" {nameof(Venditore)}={Venditore}}}\n" +
                $" {nameof(NumeroProdotto)}={NumeroProdotto}\n" +
                $" {nameof(Totale)}={Totale}\n";
        }
    }
}
