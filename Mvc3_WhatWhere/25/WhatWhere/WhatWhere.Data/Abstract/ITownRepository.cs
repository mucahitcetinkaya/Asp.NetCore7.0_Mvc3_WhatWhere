using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ITownRepository : IGenericRepository<Town>
    {
        Task<List<Town>> GetTownFullDataAsync();
        Task<List<Town>> GetTownsByCityIdAsync(int cityId);
        Task<List<Town>> GetTownsByCityAsync(string cityName);
    }
}
