using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

/*
 url e www ekle
 
 
 */

namespace WhatWhere.Mvc.Controllers
{
    public class DenemeController : Controller
    {
        private readonly IBossService _bossManager;
        private readonly ICategoryService _categoryManager;
        private readonly ICityService _cityManager;
        private readonly ISaleMembershipService _saleMembershipManager;
        private readonly IShopService _shopManager;
        private readonly ITownService _townManager;

        public DenemeController(IBossService bossManager, ICategoryService categoryManager, ICityService cityManager, ISaleMembershipService saleMembershipManager, IShopService shopManager, ITownService townManager)
        {
            _bossManager = bossManager;
            _categoryManager = categoryManager;
            _cityManager = cityManager;
            _saleMembershipManager = saleMembershipManager;
            _shopManager = shopManager;
            _townManager = townManager;
        }

        #region BOSS ALANI

        /*
        http://localhost:5160/Deneme/BGetByIdBoss/7
        */

        public async Task<IActionResult> BGetByIdBoss(int id)
        {
            Boss model = await _bossManager.GetByIdAsync(id);
            return View(model);
        }

        /*
        http://localhost:5160/Deneme/BGetAllBoss
        */

        public async Task<IActionResult> BGetAllBoss()
        {
            var model = await _bossManager.GetAllAsync();
            return View(model);
        }

        #endregion

        #region CATEGORY ALANI

        /*
        http://localhost:5160/Deneme/CGetByIdCategory/7
        */

        public async Task<IActionResult> CGetByIdCategory(int id)
        {
            var model = await _categoryManager.GetByIdAsync(id);
            return View(model);
        }

        /*
        http://localhost:5160/Deneme/CGetAllCategory
        */

        public async Task<IActionResult> CGetAllCategory()
        {
            var model = await _categoryManager.GetAllAsync();
            return View(model);
        }

        #endregion

        #region CITY ALANI

        /*
        http://localhost:5160/Deneme/CGetByIdCity/7
        */
        public async Task<IActionResult> CGetByIdCity(int id)
        {
            var model = await _cityManager.GetByIdAsync(id);
            return View(model);
        }

        /*
        http://localhost:5160/Deneme/CGetAllCity
        */
        public async Task<IActionResult> CGetAllCity()
        {
            var model = await _cityManager.GetAllAsync();
            return View(model);
        }

        /*
        http://localhost:5160/Deneme/CGetCitiesOrderBy
        */
        public async Task<IActionResult> CGetCitiesOrderBy()
        {
            var cities = await _cityManager.GetCitiesOrderByAsync();
            return View(cities);
        }

        // aynı controller de fazla action yazdıgında parametre yoksa eger kendi içinde onu tanıyor acılıyor
        // birden fazla action yazdıgında parametreleri varsa eger nereye gideceğini bilmiyor hata veriyor
        // bu sorunu cozmek için endpoint tanımlamak zorundasın 

        /*
        http://localhost:5160/Deneme/CGetCityNameWithOneCity/Ankara
        */
        public async Task<IActionResult> CGetCityNameWithOneCity(string cityName)
        {
            var cities = await _cityManager.GetCityNameWithOneCityAsync(cityName);
            return View(cities);
        }


        // endpoint sorunu burda da var acılıyor ama bos geliyor nereye giceğini bulamıyor
        // cagırılan parametreye cityName yerine "Ankara" dediğimiz de direk geliyor 

        /*
        http://localhost:5160/Deneme/CGetTownsListWithCityName/Ankara
        */
        public async Task<IActionResult> CGetTownsListWithCityName(string cityName)
        {
            var cities = await _cityManager.GetTownsListWithCityNameAsync("Ankara");
            return View(cities);
        }

        #endregion

        #region SALEMEMBERSHIP ALANI

        /*
        http://localhost:5160/Deneme/SMGetByIdSaleMembership/7
        */
        public async Task<IActionResult> SMGetByIdSaleMembership(int id)
        {
            var model = await _saleMembershipManager.GetByIdAsync(id);
            return View(model);
        }

        /*
        http://localhost:5160/Deneme/SMGetAllSaleMembership
        */
        public async Task<IActionResult> SMGetAllSaleMembership()
        {
            var model = await _saleMembershipManager.GetAllAsync();
            return View(model);
        }

        #endregion

        #region SHOP ALANI 

        /*
        http://localhost:5160/Deneme/SGetByIdShop/7
        */
        public async Task<IActionResult> SGetByIdShop(int id)
        {
            var model = await _shopManager.GetByIdAsync(id);
            return View(model);
        }

        /*
        http://localhost:5160/Deneme/SGetAllShop
        */
        public async Task<IActionResult> SGetAllShop()
        {
            var model = await _shopManager.GetAllAsync();
            return View(model);
        }

        /*
        http://localhost:5160/Deneme/SGetFullDataShop1
        */
        public async Task<IActionResult> SGetFullDataShop1()
        {
            var shops = await _shopManager.GetShopFullDataAsync();
            var model = shops.Select(s => new ShopViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Address = s.Address,
                PhoneNumber = s.PhoneNumber,
                MailAdress = s.MailAdress,
                Url = s.Url,
                IsActive = s.IsActive,
                ImageUrl = s.ImageUrl,
                IsHome = s.IsHome,
                BossId = (int)s.BossId,
                CategoryId = (int)s.CategoryId,
                CityId = (int)s.CityId,
                TownId = (int)s.TownId,
                City = s.City,
                Town = s.Town,
            }).ToList();

            return View(model);
        }

        /*
        http://localhost:5160/Deneme/SGetFullDataShop2
        */
        public async Task<IActionResult> SGetFullDataShop2()
        {
            List<Shop> model = await _shopManager.GetShopFullDataAsync();
            return View(model);
        }

        #endregion

        #region TOWN ALANI


        /*
        http://localhost:5160/Deneme/TGetByIdTown/255
        */
        public async Task<IActionResult> TGetByIdTown(int id)
        {
            var model = await _townManager.GetByIdAsync(id);
            return View(model);
        }

        /*
        http://localhost:5160/Deneme/TGetAllTown
        */
        public async Task<IActionResult> TGetAllTown()
        {
            var model = await _townManager.GetAllAsync();
            return View(model);
        }


        // TGetFullDataTown1 ile TGetFullDataTown2 nin farkı viewmodel den cagırması aynı seyleri cagırıyolar
        /*
        http://localhost:5160/Deneme/TGetFullDataTown1
        */
        public async Task<IActionResult> TGetFullDataTown1()
        {
            var model = await _townManager.GetTownFullDataAsync();
            var result = model.Select(t => new TownViewModel
            {
                Id = t.Id,
                Ilce = t.Ilce,
                City = t.City,
                CityId = t.CityId,
            }).ToList();
            return View(result);
        }

        /*
        http://localhost:5160/Deneme/TGetFullDataTown2
        */
        public async Task<IActionResult> TGetFullDataTown2()
        {
            var model = await _townManager.GetTownFullDataAsync();
            return View(model);
        }

        // endpointten dolayı null geliyor cityId yerine rakam verirsen direk calısıyor yada endpoint tanımlamak lazım 
        // sebebi aynı controller da parametresiz action da anlıyor ama parametre olunca nereye gideceğini anlamıyor 
        /*
        http://localhost:5160/Deneme/TGetTownListWithCityId/68
        */
        public async Task<IActionResult> TGetTownListWithCityId(int cityId)
        {
            var towns = await _townManager.GetTownListWithCityIdAsync(cityId);
            return View(towns);
        }

        // endpointten dolayı null geliyor cityName yerine "Ardahan" yazarsan direk calısıyor yada endpoint tanımlamak lazım 
        // sebebi aynı controller da parametresiz action da anlıyor ama parametre olunca nereye gideceğini anlamıyor 
        // endpoint yazıp cityName yolladım calısıyor 
        // sen bunları farklı controller da yazacaksın yani endpointlere gerek olmayacak
        /*
        http://localhost:5160/Deneme/TGetTownsListWithCityName/Ardahan
        */
        public async Task<IActionResult> TGetTownsListWithCityName(string cityName)
        {
            var model = await _townManager.GetTownsListWithCityNameAsync(cityName);
            return View(model);
        }

        #endregion

    }
}