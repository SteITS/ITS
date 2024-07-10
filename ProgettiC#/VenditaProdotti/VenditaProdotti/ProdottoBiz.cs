using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    internal class ProdottoBiz
    {
        public Prodotto[] prodotto { get; set; }

        public string StampaProdotti()
        {
            string txt = string.Empty;
            for (int i = 0; i < prodotto.Length; i++)
            {
                txt += (txt.Length != 0 ? "\n" : "") + prodotto[i].ToString();
            }
            return txt;
        }
        public string StampaScadenza()
        {
            string txt = string.Empty;
            Alimentare p;
            for (int i = 0; i < prodotto.Length; i++)
            {
                if (prodotto[i] is Alimentare)
                {
                    p = (Alimentare)prodotto[i];
                    bool b = p.InScadenza();
                    if (b==true)
                    {
                        txt += (txt.Length != 0 ? "\n" : "") + prodotto[i].ToString();
                    }
                }
            }
            return txt;
        }
        public string StampaMateriale()
        {
            string txt = string.Empty;
            Oggetto o;
            for (int i = 0;i < prodotto.Length; i++)
            {
                if (prodotto[i] is Oggetto)
                {
                    o = (Oggetto)prodotto[i];
                    txt += (txt.Length != 0 ? "\n" : "") + prodotto[i].nome.ToString() + " " + o.materiale.ToString();
                }
            }
            return txt;
        }
    }
}