using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<List<Category>> GetAllCategoriesAsync(bool isDeleted, bool? isActive = null);
        Task<List<SelectListItem>> GetCategorySelectListAsync();


    }
}
