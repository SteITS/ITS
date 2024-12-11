using System;
using System.Collections.Generic;

namespace BikeStores.Data.Models;

public partial class VwProductsByCustomer
{
    public string ProductName { get; set; } = null!;

    public int BrandId { get; set; }

    public string CategoryName { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal ListPrice { get; set; }

    public decimal Discount { get; set; }

    public DateOnly OrderDate { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? City { get; set; }
}
