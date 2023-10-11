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
    }
}

//var result = _context
//    .Shops
//    .Where(s => !s.IsDeleted)
//    .AsQueryable();
//if (isHome != null)
//{
//    result = result
//        .Where(s => s.IsHome == isHome)
//        .AsQueryable();
//}
//if (isActive != null)
//{
//    result = result
//        .Where(s => s.IsActive == isActive)
//        .AsQueryable();
//}
//result = result
//    .Include(s => s.Boss)
//    .Include(s => s.Category)
//    .Include(s => s.City)
//    .Include(s => s.Town)
//    .AsQueryable();
//return await result.ToListAsync();