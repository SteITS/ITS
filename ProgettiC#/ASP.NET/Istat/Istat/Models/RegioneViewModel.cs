using System.Drawing;

namespace Istat.Models
{
    public class RegioneViewModel
    {
        private Regione Regione;

        public RegioneViewModel(Regione regione)
        {
            Regione = regione;
        }

        public string Denominazione { get
            {
                return Regione.Denominazione;
            } 
        }

        public string RipartizioneGeografica { get
            {
                return Regione.IdRipartizioneNavigation.Denominazione;
            }
        }

        public int NumProvince { get
            {
                return Regione.Provincia.Count();
            }
         }

        public int NumComuni { get
            {
                return Regione.Provincia.Sum(x => x.Comuni.Count);
            }
                }

        public double SuperficieTot
        {
            get
            {
                return Regione.Provincia.Sum(x => x.Comuni.Sum(c => c.Superficie));
            }
        }

        public double PopolazioneMedia { get
            {
                int NComuni = NumComuni;
                int PopolazioneTot = Regione.Provincia.Sum(p => p.Comuni.Sum(c => c.Popolazione2011));
                return (double) (PopolazioneTot / NComuni);
            } 
        }
               
                


    }
}
