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

        public IActionResult ChoseCity()
        {
            var cities = _cityService.GetAll();
            var viewModel = new CityViewModel
            {
                Cities = cities
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ChoseTown(int cityId)
        {
            TempData["selectedCityId"] = cityId;
            var towns = _townService.GetTownsByCity(cityId);
            var viewModel = new TownViewModel
            {
                Towns = towns,
                CityId = cityId
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ChoseCategory(int townId, int cityId)
        {
            TempData["townId"] = townId;
            var categories = _categoryService.GetAll();
            var viewModel = new CategoryViewModel
            {
                Categories = categories,
                CityId = cityId,
                TownId = townId
            };
            return View(viewModel);
        }
    }
}
