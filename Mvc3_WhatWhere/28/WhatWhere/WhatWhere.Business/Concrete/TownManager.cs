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

        public async Task CreateAsync(Town town)
        {
            _townRepository.CreateAsync(town);
        }

        public void Delete(Town town)
        {
            _townRepository.Delete(town);
        }

        public async Task<List<Town>> GetAllAsync()
        {
            return await _townRepository.GetAllAsync();
        }

        public async Task<Town> GetByIdAsync(int id)
        {
            return await _townRepository.GetByIdAsync(id);
        }

        public async Task<List<Town>> GetTownFullDataAsync()
        {
            return await _townRepository.GetTownFullDataAsync();
        }

        public async Task<List<Town>> GetTownListWithCityId(int cityId)
        {
            return await _townRepository.GetTownListWithCityId(cityId);
        }

        public async Task<List<Town>> GetTownsListWithCityName(string cityName)
        {
            return await _townRepository.GetTownsListWithCityName(cityName);
        }

        public void Update(Town town)
        {
            _townRepository.Update(town);
        }
    }
}