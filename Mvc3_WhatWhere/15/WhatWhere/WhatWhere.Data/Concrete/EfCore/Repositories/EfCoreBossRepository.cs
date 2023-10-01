using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Data.Concrete.EfCore.Repositories;
using WhatWhere.Entity.Concrete;

public class EfCoreBossRepository : EfCoreGenericRepository<Boss>, IBossRepository
{
    private readonly WhatWhereContext _context;

    public EfCoreBossRepository(WhatWhereContext context) : base(context)
    {
        _context = context;
    }

}
