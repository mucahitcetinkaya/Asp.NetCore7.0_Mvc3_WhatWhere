using Microsoft.AspNetCore.Mvc.Rendering;
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


        public async Task<List<City>> GetCitiesOrderByAsync()
        {
            return await _cityRepository.GetCitiesOrderByAsync();
        }

        public async Task<City> GetCityNameWithOneCityAsync(string cityName)
        {
            return await _cityRepository.GetCityNameWithOneCityAsync(cityName);

        }

        public async Task<List<City>> GetTownsListWithCityNameAsync(string cityName)
        {
            return await _cityRepository.GetTownsListWithCityNameAsync(cityName);

        }

        public async Task<List<SelectListItem>> GetCitySelectList()
        {
            var result = await _cityRepository.GetCitySelectList();
            return result;
        }
    }
}
