using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ZH3B_XEZH7P.Models
{
    public partial class se_cocktailsContext : DbContext
    {
        public se_cocktailsContext()
        {
        }

        public se_cocktailsContext(DbContextOptions<se_cocktailsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cocktail> Cocktails { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<MaterialType> MaterialTypes { get; set; } = null!;
        public virtual DbSet<Recipe> Recipes { get; set; } = null!;
        public virtual DbSet<Type> Types { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=se_cocktails;Persist Security Info=True;User ID=hallgato;Password=Password123;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cocktail>(entity =>
            {
                entity.HasKey(e => e.CocktailSk)
                    .HasName("PK__Cocktail__12B6EBBDFB556BAB");

                entity.ToTable("Cocktail");

                entity.Property(e => e.CocktailSk).HasColumnName("CocktailSK");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.TypeFk).HasColumnName("TypeFK");

                entity.HasOne(d => d.TypeFkNavigation)
                    .WithMany(p => p.Cocktails)
                    .HasForeignKey(d => d.TypeFk)
                    .HasConstraintName("FK_Cocktail_ToType");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("Material");

                entity.Property(e => e.MaterialId)
                    .ValueGeneratedNever()
                    .HasColumnName("MaterialID");

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.TypeFk).HasColumnName("TypeFK");

                entity.Property(e => e.UnitFk).HasColumnName("UnitFK");

                entity.HasOne(d => d.TypeFkNavigation)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.TypeFk)
                    .HasConstraintName("FK_Material_ToMaterialType");

                entity.HasOne(d => d.UnitFkNavigation)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.UnitFk)
                    .HasConstraintName("FK_Material_ToUnit");
            });

            modelBuilder.Entity<MaterialType>(entity =>
            {
                entity.ToTable("MaterialType");

                entity.Property(e => e.MaterialTypeId).HasColumnName("MaterialTypeID");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.HasKey(e => e.RecipeSk)
                    .HasName("PK__Recipe__FDDC47C71E13B8BF");

                entity.ToTable("Recipe");

                entity.Property(e => e.RecipeSk).HasColumnName("RecipeSK");

                entity.Property(e => e.CocktailFk).HasColumnName("CocktailFK");

                entity.Property(e => e.MaterialFk).HasColumnName("MaterialFK");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CocktailFkNavigation)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.CocktailFk)
                    .HasConstraintName("FK_Recipe_ToCocktail");

                entity.HasOne(d => d.MaterialFkNavigation)
                    .WithMany(p => p.Recipes)
                    .HasForeignKey(d => d.MaterialFk)
                    .HasConstraintName("FK_Recipe_ToMaterial");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("Type");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit");

                entity.Property(e => e.UnitId).HasColumnName("UnitID");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
