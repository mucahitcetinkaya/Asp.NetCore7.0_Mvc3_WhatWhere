using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ICityRepository : IGenericRepository<City>
    {
        Task<List<City>> GetCitiesOrderBy();
        Task<City> GetCityNameWithOneCity(string cityName);
        Task<List<City>> GetTownsListWithCityName(string cityName);
    }
}
