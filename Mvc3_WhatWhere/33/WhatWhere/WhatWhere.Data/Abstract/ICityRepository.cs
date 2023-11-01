using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ICityRepository : IGenericRepository<City>
    {
        Task<List<City>> GetCitiesOrderByAsync();
        Task<City> GetCityNameWithOneCityAsync(string cityName);
        Task<List<City>> GetTownsListWithCityNameAsync(string cityName);

        Task<List<SelectListItem>> GetCitySelectListAsync();

    }
}
