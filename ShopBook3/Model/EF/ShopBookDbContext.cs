namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopBookDbContext : DbContext
    {
        public ShopBookDbContext()
            : base("name=ShopBookDbContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<InfoWebsite> InfoWebsites { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Nxb> Nxbs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrdersDetail> OrdersDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Writer> Writers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrdersDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrdersDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
