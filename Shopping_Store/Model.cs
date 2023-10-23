using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Shopping_Store
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Dbcontext")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Catagory> Catagories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Catagory>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Catagory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Catagory)
                .HasForeignKey(e => e.fk_catagory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Pro_Picture)
                .IsFixedLength();
        }
    }
}
