using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        public IActionResult Index()
        {
            var cities = _cityService.GetAll();
            return View(cities);
        }

        [HttpPost]
        public IActionResult SelectedCities()
        {
           return View();
        }

        [HttpPost]
        public IActionResult SelectedTowns()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SelectedCategory()
        {
            return View();
        }
    }
}
