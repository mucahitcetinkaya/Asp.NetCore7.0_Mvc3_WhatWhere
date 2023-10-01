using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICityService
    {
        // CRUD İşlemleri

        // Belirli bir şehri getir
        City GetById(int id);

        // Tüm şehirleri getir
        List<City> GetAll();

        // Yeni bir şehir oluştur
        void Create(City city);

        // Bir şehri güncelle
        void Update(City city);

        // Bir şehri sil
        void Delete(City city);

        // Özelleştirme: Belirli bir dükkâna sahip olan şehirleri getir
        List<City> GetCitiesByShop(int shopId);

        // Özelleştirme: Belirli bir kategoriye sahip olan şehirleri getir
        List<City> GetCitiesByCategory(int categoryId);

        // Özelleştirme: Belirli bir kasabada bulunan şehirleri getir
        List<City> GetCitiesByTown(int townId);

        // Özelleştirme: Bir şehre bir dükkân atama
        void AssignShopToCity(int cityId, int shopId);

        // Özelleştirme: Bir şehirden dükkân çıkarma
        void RemoveShopFromCity(int cityId, int shopId);
    }
}
