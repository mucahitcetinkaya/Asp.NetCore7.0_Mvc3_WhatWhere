using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreSaleMembershipRepository : EfCoreGenericRepository<SaleMembership>, ISaleMembershipRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreSaleMembershipRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }
    }
}
