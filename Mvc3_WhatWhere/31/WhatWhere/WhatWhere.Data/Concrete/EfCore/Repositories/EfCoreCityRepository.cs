using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City>, ICityRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreCityRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<City>> GetCitiesOrderByAsync()
        {
            var result = await _context
                .Cities
                .OrderBy(c => c.Sehir)
                .ToListAsync();
            return result;
        }

        public async Task<City> GetCityNameWithOneCityAsync(string cityName)
        {
            var result = await _context
                .Cities
                .SingleOrDefaultAsync(c => c.Sehir == cityName);
            return result;
        }

        

        public async Task<List<City>> GetTownsListWithCityNameAsync(string cityName)
        {
            var result = await _context
                .Cities
                .Where(c => c.Sehir == cityName)
                .Include(c => c.Towns)
                .ToListAsync();
            return result;

        }

        #region optionscontroller

        public async Task<List<SelectListItem>> GetCitySelectList()
        {
            var result = await _context
                .Cities
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Sehir })
                .ToListAsync();
            return result;
        }


        #endregion
    }
}