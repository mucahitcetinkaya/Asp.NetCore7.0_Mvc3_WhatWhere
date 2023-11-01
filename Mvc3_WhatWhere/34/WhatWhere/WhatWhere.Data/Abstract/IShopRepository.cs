using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface IShopRepository : IGenericRepository<Shop>
    {
        Task<List<Shop>> GetShopFullDataAsync();
        Task<List<Shop>> GetAllShopsWithCityTownCategoryAsync(bool isDeleted, bool? isActive = null);
        Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null);

        Task<List<SelectListItem>> GetCategoriesByCityIdAsync(int cityId);
        Task<List<SelectListItem>> GetCategoriesByTownIdAsync(int townId);
        Task<List<Shop>> GetFilteredShopsAsync(int cityId, int townId, int categoryId);
    }
}