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

        public void Create(Shop shop)
        {
            _shopRepository.Create(shop);
        }

        public void Delete(Shop shop)
        {
            _shopRepository.Delete(shop);
        }

        public List<Shop> GetAll()
        {
            return _shopRepository.GetAll();
        }

        public Shop GetById(int id)
        {
            return _shopRepository.GetById(id);
        }

        public void Update(Shop shop)
        {
            _shopRepository.Update(shop);
        }

        public void AssignBossToShop(int shopId, int bossId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkâna bossId'yi atama işlemi yapılacak
            _shopRepository.AssignBossToShop(shopId, bossId);
        }

        public void AssignCategoryToShop(int shopId, int categoryId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkâna categoryId'yi atama işlemi yapılacak
            _shopRepository.AssignCategoryToShop(shopId, categoryId);
        }

        public void AssignCityToShop(int shopId, int cityId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkâna cityId'yi atama işlemi yapılacak
            _shopRepository.AssignCityToShop(shopId, cityId);
        }

        public void AssignTownToShop(int shopId, int townId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkâna townId'yi atama işlemi yapılacak
            _shopRepository.AssignTownToShop(shopId, townId);
        }

        public Boss GetBossOfShop(int shopId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkâna ait patronu getir
            return _shopRepository.GetBossOfShop(shopId);
        }

        public Category GetCategoryOfShop(int shopId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkâna ait kategoriyi getir
            return _shopRepository.GetCategoryOfShop(shopId);
        }

        public City GetCityOfShop(int shopId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkâna ait şehri getir
            return _shopRepository.GetCityOfShop(shopId);
        }

        public Town GetTownOfShop(int shopId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkâna ait kasabayı getir
            return _shopRepository.GetTownOfShop(shopId);
        }

        public void RemoveBossFromShop(int shopId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkândan patronu kaldırma işlemi yapılacak
            _shopRepository.RemoveBossFromShop(shopId);
        }

        public void RemoveCategoryFromShop(int shopId, int categoryId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkândan belirli bir kategoriyi kaldırma işlemi yapılacak
            _shopRepository.RemoveCategoryFromShop(shopId, categoryId);
        }

        public void RemoveCityFromShop(int shopId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkândan şehri kaldırma işlemi yapılacak
            _shopRepository.RemoveCityFromShop(shopId);
        }

        public void RemoveTownFromShop(int shopId)
        {
            // TODO: Veritabanında shopId'ye sahip dükkândan kasabayı kaldırma işlemi yapılacak
            _shopRepository.RemoveTownFromShop(shopId);
        }
    }
}
