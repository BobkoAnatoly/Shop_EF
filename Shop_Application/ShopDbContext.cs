using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shop_Application.Models;
using Shop.Persistence.EntityTypeConfiguration;
using Shop_Application.Interfaces;

namespace Shop_Application
{
    public class ShopDbContext : DbContext, IShopDbContext
    {
        public ShopDbContext()
        {
            Database.EnsureCreated();
            Console.WriteLine("123");
        }


        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Cart> Cart { get; set; } = null!;
        public DbSet<DeliveryPoint> DeliveryPoints { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Position> Positions { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Promotion> Promotions { get; set; } = null!;
        public DbSet<ServiceCenter> ServiceCenters { get; set; } = null!;
        public DbSet<Supply> Supplies { get; set; } = null!;
        public DbSet<SupplyGoods> SupplyGoods { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<UserProfile> UserProfiles { get; set; } = null!;
        public DbSet<Vendor> Vendors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryConfiguration());

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            optionsBuilder.UseSqlServer(builder.Build().GetConnectionString("DefaultConnection"));
        }
    }
}
