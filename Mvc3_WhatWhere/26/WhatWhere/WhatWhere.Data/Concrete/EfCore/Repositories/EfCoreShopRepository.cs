using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreShopRepository : EfCoreGenericRepository<Shop>, IShopRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreShopRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null)
        {
            var result = _context.Shops
                .Where(s => s.IsActive && !s.IsDeleted)
                .Include(s => s.Boss)
                .Include(s => s.Category)
                .Include(s => s.City)
                .Include(s => s.Town)
                .AsQueryable();

            if (!string.IsNullOrEmpty(categoryName))
            {
                result = result
                    .Where(s => s.Category.Name == categoryName)
                    .AsQueryable();
            }

            return await result.ToListAsync();
        }


        public async Task<List<Shop>> GetShopFullDataAsync()
        {
            var result = await _context
                .Shops
                .Include(s => s.Boss)
                .Include(s => s.Category)
                .Include(s => s.City)
                .Include(s => s.Town)
                .ToListAsync();
            return result;
        }

        public async Task<List<Shop>> GetShopsByCityAsync(string cityName)
        {
            return await _context.Shops
                .Where(s => s.City.Sehir == cityName && s.IsActive && !s.IsDeleted)
                .ToListAsync();
        }

        public async Task<List<Shop>> GetShopsByTownAsync(string townName)
        {
            return await _context.Shops
                .Where(s => s.Town.Ilce == townName && s.IsActive && !s.IsDeleted)
                .ToListAsync();
        }


    }
}