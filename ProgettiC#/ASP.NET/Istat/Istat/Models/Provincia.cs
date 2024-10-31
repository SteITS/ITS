using System;
using System.Collections.Generic;

namespace Istat.Models;

public partial class Provincia
{
    public int Id { get; set; }

    public string Denominazione { get; set; } = null!;

    public string Sigla { get; set; } = null!;

    public int? CodiceCittaMetropolitana { get; set; }

    public int IdRegione { get; set; }
    private double superficie;

    public double Superficie
    {
        get {
            return Math.Round(Comuni.Sum(comune => comune.Superficie),2);
        }
    }
    


    public virtual ICollection<Comune> Comuni { get; set; } = new List<Comune>();

    public virtual Regione IdRegioneNavigation { get; set; } = null!;

}
