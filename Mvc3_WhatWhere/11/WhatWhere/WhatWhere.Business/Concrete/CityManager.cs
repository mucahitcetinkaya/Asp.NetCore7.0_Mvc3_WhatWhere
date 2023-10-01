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

        // Belirli bir şehri getirme işlemi
        public City GetById(int id)
        {
            return _cityRepository.GetById(id);
        }

        // Tüm şehirleri getirme işlemi
        public List<City> GetAll()
        {
            return _cityRepository.GetAll();
        }

        // Yeni bir şehir oluşturma işlemi
        public void Create(City city)
        {
            _cityRepository.Create(city);
        }

        // Bir şehri güncelleme işlemi
        public void Update(City city)
        {
            _cityRepository.Update(city);
        }

        // Bir şehri silme işlemi
        public void Delete(City city)
        {
            _cityRepository.Delete(city);
        }

        // Belirli bir dükkâna sahip olan şehirleri getirme işlemi
        public List<City> GetCitiesByShop(int shopId)
        {
            return _cityRepository.GetCitiesByShop(shopId);
        }

        // Belirli bir kategoriye sahip olan şehirleri getirme işlemi
        public List<City> GetCitiesByCategory(int categoryId)
        {
            return _cityRepository.GetCitiesByCategory(categoryId);
        }

        // Belirli bir kasabada bulunan şehirleri getirme işlemi
        public List<City> GetCitiesByTown(int townId)
        {
            return _cityRepository.GetCitiesByTown(townId);
        }

        // Bir şehre bir dükkân atama işlemi
        public void AssignShopToCity(int cityId, int shopId)
        {
            _cityRepository.AssignShopToCity(cityId, shopId);
        }

        // Bir şehirden dükkân çıkarma işlemi
        public void RemoveShopFromCity(int cityId, int shopId)
        {
            _cityRepository.RemoveShopFromCity(cityId, shopId);
        }
    }
}
