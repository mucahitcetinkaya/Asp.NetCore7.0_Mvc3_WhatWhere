using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ICityRepository : IGenericRepository<City>
    {
        // Belirli bir dükkâna sahip olan şehirleri getir
        List<City> GetCitiesByShop(int shopId);

        // Belirli bir kategoriye sahip olan şehirleri getir
        List<City> GetCitiesByCategory(int categoryId);

        // Belirli bir kasabada bulunan şehirleri getir
        List<City> GetCitiesByTown(int townId);

        // Bir şehre bir dükkân atama
        void AssignShopToCity(int cityId, int shopId);

        // Bir şehirden dükkân çıkarma
        void RemoveShopFromCity(int cityId, int shopId);
    }
}
