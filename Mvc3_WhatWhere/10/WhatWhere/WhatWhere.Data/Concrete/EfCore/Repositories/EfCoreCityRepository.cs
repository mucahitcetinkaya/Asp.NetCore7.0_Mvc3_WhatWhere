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
    public class EfCoreCityRepository : EfCoreGenericRepository<City>, ICityRepository
    {
        public EfCoreCityRepository(WhatWhereContext context) : base(context)
        {
        }
    }
}
