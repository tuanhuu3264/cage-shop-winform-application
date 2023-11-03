using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusinessObject.Models
{
    public partial class CAGE_SHOPContext : DbContext
    {
        public CAGE_SHOPContext()
        {
        }

        public CAGE_SHOPContext(DbContextOptions<CAGE_SHOPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderProduct> OrderProducts { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<TypeProduct> TypeProducts { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-R23TMQS\\ALEX;Database=CAGE_SHOP;Uid=sa;Pwd=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("date")
                    .HasColumnName("createAt");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("id");

                entity.Property(e => e.DateBuy)
                    .HasColumnType("date")
                    .HasColumnName("dateBuy");

                entity.Property(e => e.IdCustomer)
                    .HasMaxLength(6)
                    .HasColumnName("idCustomer");

                entity.Property(e => e.IdStaff)
                    .HasMaxLength(6)
                    .HasColumnName("idStaff");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdCustomer)
                    .HasConstraintName("FK__Orders__idCustom__2D27B809");

                entity.HasOne(d => d.IdStaffNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdStaff)
                    .HasConstraintName("FK__Orders__idStaff__2E1BDC42");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Product");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.IdOrder)
                    .HasMaxLength(100)
                    .HasColumnName("idOrder");

                entity.Property(e => e.IdProduct)
                    .HasMaxLength(6)
                    .HasColumnName("idProduct");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdOrder)
                    .HasConstraintName("FK__Order_Pro__idOrd__30F848ED");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProduct)
                    .HasConstraintName("FK__Order_Pro__idPro__300424B4");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IdTypeProduct)
                    .HasMaxLength(6)
                    .HasColumnName("idTypeProduct");

                entity.Property(e => e.ImageUrl).HasColumnName("imageUrl");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.PriceExport).HasColumnName("price_export");

                entity.Property(e => e.PriceImport).HasColumnName("price_import");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.IdTypeProductNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdTypeProduct)
                    .HasConstraintName("FK__Product__idTypeP__267ABA7A");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .HasColumnName("id");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.IdStaff)
                    .HasMaxLength(6)
                    .HasColumnName("idStaff");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.HasOne(d => d.IdStaffNavigation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.IdStaff)
                    .HasConstraintName("FK__Report__idStaff__33D4B598");
            });

            modelBuilder.Entity<TypeProduct>(entity =>
            {
                entity.ToTable("Type_Product");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.DateBirth)
                    .HasColumnType("date")
                    .HasColumnName("dateBirth");

                entity.Property(e => e.DateWork)
                    .HasColumnType("date")
                    .HasColumnName("dateWork");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .HasColumnName("gender");

                entity.Property(e => e.ImageUrl).HasColumnName("imageUrl");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
