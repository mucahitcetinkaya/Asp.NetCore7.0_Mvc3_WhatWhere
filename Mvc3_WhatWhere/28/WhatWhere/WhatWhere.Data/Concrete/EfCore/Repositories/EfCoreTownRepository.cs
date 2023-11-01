using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreTownRepository : EfCoreGenericRepository<Town>, ITownRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreTownRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Town>> GetTownFullDataAsync()
        {
            return await _context.Towns.Include(t => t.City).ToListAsync();

        }

        public async Task<List<Town>> GetTownListWithCityId(int cityId)
        {
            var result = await _context
                   .Towns
                   .Where(t => t.CityId == cityId)
                   .Include(t => t.City) // City nesnesini yüklemek için Include kullanın
                   .ToListAsync();
            return result;
        }

        public async Task<List<Town>> GetTownsListWithCityName(string cityName)
        {
            var result = await _context
                .Towns
                .Where(c => c.City.Sehir == cityName)
                .Include(c => c.City)
                .ToListAsync();
            return result;
        }
    }
}