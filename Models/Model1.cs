using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Maryam_project.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<M_Admin> M_Admin { get; set; }
        public virtual DbSet<M_Category> M_Category { get; set; }
        public virtual DbSet<M_Product> M_Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<M_Admin>()
                .Property(e => e.Admin_Name)
                .IsFixedLength();

            modelBuilder.Entity<M_Admin>()
                .Property(e => e.Admin_Email)
                .IsFixedLength();

            modelBuilder.Entity<M_Admin>()
                .Property(e => e.Admin_Password)
                .IsFixedLength();

            modelBuilder.Entity<M_Admin>()
                .Property(e => e.Admin_Contact)
                .IsFixedLength();

            modelBuilder.Entity<M_Admin>()
                .Property(e => e.Admin_Address)
                .IsFixedLength();

            modelBuilder.Entity<M_Category>()
                .Property(e => e.Category_Name)
                .IsFixedLength();

            modelBuilder.Entity<M_Category>()
                .HasMany(e => e.M_Product)
                .WithOptional(e => e.M_Category)
                .HasForeignKey(e => e.Product_Category_FID);

            modelBuilder.Entity<M_Product>()
                .Property(e => e.Product_Name)
                .IsFixedLength();

            modelBuilder.Entity<M_Product>()
                .Property(e => e.Product_Description)
                .IsFixedLength();

            modelBuilder.Entity<M_Product>()
                .Property(e => e.Product_Picture)
                .IsFixedLength();

            modelBuilder.Entity<M_Product>()
                .Property(e => e.Product_PurchasePrice)
                .IsFixedLength();

            modelBuilder.Entity<M_Product>()
                .Property(e => e.Product_SalePrice)
                .IsFixedLength();
        }
    }
}
