using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ITownService
    {
        // CRUD İşlemleri

        // Belirli bir kasabayı getir
        Town GetById(int id);

        // Tüm kasabaları getir
        List<Town> GetAll();

        // Yeni bir kasaba oluştur
        void Create(Town town);

        // Bir kasabayı güncelle
        void Update(Town town);

        // Bir kasabayı sil
        void Delete(Town town);

        // Belirli bir şehre bağlı olan kasabaları getir
        List<Town> GetTownsByCity(int cityId);

        // Bir kasabaya bir dükkân atama
        void AssignShopToTown(int townId, int shopId);

        // Bir kasabadan dükkân çıkarma
        void RemoveShopFromTown(int townId, int shopId);
    }
}
