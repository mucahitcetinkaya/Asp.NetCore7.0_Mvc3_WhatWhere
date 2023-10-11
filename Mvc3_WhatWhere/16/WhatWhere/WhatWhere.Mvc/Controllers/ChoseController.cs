using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class ChoseController : Controller
    {
        private readonly ICityService _cityService;
        private readonly ITownService _townService;
        private readonly ICategoryService _categoryService;
        private readonly IShopService _shopService;

        public ChoseController(ICityService cityService, ITownService townService, ICategoryService categoryService, IShopService shopService)
        {
            _cityService = cityService;
            _townService = townService;
            _categoryService = categoryService;
            _shopService = shopService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChoseCity()
        {
            var city = _cityService.GetAll();
            var viewModel = new CityViewModel
            {
                Cities = city
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ChoseTown()
        {
            var town = _townService.GetAll();
            var viewModel = new TownViewModel
            {
                Towns = town
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ChoseCategory()
        {
            var category = _categoryService.GetAll();
            var viewModel = new CategoryViewModel
            {
                Categories = category,
            };
            return View(viewModel);
        }

        public IActionResult ChoseShop()
        {
            var shop = _shopService.GetAll();
            var viewModel = new ShopViewModel
            {
                Shops = shop,
            };
            return View(viewModel);
        }
    }
}