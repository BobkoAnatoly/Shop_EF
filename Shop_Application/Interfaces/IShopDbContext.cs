using Microsoft.EntityFrameworkCore;
using Shop_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Application.Interfaces
{
    public interface IShopDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
          
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Cart> Cart { get; set; } 
        public DbSet<DeliveryPoint> DeliveryPoints { get; set; } 
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; } 
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<ServiceCenter> ServiceCenters { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<SupplyGoods> SupplyGoods { get; set; } 
        public DbSet<User> Users { get; set; } 
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Vendor> Vendors { get; set; } 
    }
}
