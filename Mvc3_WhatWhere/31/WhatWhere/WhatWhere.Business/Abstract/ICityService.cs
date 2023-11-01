using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICityService
    {
        // CRUD İşlemleri
        Task<City> GetByIdAsync(int id);// Bir şehri ID'ye göre getir
        Task<List<City>> GetAllAsync();// Tüm şehirleri getir
        Task CreateAsync(City city);// Yeni bir şehir oluştur
        void Update(City city);// Bir şehri güncelle
        void Delete(City city);// Bir şehri sil

        Task<List<City>> GetCitiesOrderByAsync();
        Task<City> GetCityNameWithOneCityAsync(string cityName);
        Task<List<City>> GetTownsListWithCityNameAsync(string cityName);

        Task<List<SelectListItem>> GetCitySelectList();

    }
}
