using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreShopRepository : EfCoreGenericRepository<Shop>, IShopRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreShopRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Shop>> GetShopFullDataAsync()
        {
            var result = await _context
                .Shops
                .Include(s => s.Boss)
                .Include(s => s.Category)
                .Include(s => s.City)
                .Include(s => s.Town)
                .ToListAsync();
            return result;
        }

        public async Task<List<Shop>> GetShopsByCityIdAsync(int cityId)
        {
            var result = await _context
                .Shops
                .Where(shop => shop.CityId == cityId)
                .ToListAsync();
            return result;
        }


        public async Task<List<Shop>> GetAllShopsWithCityTownCategoryAsync(bool isDeleted, bool? isActive = null)
        {
            var result = await _context
                .Shops
                .Where(b => b.IsDeleted == isDeleted)
                .Include(b => b.Category)
                .Include(b => b.City)
                .Include(b => b.Town)
                .ToListAsync();
            return result;
        }

        public async Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null)
        {
            var result = _context
                .Shops
                .Where(s => s.IsActive && !s.IsDeleted)
                .Include(s => s.Boss)
                .Include(s => s.Category)
                .Include(s => s.City)
                .Include(s => s.Town)
                .AsQueryable();

            if (!string.IsNullOrEmpty(categoryName))
            {
                result = result
                    .Where(s => s.Category.Name == categoryName)
                    .AsQueryable();
            }

            return await result.ToListAsync();
        }

        #region optionscontroller

        public async Task<List<SelectListItem>> GetCategoriesByCityIdAsync(int cityId)
        {

            var result = _context.Shops
               .Where(s => s.CityId == cityId && s.CategoryId != null)
               .Select(s => s.Category)
               .Distinct()
               .Select(category => new SelectListItem { Text = category.Name, Value = category.Id.ToString() })
               .ToList();

            return result;
        }


        public async Task<List<SelectListItem>> GetCategoriesByTownIdAsync(int townId)
        {

            var result = _context.Shops
                .Where(s => s.TownId == townId && s.CategoryId != null)
                .Select(s => s.Category)
                .Distinct()
                .Select(category => new SelectListItem { Text = category.Name, Value = category.Id.ToString() })
                .ToList();

            return result;
        }


        public async Task<List<Shop>> GetFilteredShopsAsync(int cityId, int townId, int categoryId)
        {

            var filteredShops = _context.Shops
                .Where(shop => shop.CityId == cityId && shop.TownId == townId);

            if (categoryId != 0)
            {
                filteredShops = filteredShops.Where(shop => shop.CategoryId == categoryId);
            }

            var shopsData = filteredShops.ToList();

            return shopsData;
        }

        #endregion

    }
}