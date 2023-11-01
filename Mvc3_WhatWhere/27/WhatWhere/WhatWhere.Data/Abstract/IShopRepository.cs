using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface IShopRepository : IGenericRepository<Shop>
    {
        Task<List<Shop>> GetShopFullDataAsync();
        Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null);
        Task<List<Shop>> GetShopsByCityAsync(string cityName = null);
        Task<List<Shop>> GetShopsByTownAsync(string townName = null);
    }
}
