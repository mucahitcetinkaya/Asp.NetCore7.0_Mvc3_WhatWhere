using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class OptionsController : Controller
    {
        private readonly ICityService _cityManager;
        private readonly ITownService _townManager;
        private readonly ICategoryService _categoryManager;
        private readonly IShopService _shopManager;

        public OptionsController(ICityService cityManager, ITownService townManager, ICategoryService categoryManager, IShopService shopManager)
        {
            _cityManager = cityManager;
            _townManager = townManager;
            _categoryManager = categoryManager;
            _shopManager = shopManager;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new OptionsViewModel
            {
                Cities = await _cityManager.GetAllAsync(),
                Towns = await _townManager.GetTownFullDataAsync(),
                Categories = await _categoryManager.GetAllAsync(),
                Shops = await _shopManager.GetShopFullDataAsync()
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetTownsByCityId(int cityId)
        {
            var towns = await _townManager.GetTownsByCityIdAsync(cityId);
            return PartialView("OptionsTown", towns);
        }

        //public async Task<IActionResult> OptionsCity()
        //{
        //    var city = await _cityManager.GetAllAsync();
        //    return View(city);
        //}

        //public async Task<IActionResult> OptionsTown()
        //{
        //    var town = await _townManager.GetTownFullDataAsync();
        //    return View(town);
        //}

        //public async Task<IActionResult> OptionsCategory()
        //{
        //    var category = await _categoryManager.GetAllAsync();
        //    return View(category);
        //}

        //public async Task<IActionResult> OptionsShop()
        //{
        //    var shop = await _shopManager.GetShopFullDataAsync();
        //    return View(shop);
        //}


    }
}