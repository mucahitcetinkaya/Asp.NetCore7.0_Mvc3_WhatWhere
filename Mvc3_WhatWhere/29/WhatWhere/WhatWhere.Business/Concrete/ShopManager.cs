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

        public async Task<Shop> GetByIdAsync(int id)
        {
            return await _shopRepository.GetByIdAsync(id);
        }

        public async Task<List<Shop>> GetAllAsync()
        {
            return await _shopRepository.GetAllAsync();
        }

        public async Task CreateAsync(Shop shop)
        {
            await _shopRepository.CreateAsync(shop);
        }

        public void Update(Shop shop)
        {
            _shopRepository.Update(shop);
        }

        public async void Delete(Shop shop)
        {
            _shopRepository.Delete(shop);
        }



        public async Task<List<Shop>> GetShopFullDataAsync()
        {
            return await _shopRepository.GetShopFullDataAsync();
        }

        public async Task<List<Shop>> GetAllShopsWithCityTownCategoryAsync(bool isDeleted, bool? isActive = null)
        {
            var result = await _shopRepository.GetAllShopsWithCityTownCategoryAsync(isDeleted, isActive);
            return result;
        }

        public async Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null)
        {
            return await _shopRepository.GetShopsByCategoryAsync(categoryName);
        }

        public async Task<List<Shop>> GetShopsByFilter(int? cityId, int? townId, int? categoryId)
        {
            return await _shopRepository.GetShopsByFilter(cityId, townId, categoryId);
        }



        //public async Task CreateShopAsync(Shop shop, int categoryId, int cityId, int townId)
        //{
        //    await _shopRepository.CreateShopAsync(shop,categoryId, cityId, townId);
        //}

        //public async Task CheckShopsCategories()
        //{
        //    _shopRepository.CheckShopsCategories();
        //}

        //public void UpdateShop(Shop shop)
        //{
        //    _shopRepository.UpdateShop(shop);
        //}

    }
}