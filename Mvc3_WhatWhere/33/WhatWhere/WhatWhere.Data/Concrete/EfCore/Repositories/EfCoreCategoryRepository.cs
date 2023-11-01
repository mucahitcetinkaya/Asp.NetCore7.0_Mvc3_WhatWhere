using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreCategoryRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllCategoriesAsync(bool isDeleted, bool? isActive = null)
        {
            var result = _context
                .Categories
                .Where(c => c.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(c => c.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }

        #region options controller

        public async Task<List<SelectListItem>> GetCategorySelectListAsync()
        {
            var result = await _context
                .Categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .ToListAsync();
            return result;
        }

        #endregion
    }
}