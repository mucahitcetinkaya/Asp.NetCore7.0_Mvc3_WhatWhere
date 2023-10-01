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

        // Özelleştirme: Bir dükkânın kategorilerini getir
        List<Category> GetCategoriesOfShop(int shopId);

        // Özelleştirme: Bir dükkânın bulunduğu şehri getir
        City GetCityOfShop(int shopId);

        // Özelleştirme: Bir dükkânın bulunduğu kasabayı getir
        Town GetTownOfShop(int shopId);
        
        // Özelleştirme: Bir dükkânın patronunu getir
        Boss GetBossOfShop(int shopId);

        // Özelleştirme: Bir dükkâna bir patron atama
        void AssignBossToShop(int shopId, int bossId);

        // Özelleştirme: Bir dükkândan patron çıkarma
        void RemoveBossFromShop(int shopId, int bossId);

        // Özelleştirme: Bir dükkânı etkinleştirme
        void ActivateShop(int shopId);

        // Özelleştirme: Bir dükkânı pasifleştirme
        void DeactivateShop(int shopId);
    }
}