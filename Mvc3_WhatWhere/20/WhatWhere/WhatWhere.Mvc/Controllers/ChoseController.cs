using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class ChoseController : Controller
    {
        private readonly ICityService _cityManager;
        private readonly ITownService _townManager;
        private readonly ICategoryService _categoryManager;
        private readonly IShopService _shopManager;

        public ChoseController(ICityService cityManager, ITownService townManager, ICategoryService categoryManager, IShopService shopManager)
        {
            _cityManager = cityManager;
            _townManager = townManager;
            _categoryManager = categoryManager;
            _shopManager = shopManager;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new ChoseViewModel
            {
                Cities = await _cityManager.GetAllAsync(),
                Towns = await _townManager.GetTownFullDataAsync(),
                Categories = await _categoryManager.GetAllAsync(),
                Shops = await _shopManager.GetShopFullDataAsync()
            };

            return View(viewModel);
        }

        public async Task<IActionResult> ChoseCity()
        {
            var city = await _cityManager.GetAllAsync();
            return View(city);
        }

        public async Task<IActionResult> ChoseTown()
        {
            var town = await _townManager.GetTownFullDataAsync();
            return View(town);
        }

        public async Task<IActionResult> ChoseCategory()
        {
            var category = await _categoryManager.GetAllAsync();
            return View(category);
        }

        public async Task<IActionResult> ChoseShop()
        {
            var shop = await _shopManager.GetShopFullDataAsync();
            return View(shop);
        }
    }
}