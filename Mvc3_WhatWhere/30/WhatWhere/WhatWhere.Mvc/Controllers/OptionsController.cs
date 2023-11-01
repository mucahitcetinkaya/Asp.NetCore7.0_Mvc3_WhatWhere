using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class OptionsController : Controller
    {
        private readonly IShopService _shopManager;
        private readonly ICategoryService _categoryManager;
        private readonly ICityService _cityManager;
        private readonly ITownService _townManager;

        public OptionsController(IShopService shopManager, ICategoryService categoryManager, ICityService cityManager, ITownService townManager)
        {
            _shopManager = shopManager;
            _categoryManager = categoryManager;
            _cityManager = cityManager;
            _townManager = townManager;
        }

        [NonAction]
        private async Task<List<ShopViewModel>> GetShopFullDataNonAction()
        {
            List<Shop> shopList = await _shopManager.GetShopFullDataAsync();
            List<ShopViewModel> shopViewModelList = shopList.Select(shop => new ShopViewModel
            {
                Id = shop.Id,
                Name = shop.Name,
                PhoneNumber = shop.PhoneNumber,
                MailAdress = shop.MailAdress,
                Url = shop.Url,
                Description = shop.Description,
                ImageUrl = shop.ImageUrl,
                Address = shop.Address,
                IsHome = shop.IsHome,
                IsActive = shop.IsActive,
                IsDeleted = shop.IsDeleted,
                CreatedDate = shop.CreatedDate,
                ModifiedDate = shop.ModifiedDate,
                BossId = shop.BossId,
                Boss = shop.Boss,
                CategoryId = shop.CategoryId,
                Category = shop.Category,
                CityId = shop.CityId,
                City = shop.City,
                TownId = shop.TownId,
                Town = shop.Town
            }).ToList();
            return shopViewModelList;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categorySelectList = await _categoryManager.GetCategorySelectList();
            var citySelectList = await _cityManager.GetCitySelectList();
            var townSelectList = await _townManager.GetTownSelectList();
            var shopFullData = await GetShopFullDataNonAction();

            CityTownCategoryShopViewModel cityTownCategoryShopViewModel = new CityTownCategoryShopViewModel
            {
                CategoriesSelectList = categorySelectList,
                CitiesSelectList = citySelectList,
                TownsSelectList = townSelectList,
                Shops = shopFullData
            };

            return View(cityTownCategoryShopViewModel);
        }


        [HttpGet]
        public async Task<List<SelectListItem>> GetCategoriesByCityId(int cityId)
        {
            var result = await _shopManager.GetCategoriesByCityIdAsync(cityId);
            return result;
        }

        [HttpGet]
        public async Task<List<SelectListItem>> GetCategoriesByTownId(int townId)
        {
            var result = await _shopManager.GetCategoriesByTownIdAsync(townId);
            return result;
        }

        [HttpGet]
        public async Task<List<Shop>> GetFilteredShops(int cityId, int townId, int categoryId)
        {
            var result = await _shopManager.GetFilteredShopsAsync(cityId, townId, categoryId);
            return result;
        }

        [HttpGet]
        public async Task<List<SelectListItem>> GetTownsByCityId(int cityId)
        {
            var result = await _townManager.GetTownsByCityIdAsync(cityId);
            return result;
        }

    }
}