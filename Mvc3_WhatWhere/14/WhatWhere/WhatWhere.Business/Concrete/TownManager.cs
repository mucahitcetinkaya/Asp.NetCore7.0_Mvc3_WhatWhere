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

        public Town GetById(int id)
        {
            return _townRepository.GetById(id);
        }

        public List<Town> GetAll()
        {
            return _townRepository.GetAll();
        }

        public void Create(Town town)
        {
            _townRepository.Create(town);
        }

        public void Update(Town town)
        {
            _townRepository.Update(town);
        }

        public void Delete(Town town)
        {
            _townRepository.Delete(town);
        }

        public List<Town> GetTownsByCity(int cityId)
        {
            return _townRepository.GetTownsByCity(cityId);
        }

        public Town GetTownByShop(int shopId)
        {
            return _townRepository.GetTownByShop(shopId);
        }

        public void AssignShopToTown(int townId, int shopId)
        {
            _townRepository.AssignShopToTown(townId, shopId);
        }

        public void RemoveShopFromTown(int townId, int shopId)
        {
            _townRepository.RemoveShopFromTown(townId, shopId);
        }

        public List<City> GetCitiesByTowns(List<int> townIds)
        {
            return _townRepository.GetCitiesByTowns(townIds);
        }

        public List<Shop> GetShopsByCategory(List<int> categoryIds)
        {
            return _townRepository.GetShopsByCategory(categoryIds);
        }
    }
}
