using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ITownRepository : IGenericRepository<Town>
    {
        Task<List<Town>> GetTownFullDataAsync();
        Task<List<Town>> GetTownListWithCityId(int cityId);
        Task<List<Town>> GetTownsListWithCityName(string cityName);
    }
}
