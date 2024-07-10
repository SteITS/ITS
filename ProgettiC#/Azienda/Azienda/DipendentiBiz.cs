using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azienda
{
    internal class DipendentiBiz
    {
        public Dipendente[] dipendenti {  get; set; }

        public string StampaDipendenti()
        {
            string txt = string.Empty;
            for (int i = 0; i < dipendenti.Length; i++)
            {
                txt += (txt.Length !=0 ? "\n" : "") + dipendenti[i].ToString();
            }
            return txt;
        }
        public string StampaElenco(Dipendente[] elenco)
        {
            return string.Join("\n", elenco.ToList());
        }
        public string StampaAmministrativi()
        {
            string txt = string.Empty;
            for (int i = 0; i < dipendenti.Length; i++)
            {
                if (dipendenti[i] is Amministrativo)
                    txt += (txt.Length !=0 ? "\n" : "") + dipendenti[i].ToString();
            }
            return txt;
        }
        public int ContainerAmministrativi()
        {
            int conta = 0;
            foreach (var item in dipendenti)
            {
                if (item is Amministrativo)
                    conta++;
            }
            return conta;
        }
        public Amministrativo[] Amministrativi()
        {
            Amministrativo[] lista = new Amministrativo[ContainerAmministrativi()];
            int k = 0;
            for (int i = 0; i < dipendenti.Length; i++)
            {
                if (dipendenti[i] is Amministrativo)
                    lista[k++] = (Amministrativo)dipendenti[i];
            }
            return lista;
        }
        public string StampaOperai()
        {
            string txt = string.Empty;
            for (int i = 0; i < dipendenti.Length; i++)
            {
                if (dipendenti[i] is Operaio)
                    txt += (txt.Length !=0 ? "\n" : "") + dipendenti[i].ToString();
            }
            return txt;
        }
        public string StampaSpecializzati()
        {
            string txt = string.Empty;
            for (int i = 0; i < dipendenti.Length; i++)
            {
                if (dipendenti[i] is Specializzato)
                    txt += (txt.Length !=0 ? "\n" : "") + dipendenti[i].ToString();
            }
            return txt;
        }
        public string StampaOperaiStipendio()
        {
            string txt = string.Empty;
            for (int i = 0; i < dipendenti.Length; i++)
            {
                if (dipendenti[i] is Operaio)
                    if (dipendenti[i].stipendio()>=2000)
                        txt += (txt.Length !=0 ? "\n" : "") + dipendenti[i].ToString();
            }
            return txt;
        }
        public string StampaOperaiManutentori()
        {
            string txt = string.Empty;
            Operaio operaio;
            for (int i = 0; i < dipendenti.Length; i++)
            {
                if (dipendenti[i] is Operaio)
                {
                    operaio = (Operaio)dipendenti[i];
                    if (operaio.settore == Settore.MANUTENTORE)
                    {
                        txt += (txt.Length !=0 ? "\n" : "") + dipendenti[i].ToString();
                    }
                }
            }
            return txt;
        }
        public string StampaSchedaDirettoreAmministrativo()
        {   
            string txt = string.Empty;
            Amministrativo a;
            for (int i = 0; i < dipendenti.Length; i++)
            {
                if (dipendenti[i] is Amministrativo)
                {
                    a = (Amministrativo)dipendenti[i];
                    if (a.mansione == Mansione.DIRETTORE)
                    {
                        txt =  dipendenti[i].ToString();
                    }
                }
            }
            return txt;
        }
    }
}
