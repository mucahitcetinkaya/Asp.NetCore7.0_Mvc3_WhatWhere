using WhatWhere.Business.Abstract;
using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Concrete
{
    public class CityManager : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityManager(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public async Task<City> GetByIdAsync(int id)
        {
            return await _cityRepository.GetByIdAsync(id);
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await _cityRepository.GetAllAsync();
        }

        public async Task CreateAsync(City city)
        {
            await _cityRepository.CreateAsync(city);
        }

        public void Update(City city)
        {
            _cityRepository.Update(city);
        }

        public void Delete(City city)
        {
            _cityRepository.Delete(city);
        }

        public async Task<List<City>> GetCitiesOrderBy()
        {
            return await _cityRepository.GetCitiesOrderBy();
        }

        public async Task<City> GetCityNameWithOneCity(string cityName)
        {
            return await _cityRepository.GetCityNameWithOneCity(cityName);

        }

        public async Task<List<City>> GetTownsListWithCityName(string cityName)
        {
            return await _cityRepository.GetTownsListWithCityName(cityName);

        }
    }
}
