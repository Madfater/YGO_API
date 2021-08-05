using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace YGO_API.Models
{
    public partial class YGO_DatabaseContext : DbContext
    {
        public YGO_DatabaseContext()
        {

        }

        public YGO_DatabaseContext(DbContextOptions<YGO_DatabaseContext> options): base(options)
        {

        }

        public virtual DbSet<CardData> CardData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_Taiwan_Stroke_CI_AS");

            modelBuilder.Entity<CardData>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Atk)
                    .HasMaxLength(10)
                    .HasColumnName("ATK")
                    .IsFixedLength(true);

                entity.Property(e => e.Attribute)
                    .HasMaxLength(10)
                    .HasColumnName("attribute")
                    .IsFixedLength(true);

                entity.Property(e => e.Def)
                    .HasMaxLength(10)
                    .HasColumnName("DEF")
                    .IsFixedLength(true);

                entity.Property(e => e.Level)
                    .HasMaxLength(10)
                    .HasColumnName("level")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.No).HasMaxLength(50);

                entity.Property(e => e.Race)
                    .HasMaxLength(10)
                    .HasColumnName("race")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("type")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
