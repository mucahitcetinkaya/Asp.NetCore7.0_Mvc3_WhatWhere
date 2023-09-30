using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(WhatWhereContext context) : base(context)
        {
        }

        public List<Category> GetCategoriesByShop(int shopId)
        {
            throw new NotImplementedException();
        }
    }
}
