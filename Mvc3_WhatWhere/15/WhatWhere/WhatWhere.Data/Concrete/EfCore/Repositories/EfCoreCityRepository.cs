using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City>, ICityRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreCityRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }
    }
}
