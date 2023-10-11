using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ITownService
    {
        // CRUD işlemleri
        Town GetById(int id);// Bir kasabayı ID'ye göre getir
        List<Town> GetAll();// Tüm kasabaları getir
        void Create(Town town);// Yeni bir kasaba oluştur
        void Update(Town town);// Bir kasabayı güncelle
        void Delete(Town town);// Bir kasabayı sil
        List<Town> GetTownsByCity(int cityId);// Bir şehre bağlı olan kasabaları getir
        List<Town> GetAllIncludingCity();
    }
}
