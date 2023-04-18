using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities;

public partial class CluDbContext : DbContext
{
    public CluDbContext(DbContextOptions<CluDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Flashcard> Flashcards { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Flashcard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__flashcar__3213E83F34DBC730");

            entity.ToTable("flashcard");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Answer)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("answer");
            entity.Property(e => e.Question)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("question");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
