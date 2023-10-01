using WhatWhere.Business.Abstract;
using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Concrete
{
    public class ShopManager : IShopService
    {
        private readonly IShopRepository _shopRepository;

        public ShopManager(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public Shop GetById(int id)
        {
            // Belirli bir dükkânın detaylarını getiren metot
            return _shopRepository.GetById(id);
        }

        public List<Shop> GetAll()
        {
            // Tüm dükkânları getiren metot
            return _shopRepository.GetAll();
        }

        public void Create(Shop shop)
        {
            // Yeni bir dükkân oluşturan metot
            _shopRepository.Create(shop);
        }

        public void Update(Shop shop)
        {
            // Bir dükkânı güncelleyen metot
            _shopRepository.Update(shop);
        }

        public void Delete(Shop shop)
        {
            // Bir dükkânı silen metot
            _shopRepository.Delete(shop);
        }

        public List<Category> GetCategoriesOfShop(int shopId)
        {
            // Bir dükkânın kategorilerini getiren metot
            return _shopRepository.GetCategoriesOfShop(shopId);
        }

        public City GetCityOfShop(int shopId)
        {
            // Bir dükkânın bulunduğu şehri getiren metot
            return _shopRepository.GetCityOfShop(shopId);
        }

        public Town GetTownOfShop(int shopId)
        {
            // Bir dükkânın bulunduğu kasabayı getiren metot
            return _shopRepository.GetTownOfShop(shopId);
        }

        public Boss GetBossOfShop(int shopId)
        {
            // Bir dükkânın patronunu getiren metot
            return _shopRepository.GetBossOfShop(shopId);
        }

        public void AssignBossToShop(int shopId, int bossId)
        {
            // Bir dükkâna bir patron atayan metot
            _shopRepository.AssignBossToShop(shopId, bossId);
        }

        public void RemoveBossFromShop(int shopId, int bossId)
        {
            // Bir dükkândan patron çıkaran metot
            _shopRepository.RemoveBossFromShop(shopId, bossId);
        }

        public void ActivateShop(int shopId)
        {
            // Bir dükkânı etkinleştiren metot
            _shopRepository.ActivateShop(shopId);
        }

        public void DeactivateShop(int shopId)
        {
            // Bir dükkânı pasifleştiren metot
            _shopRepository.DeactivateShop(shopId);
        }

        public List<Shop> GetShopOfTown(int townId, int categoryId)
        {
           return _shopRepository.GetShopOfTown(townId, categoryId);
        }

        public List<Shop> GetShopsByCityTownAndCategory(int cityId, int townId, int categoryId)
        {
            return _shopRepository.GetShopsByCityTownAndCategory(cityId, townId, categoryId);
        }
    }
}
