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

        public async Task CreateAsync(Shop shop)
        {
            await _shopRepository.CreateAsync(shop);
        }

        public void Delete(Shop shop)
        {
            _shopRepository.Delete(shop);
        }

        public async Task<List<Shop>> GetAllAsync()
        {
            return await _shopRepository.GetAllAsync();
        }

        public async Task<Shop> GetByIdAsync(int id)
        {
            return await _shopRepository.GetByIdAsync(id);
        }

        public async Task<List<Shop>> GetShopFullDataAsync()
        {
            return await _shopRepository.GetShopFullDataAsync();
        }

        public async Task<List<Shop>> GetShopsByCategoryAsync(string categoryName)
        {
            return await _shopRepository.GetShopsByCategoryAsync(categoryName);
        }

        public async Task<List<Shop>> GetShopsByCityAsync(string cityName)
        {
            return await _shopRepository.GetShopsByCityAsync(cityName);
        }

        public async Task<List<Shop>> GetShopsByTownAsync(string townName)
        {
            return await _shopRepository.GetShopsByTownAsync(townName);
        }
        public void Update(Shop shop)
        {
            _shopRepository.Update(shop);
        }

    }
}
