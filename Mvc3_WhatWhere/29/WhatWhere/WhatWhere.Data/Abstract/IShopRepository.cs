using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface IShopRepository : IGenericRepository<Shop>
    {
        Task<List<Shop>> GetShopFullDataAsync();
        Task<List<Shop>> GetAllShopsWithCityTownCategoryAsync(bool isDeleted, bool? isActive = null);
        Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null);
        Task<List<Shop>> GetShopsByFilter(int? cityId, int? townId, int? categoryId);
        //Task CreateShopAsync(Shop shop, int categoryId, int cityId, int townId);
        //Task CheckShopsCategories();
        //void UpdateShop(Shop shop);// Bir dükkanı güncelle

    }
}