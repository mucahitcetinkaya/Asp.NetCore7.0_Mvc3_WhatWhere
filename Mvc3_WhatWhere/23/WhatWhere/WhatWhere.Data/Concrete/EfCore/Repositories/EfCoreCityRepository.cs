using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;

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
