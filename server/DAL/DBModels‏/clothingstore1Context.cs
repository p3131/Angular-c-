using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace server.DBModels‏
{
    public partial class clothingstore1Context : DbContext
    {
        public clothingstore1Context()
        {
        }

        public clothingstore1Context(DbContextOptions<clothingstore1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCustomers> TblCustomers { get; set; }
        public virtual DbSet<TblProducts> TblProducts { get; set; }
        public virtual DbSet<TblShopDetails> TblShopDetails { get; set; }
        public virtual DbSet<TblShopping> TblShopping { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=den1.mssql8.gear.host; Persist Security Info=True; User ID=clothingstore1; Password= Gu28?uE4je!N; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tblCategory");

                entity.Property(e => e.CategoryName).HasMaxLength(20);
            });

            modelBuilder.Entity<TblCustomers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("tblCustomers");

                entity.Property(e => e.CreditInformation)
                    .HasColumnName("creditInformation")
                    .HasMaxLength(40);

                entity.Property(e => e.CustomerName).HasMaxLength(30);

                entity.Property(e => e.Password).HasMaxLength(15);
            });

            modelBuilder.Entity<TblProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tblProducts");

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.Picture)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.QuantityInStock).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblProduc__Categ__38996AB5");
            });

            modelBuilder.Entity<TblShopDetails>(entity =>
            {
                entity.HasKey(e => e.ShopId);

                entity.ToTable("tblShopDetails");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblShopDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__tblShopDe__Produ__412EB0B6");

                entity.HasOne(d => d.Shopping)
                    .WithMany(p => p.TblShopDetails)
                    .HasForeignKey(d => d.ShoppingId)
                    .HasConstraintName("FK__tblShopDe__Shopp__403A8C7D");
            });

            modelBuilder.Entity<TblShopping>(entity =>
            {
                entity.HasKey(e => e.ShoppingId);

                entity.ToTable("tblShopping");

                entity.Property(e => e.AmountToPay).HasColumnType("money");

                entity.Property(e => e.ShopDate).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblShopping)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__tblShoppi__Custo__3D5E1FD2");
            });
        }
    }
}
