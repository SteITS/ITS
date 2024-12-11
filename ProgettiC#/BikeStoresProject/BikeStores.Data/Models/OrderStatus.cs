using System;
using System.Collections.Generic;

namespace BikeStores.Data.Models;

public partial class OrderStatus
{
    public byte StatusId { get; set; }

    public string StatusDescription { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
