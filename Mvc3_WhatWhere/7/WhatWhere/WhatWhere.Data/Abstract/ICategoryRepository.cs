using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        List<Category> GetCategoriesByShop(int shopId);
    }
}
