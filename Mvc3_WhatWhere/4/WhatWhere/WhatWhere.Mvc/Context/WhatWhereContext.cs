using Microsoft.EntityFrameworkCore;
using WhatWhere.Mvc.Config;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Context
{
    public class WhatWhereContext : DbContext
    {
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Category> Categories { get; set; }

        public WhatWhereContext(DbContextOptions<WhatWhereContext> options) : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BossConfig());
            modelBuilder.ApplyConfiguration(new ShopConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
