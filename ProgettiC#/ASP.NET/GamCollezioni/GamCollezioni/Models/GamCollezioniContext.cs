﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GamCollezioni.Models;

public partial class GamCollezioniContext : DbContext
{
    public GamCollezioniContext()
    {
    }

    public GamCollezioniContext(DbContextOptions<GamCollezioniContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Opera> Opere { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=GamCollezioni;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Opera>(entity =>
        {
            entity.ToTable("Opera");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
