using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneImmobili
{
    internal class ImmobileBiz
    {
        public Immobile[] Immobile { get; set; }

        public int ContaImmobili()
        {
        return Immobile.Length; 
        }

        public string StampaImmobili()
        {
            string txt = string.Empty;
            for (int i = 0; i < Immobile.Length; i++)
            {
                txt += (txt.Length != 0 ? "\n" : "") + Immobile[i].ToString();
            }
            return txt;
        }
        public string StampaBox()
        {
            string txt = string.Empty;
            Box b;
            for (int i = 0; i < Immobile.Length; i++)
            {
                if (Immobile[i] is Box)
                {
                    b = (Box)Immobile[i];
                    txt += (txt.Length != 0 ? "\n" : "") + Immobile[i].ToString();
                }
            }
            return txt;
        }
        public string StampaAppartamenti()
        {
            string txt = string.Empty;
            Appartemento a;
            for (int i = 0; i < Immobile.Length; i++)
            {
                if (Immobile[i] is Appartemento && Immobile[i] is not Villa)
                {
                    a = (Appartemento)Immobile[i];
                    txt += (txt.Length != 0 ? "\n" : "") + Immobile[i].ToString();
                }
            }
            return txt;
        }
        public string StampaVille()
        {
            string txt = string.Empty;
            Villa v;
            for (int i = 0; i < Immobile.Length; i++)
            {
                if (Immobile[i] is Villa)
                {
                    v = (Villa)Immobile[i];
                    txt += (txt.Length != 0 ? "\n" : "") + Immobile[i].ToString();
                }
            }
            return txt;
        }
        public string StampaPerCitta(string citta)
        {
            string txt = string.Empty;
            for (int i = 0;i < Immobile.Length; i++)
            {
                if (citta == Immobile[i].Citta)
                    txt += (txt.Length != 0 ? "\n" : "") + Immobile[i].ToString();
            }
            return txt;
        }
        public string StampaPerCodice(string codice)
        {
            string txt = string.Empty;
            for (int i = 0; i < Immobile.Length; i++)
            {
                if (codice == Immobile[i].Cod)
                    txt += (txt.Length != 0 ? "\n" : "") + Immobile[i].ToString();
            }
            return txt;
        }
    }
}
