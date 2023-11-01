using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface IShopService
    {
        // CRUD işlemleri
        Task<Shop> GetByIdAsync(int id);// Bir dükkanı ID'ye göre getir
        Task<List<Shop>> GetAllAsync();// Tüm dükkanları getir
        Task CreateAsync(Shop shop);// Yeni bir dükkan oluştur
        void Update(Shop shop);// Bir dükkanı güncelle
        void Delete(Shop shop);// Bir dükkanı sil

        Task<List<Shop>> GetShopFullDataAsync();
        Task<List<Shop>> GetAllShopsWithCityTownCategoryAsync(bool isDeleted, bool? isActive = null);
        Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null);
        Task<List<Shop>> GetShopsByFilter(int? cityId, int? townId, int? categoryId);

        //Task CreateShopAsync(Shop shop, int categoryId, int cityId, int townId);
        //Task CheckShopsCategories();
        //void UpdateShop(Shop shop);// Bir dükkanı güncelle

    }
}