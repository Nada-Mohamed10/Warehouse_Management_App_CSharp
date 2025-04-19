using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace users.models
{
    class ITIProjectContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public DbSet<Product> Products { get; set; }

        public DbSet<Warehouse> Warehouses { get; set; }

        public DbSet<WarehouseProduct> WarehouseProducts { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<SupplyOrder> SupplyOrders { get; set; }

       public DbSet<SupplyOrderItem> SupplyOrderItems { get; set; }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionItem> PermissionItems { get; set; }

        public DbSet<TransferProduct> transferProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P8ERP6C\\SQLEXPRESS;Database=ITIProject;Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          modelBuilder.Entity<WarehouseProduct>().HasKey(wp => new { wp.IdProduct, wp.IdWarehouse });
          modelBuilder.Entity<WarehouseProduct>()
                .HasOne(wp => wp.Warehouse)
                .WithMany(w => w.WarehouseProducts)
                .HasForeignKey(wp => wp.IdWarehouse);
          modelBuilder.Entity<WarehouseProduct>()
            .HasOne(wp => wp.Products)
                .WithMany(p => p.WarehouseProducts)
                .HasForeignKey(wp => wp.IdProduct);




            modelBuilder.Entity<TransferProduct>()
       .HasOne(st => st.FromWarehouse)
       .WithMany()
       .HasForeignKey(st => st.FromWarehouseId)
       .OnDelete(DeleteBehavior.Restrict);  

            modelBuilder.Entity<TransferProduct>()
                .HasOne(st => st.ToWarehouse)
                .WithMany()
                .HasForeignKey(st => st.ToWarehouseId)
                .OnDelete(DeleteBehavior.Restrict);




        }
    }
}
