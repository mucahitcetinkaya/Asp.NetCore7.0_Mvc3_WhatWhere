using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public void Delete(City city)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        public City GetById(int id)
        {
            return _cityRepository.GetById(id);
        }

        public List<City> GetCitiesByShop(int shopId)
        {
            throw new NotImplementedException();
        }

        public void Update(City city)
        {
            throw new NotImplementedException();
        }
    }
}
