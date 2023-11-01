using Microsoft.AspNetCore.Mvc.Rendering;
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
        Task<List<Shop>> GetShopsByCityIdAsync(int cityId);
        Task<List<Shop>> GetAllShopsWithCityTownCategoryAsync(bool isDeleted, bool? isActive = null);
        Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null);

        Task<List<SelectListItem>> GetCategoriesByCityIdAsync(int cityId);
        Task<List<SelectListItem>> GetCategoriesByTownIdAsync(int townId);
        Task<List<Shop>> GetFilteredShopsAsync(int cityId, int townId, int categoryId);

    }
}