using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City>, ICityRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreCityRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<City>> GetCitiesOrderBy()
        {
            var result = await _context
                .Cities
                .OrderBy(c => c.Sehir)
                .ToListAsync();
            return result;
        }

        public async Task<City> GetCityNameWithOneCity(string cityName)
        {
            var result = await _context
                .Cities
                .SingleOrDefaultAsync(c => c.Sehir == cityName);
           return result;
        }

        public async Task<List<City>> GetTownsListWithCityName(string cityName)
        {
            var result = await _context
                .Cities
                .Where(c => c.Sehir == cityName)
                .Include(c => c.Towns)
                .ToListAsync();
            return result;

        }
    }
}