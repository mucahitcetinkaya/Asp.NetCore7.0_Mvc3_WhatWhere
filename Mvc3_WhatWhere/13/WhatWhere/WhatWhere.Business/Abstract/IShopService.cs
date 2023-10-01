using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    // IShopService CRUD İşlemleri ve Özelleştirme Kodları
    public interface IShopService
    {
        // CRUD İşlemleri
        Shop GetById(int id);
        List<Shop> GetAll();
        void Create(Shop shop);
        void Update(Shop shop);
        void Delete(Shop shop);

        // Bir dükkânın bulunduğu şehri getir
        City GetCityOfShop(int shopId);

        // Bir dükkânın bulunduğu kasabayı getir
        Town GetTownOfShop(int shopId);
        
        // Bir dükkânın patronunu getir
        Boss GetBossOfShop(int shopId);

        // Bir dükkâna bir patron atama
        void AssignBossToShop(int shopId, int bossId);

        // Bir dükkândan patron çıkarma
        void RemoveBossFromShop(int shopId, int bossId);

        // Bir dükkânı etkinleştirme
        void ActivateShop(int shopId);

        // Bir dükkânı pasifleştirme
        void DeactivateShop(int shopId);

        // İlçe ve Kategoriye göre dükkan getirme
        List<Shop> GetShopOfTown(int townId, int categoryId);
    }
}