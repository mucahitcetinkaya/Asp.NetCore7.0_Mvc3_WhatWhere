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
    public class EfCoreShopRepository : EfCoreGenericRepository<Shop>, IShopRepository
    {
        public EfCoreShopRepository(WhatWhereContext context) : base(context)
        {
        }

        public List<Shop> GetShopsByBoss(int bossId)
        {
            throw new NotImplementedException();
        }

        public List<Shop> GetShopsByCategories(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
