using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ITownRepository : IGenericRepository<Town>
    {
        // Belirli bir şehre bağlı olan kasabaları getir
        List<Town> GetTownsByCity(int cityId);

        // Belirli bir dükkâna bağlı olan kasabayı getir
        Town GetTownByShop(int shopId);

        // Bir kasabaya bir dükkân atama
        void AssignShopToTown(int townId, int shopId);

        // Bir kasabadan dükkân çıkarma
        void RemoveShopFromTown(int townId, int shopId);

        // Belirli kasabaların şehirlerini getir
        List<City> GetCitiesByTowns(List<int> townIds);

        // Belirli kategorilere sahip olan dükkânları getir
        List<Shop> GetShopsByCategory(List<int> categoryIds);
    }
}
