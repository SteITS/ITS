using Microsoft.EntityFrameworkCore;

namespace Autovelox.Data.Models;

public partial class AutoveloxContext : DbContext
{
    public AutoveloxContext()
    {
    }

    public AutoveloxContext(DbContextOptions<AutoveloxContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comune> Comune { get; set; }

    public virtual DbSet<Mappa> Mappa { get; set; }

    public virtual DbSet<Provincia> Provincia { get; set; }

    public virtual DbSet<Regione> Regione { get; set; }

    public virtual DbSet<RipartizioneGeografica> RipartizioneGeografica { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Autovelox; USER ID=swd2325; Password=its-2025;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comune>(entity =>
        {
            entity.HasKey(e => e.IdComune).HasName("PK_istat_Comuni_1");

            entity.ToTable("Comune");

            entity.Property(e => e.CodiceCatastale).HasMaxLength(10);
            entity.Property(e => e.CodiceComune).HasMaxLength(255);
            entity.Property(e => e.ComuneMontano).HasMaxLength(50);
            entity.Property(e => e.Denominazione).HasMaxLength(255);
            entity.Property(e => e.SuperficieTerritoriale).HasMaxLength(50);
            entity.Property(e => e.ZonaAltimetrica).HasMaxLength(50);

            entity.HasOne(d => d.IdProvinciaNavigation).WithMany(p => p.Comunes)
                .HasForeignKey(d => d.IdProvincia)
                .HasConstraintName("FK_Comune_Provincia");
        });

        modelBuilder.Entity<Mappa>(entity =>
        {
            entity.ToTable("Mappa");

            entity.Property(e => e.Latitudine).HasColumnType("decimal(10, 7)");
            entity.Property(e => e.Longitudine).HasColumnType("decimal(10, 7)");
            entity.Property(e => e.Nome).HasMaxLength(50);

            entity.HasOne(d => d.IdComuneNavigation).WithMany(p => p.Mappas)
                .HasForeignKey(d => d.IdComune)
                .HasConstraintName("FK_Mappa_Comune");
        });

        modelBuilder.Entity<Provincia>(entity =>
        {
            entity.Property(e => e.Denominazione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sigla)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdRegioneNavigation).WithMany(p => p.Provincia)
                .HasForeignKey(d => d.IdRegione)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Provincia_Regione");
        });

        modelBuilder.Entity<Regione>(entity =>
        {
            entity.ToTable("Regione");

            entity.Property(e => e.Denominazione)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdRipartizioneGeograficaNavigation).WithMany(p => p.Regiones)
                .HasForeignKey(d => d.IdRipartizioneGeografica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Regione_RipartizioneGeografica");
        });

        modelBuilder.Entity<RipartizioneGeografica>(entity =>
        {
            entity.ToTable("RipartizioneGeografica");

            entity.Property(e => e.Denominazione)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
