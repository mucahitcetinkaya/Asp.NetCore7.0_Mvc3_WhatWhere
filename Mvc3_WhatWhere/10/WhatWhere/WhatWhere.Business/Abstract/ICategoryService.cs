using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);

        List<Category> GetCategoriesByShop(int shopId);
    }
}
