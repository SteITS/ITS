using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneMessaggi
{
    internal class Messaggio
    {
        public string Mittente { get; set; }
        public string Destinatario { get; set; }
        public string Oggetto { get; set; }
        public string Testo { get; set; }
        public DateTime Data { get; set; }
        public TimeOnly Ora { get; set; }
        public string Priorita { get; set; }

        public Messaggio(string mittente, string destinatario, string oggetto, string testo, DateTime data, TimeOnly ora, string priorita)
        {
            Mittente = mittente;
            Destinatario = destinatario;
            Oggetto = oggetto;
            Testo = testo;
            Data = data;
            Ora = ora;
            Priorita = priorita;
        }

        public static string CercaMittente(List<Messaggio> messaggio, string st)
        {
                foreach (var item in messaggio)
                {
                    if (st == item.Mittente)
                    {
                        return item.ToString();
                    }
                }
                return "Messaggio non trovato";
        }

        public static string CercaDestinatario(List<Messaggio> messaggio, string st)
        {
            foreach (var item in messaggio)
            {
                if (st == item.Destinatario)
                {
                    return item.ToString();
                }
            }
            return "Messaggio non trovato";
        }

        public static int CercaData(List<Messaggio> messaggio, DateTime data)
        {
            int j = 0;
            foreach (var item in messaggio)
            {
                if (item.Data > data)
                {
                    j++;
                }
            }
            return j;
        }
        public override string ToString()
        {
            return
                $"=======================================================================\n"+
                $" {nameof(Mittente)}={Mittente}\n" +
                $" {nameof(Destinatario)}={Destinatario}\n" +
                $" {nameof(Oggetto)}={Oggetto}\n" +
                $" {nameof(Testo)}={Testo}\n" +
                $" {nameof(Data)}={Data.ToString()}\n" +
                $" {nameof(Ora)}={Ora.ToString()}\n" +
                $" {nameof(Priorita)}={Priorita.ToString()}\n" +
                $"=======================================================================";
        }
    }
}
