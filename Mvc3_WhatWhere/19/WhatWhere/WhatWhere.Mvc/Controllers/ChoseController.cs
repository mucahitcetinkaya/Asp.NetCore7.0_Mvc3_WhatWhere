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

        public IActionResult Index()
        {
            var viewModel = new ChoseViewModel
            {
                Cities = _cityManager.GetAll(),
                Towns = _townManager.GetAllIncludingCity(),
                Categories = _categoryManager.GetAll(),
                Shops = _shopManager.GetAllIncludingCityAndTown()
            };

            return View(viewModel);
        }

        public IActionResult ChoseCity()
        {
            var city = _cityManager.GetAll();
            return View(city);
        }

        public IActionResult ChoseTown()
        {
            var town = _townManager.GetAllIncludingCity();
            return View(town);
        }

        public IActionResult ChoseCategory()
        {
            var category = _categoryManager.GetAll();
            return View(category);
        }

        public IActionResult ChoseShop()
        {
            var shop = _shopManager.GetAllIncludingCityAndTown();
            return View(shop);
        }
    }
}