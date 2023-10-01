using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface IShopRepository : IGenericRepository<Shop>
    {
        // Bir dükkânın kategorilerini getir
        List<Category> GetCategoriesOfShop(int shopId);

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
