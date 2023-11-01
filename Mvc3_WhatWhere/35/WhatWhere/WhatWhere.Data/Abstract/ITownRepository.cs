using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ITownRepository : IGenericRepository<Town>
    {
        Task<List<Town>> GetTownFullDataAsync();
        Task<List<Town>> GetTownListWithCityIdAsync(int cityId);
        Task<List<Town>> GetTownsListWithCityNameAsync(string cityName);
        Task<List<SelectListItem>> GetTownsByCityIdAsync(int cityId);
        Task<List<SelectListItem>> GetTownSelectListAsync();


    }
}
