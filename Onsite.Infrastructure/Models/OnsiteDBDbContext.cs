using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Onsite.Infrastructure.Models;

public partial class OnsiteDBDbContext : DbContext
{
    public OnsiteDBDbContext()
    {
    }

    public OnsiteDBDbContext(DbContextOptions<OnsiteDBDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Etudiant> Etudiants { get; set; }

    public virtual DbSet<Matiere> Matieres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=serveurueve.database.windows.net;Database=OnsiteDB;User ID=adminueve;Password=Ueve@2024;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Etudiant>(entity =>
        {
            entity.ToTable("Etudiant");

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<Matiere>(entity =>
        {
            entity.ToTable("Matiere");

            entity.Property(e => e.Coefficient).HasMaxLength(50);
            entity.Property(e => e.Nom).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
