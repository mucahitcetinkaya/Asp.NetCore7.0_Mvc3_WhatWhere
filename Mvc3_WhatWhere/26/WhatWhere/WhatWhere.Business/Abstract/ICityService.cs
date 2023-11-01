using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICityService
    {
        // CRUD İşlemleri
        Task<City> GetByIdAsync(int id);// Bir şehri ID'ye göre getir
        Task<List<City>> GetAllAsync();// Tüm şehirleri getir
        Task CreateAsync(City city);// Yeni bir şehir oluştur
        void Update(City city);// Bir şehri güncelle
        void Delete(City city);// Bir şehri sil
    }
}
