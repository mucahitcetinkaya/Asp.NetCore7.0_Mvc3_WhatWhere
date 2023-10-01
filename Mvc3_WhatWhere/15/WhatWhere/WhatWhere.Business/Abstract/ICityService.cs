using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICityService
    {
        // CRUD İşlemleri
        City GetById(int id);// Bir şehri ID'ye göre getir
        List<City> GetAll();// Tüm şehirleri getir
        void Create(City city);// Yeni bir şehir oluştur
        void Update(City city);// Bir şehri güncelle
        void Delete(City city);// Bir şehri sil
    }
}
