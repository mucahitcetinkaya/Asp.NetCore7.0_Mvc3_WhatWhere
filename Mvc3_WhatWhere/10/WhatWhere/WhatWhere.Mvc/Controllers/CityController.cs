using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityManager;

        public CityController(ICityService cityManager)
        {
            _cityManager = cityManager;
        }

        public IActionResult Index()
        {

            var cities = _cityManager.GetAll();
            return View(cities);
        }

        public IActionResult GetCity(int id)
        {

            City cities = _cityManager.GetById(id);
            return View(cities);
        }
    }
}
