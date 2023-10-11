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

        public async Task<IActionResult> Index()
        {
            var model = await _cityManager.GetAllAsync();
            return View(model);
        }

    }
}
