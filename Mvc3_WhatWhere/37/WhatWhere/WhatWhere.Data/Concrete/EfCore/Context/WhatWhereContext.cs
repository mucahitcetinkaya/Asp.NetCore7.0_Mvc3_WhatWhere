using Microsoft.EntityFrameworkCore;
using WhatWhere.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using WhatWhere.Data.Concrete.EfCore.Extensions;
using WhatWhere.Data.Concrete.EfCore.Configs;

namespace WhatWhere.Data.Concrete.EfCore.Context
{
    public class WhatWhereContext : IdentityDbContext<User, Role, string>
    {
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<SaleMembership> SaleMemberships { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public WhatWhereContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BossConfig());
            modelBuilder.ApplyConfiguration(new ShopConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new TownConfig());
            modelBuilder.ApplyConfiguration(new SaleMembershipConfig());
            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }
    }
}
