﻿using System;
using System.Collections.Generic;

namespace GalleriaArte_PalazzoMadama.Models;

public partial class Materiale
{
    public int Id { get; set; }

    public string? Denominazione { get; set; }

    public virtual ICollection<Opera> IdOpere { get; set; } = new List<Opera>();
}
