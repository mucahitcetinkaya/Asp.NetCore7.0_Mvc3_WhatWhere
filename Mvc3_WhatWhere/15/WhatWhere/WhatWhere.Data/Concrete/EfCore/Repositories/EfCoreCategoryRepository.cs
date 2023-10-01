using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreCategoryRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }
    }
}
