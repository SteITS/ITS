using System;
using System.Collections.Generic;

namespace GalleriaArte_PalazzoMadama.Models;

public partial class Autore
{
    public int Id { get; set; }

    public string? Nominativo { get; set; }

    public virtual ICollection<Opera> Operas { get; set; } = new List<Opera>();
}
