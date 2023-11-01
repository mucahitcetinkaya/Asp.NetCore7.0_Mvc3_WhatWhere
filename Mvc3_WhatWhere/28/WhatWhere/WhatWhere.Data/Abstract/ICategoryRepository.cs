using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<List<Category>> GetAllCategoriesAsync(bool isDeleted, bool? isActive = null);

    }
}
