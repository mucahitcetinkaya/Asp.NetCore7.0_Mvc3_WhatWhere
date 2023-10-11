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

        public List<Town> GetAllIncludingCity()
        {
            return _context.Towns.Include(t => t.City).ToList();
        }

        public List<Town> GetTownsByCity(int cityId)
        {
            // TODO: Veritabanında cityId'ye sahip şehre bağlı olan kasabaları getir
            return _context.Towns.Where(t => t.CityId == cityId).ToList();
        }
    }
}
