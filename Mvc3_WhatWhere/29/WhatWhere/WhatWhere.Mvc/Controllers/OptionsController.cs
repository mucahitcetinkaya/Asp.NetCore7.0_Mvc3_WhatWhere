using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;

namespace WhatWhere.Mvc.Controllers
{
    public class OptionsController : Controller
    {
        private readonly ICityService _cityManager;
        private readonly ITownService _townManager;
        private readonly ICategoryService _categoryManager;
        private readonly IShopService _shopManager;
        private readonly WhatWhereContext _context;

        public OptionsController(ICityService cityManager, ITownService townManager, ICategoryService categoryManager, IShopService shopManager, WhatWhereContext context)
        {
            _cityManager = cityManager;
            _townManager = townManager;
            _categoryManager = categoryManager;
            _shopManager = shopManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> GetCitiesOrderBy()
        {
            var cities = await _cityManager.GetCitiesOrderBy();
            return View(cities);
        }

        public async Task<IActionResult> GetTownsByCityId(int cityId)
        {
            var towns = await _townManager.GetTownListWithCityId(cityId);
            return View(towns);
        }
    }
}