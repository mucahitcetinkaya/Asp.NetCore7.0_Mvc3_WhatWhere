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

        public async Task<List<Town>> GetTownsByCityAsync(string cityName)
        {
            return await _townRepository.GetTownsByCityAsync(cityName);
        }

        public async Task<List<Town>> GetTownsByCityIdAsync(int cityId)
        {
            return await _townRepository.GetTownsByCityIdAsync(cityId);
        }

        public void Update(Town town)
        {
            _townRepository.Update(town);
        }
    }
}