using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface IShopRepository : IGenericRepository<Shop>
    {
        List<Shop> GetShopsByCategories(int categoryId);
        List<Shop> GetShopsByBoss(int bossId);
    }
}
