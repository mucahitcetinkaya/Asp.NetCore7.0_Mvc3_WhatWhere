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

        public void Create(Town town)
        {
            _townRepository.Create(town);
        }

        public void Delete(Town town)
        {
            _townRepository.Delete(town);
        }

        public List<Town> GetAll()
        {
            return _townRepository.GetAll();
        }

        public Town GetById(int id)
        {
            return _townRepository.GetById(id);
        }

        public void Update(Town town)
        {
            _townRepository.Update(town);
        }

        public List<Town> GetTownsByCity(int cityId)
        {
            return _townRepository.GetTownsByCity(cityId);
        }

        public List<Town> GetAllIncludingCity()
        {
            return _townRepository.GetAllIncludingCity();
        }
    }
}
