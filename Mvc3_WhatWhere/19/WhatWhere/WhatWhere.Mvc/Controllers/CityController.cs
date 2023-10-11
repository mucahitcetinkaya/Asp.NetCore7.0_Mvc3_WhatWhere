using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

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
            var model = _cityManager.GetAll().ToList();
            return View(model);
        }

    }
}
