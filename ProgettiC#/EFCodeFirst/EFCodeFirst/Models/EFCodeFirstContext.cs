﻿using EFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

public class EFCodeFirstContext : DbContext
{
    public DbSet<Prodotto> Prodotti { set; get; }

    public EFCodeFirstContext()
    {
    }

    public EFCodeFirstContext(DbContextOptions<EFCodeFirstContext> options)
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }
}