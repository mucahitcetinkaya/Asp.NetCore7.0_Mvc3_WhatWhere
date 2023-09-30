using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WhatWhere.Business.Abstract;
using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoriesByShop(int shopId)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
