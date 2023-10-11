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

        public void Create(City city)
        {
            _cityRepository.Create(city);
        }

        public void Delete(City city)
        {
            _cityRepository.Delete(city);
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public City GetById(int id)
        {
            return _cityRepository.GetById(id);
        }

        public void Update(City city)
        {
            _cityRepository.Update(city);
        }
    }
}
