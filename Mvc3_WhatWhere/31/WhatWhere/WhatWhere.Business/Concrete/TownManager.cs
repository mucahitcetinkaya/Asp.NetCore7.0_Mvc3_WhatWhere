using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Business.Abstract;
using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Concrete
{
    public class TownManager : ITownService
    {
        private readonly ITownRepository _townRepository;

        public TownManager(ITownRepository townRepository)
        {
            _townRepository = townRepository;
        }

        public async Task<Town> GetByIdAsync(int id)
        {
            return await _townRepository.GetByIdAsync(id);
        }

        public async Task<List<Town>> GetAllAsync()
        {
            return await _townRepository.GetAllAsync();
        }

        public async Task CreateAsync(Town town)
        {
            _townRepository.CreateAsync(town);
        }

        public void Update(Town town)
        {
            _townRepository.Update(town);
        }

        public void Delete(Town town)
        {
            _townRepository.Delete(town);
        }

        

        

        public async Task<List<Town>> GetTownFullDataAsync()
        {
            return await _townRepository.GetTownFullDataAsync();
        }

        public async Task<List<Town>> GetTownListWithCityIdAsync(int cityId)
        {
            return await _townRepository.GetTownListWithCityIdAsync(cityId);
        }
        public async Task<List<Town>> GetTownsListWithCityNameAsync(string cityName)
        {
            return await _townRepository.GetTownsListWithCityNameAsync(cityName);
        }

        public async Task<List<SelectListItem>> GetTownsByCityIdAsync(int cityId)
        {
            return await _townRepository.GetTownsByCityIdAsync(cityId);

        }

        public async Task<List<SelectListItem>> GetTownSelectList()
        {
            return await _townRepository.GetTownSelectList();
        }
    }
}