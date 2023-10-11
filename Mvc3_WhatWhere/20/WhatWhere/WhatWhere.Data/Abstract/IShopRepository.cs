using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface IShopRepository : IGenericRepository<Shop>
    {
        Task<List<Shop>> GetShopFullDataAsync();
    }
}
