using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreBossRepository : EfCoreGenericRepository<Boss>, IBossRepository
    {
        public EfCoreBossRepository(WhatWhereContext context) : base(context)
        {
        }

        public List<Boss> GetAllBossList(int bossId)
        {
            throw new NotImplementedException();
        }
    }
}
