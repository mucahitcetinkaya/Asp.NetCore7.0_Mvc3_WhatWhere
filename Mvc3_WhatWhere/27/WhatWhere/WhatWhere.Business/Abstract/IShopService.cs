using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface IShopService
    {
        // CRUD işlemleri
        Task<Shop> GetByIdAsync(int id);// Bir dükkanı ID'ye göre getir
        Task<List<Shop>> GetAllAsync();// Tüm dükkanları getir
        Task CreateAsync(Shop shop);// Yeni bir dükkan oluştur
        void Update(Shop shop);// Bir şehri güncelle
        void Delete(Shop shop);// Bir şehri sil

        Task<List<Shop>> GetShopFullDataAsync();
        Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null);
        Task<List<Shop>> GetShopsByCityAsync(string cityName = null);
        Task<List<Shop>> GetShopsByTownAsync(string townName = null);
    }
}