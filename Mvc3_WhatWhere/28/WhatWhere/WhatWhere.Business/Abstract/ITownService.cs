using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ITownService
    {
        // CRUD işlemleri
        Task<Town> GetByIdAsync(int id);// Bir kasabayı ID'ye göre getir
        Task<List<Town>> GetAllAsync();// Tüm kasabaları getir
        Task CreateAsync(Town town);// Yeni bir kasaba oluştur
        void Update(Town town);// Bir kasabayı güncelle
        void Delete(Town town);// Bir kasabayı sil
        
        Task<List<Town>> GetTownFullDataAsync();
        Task<List<Town>> GetTownListWithCityId(int cityId);
        Task<List<Town>> GetTownsListWithCityName(string cityName);

    }
}
