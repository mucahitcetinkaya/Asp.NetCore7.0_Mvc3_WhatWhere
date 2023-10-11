using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _shopManager;
        private readonly ICityService _cityManager;
        private readonly ITownService _townManager;

        public ShopController(IShopService shopManager, ICityService cityManager, ITownService townManager)
        {
            _shopManager = shopManager;
            _cityManager = cityManager;
            _townManager = townManager;
        }

        //public IActionResult Index()
        //{
        //    var model = _shopManager.GetAll().ToList();
        //    return View(model);
        //}

        public IActionResult Index()
        {
            var model = _shopManager.GetAllIncludingCityAndTown();
            return View(model);
        }

    }
}