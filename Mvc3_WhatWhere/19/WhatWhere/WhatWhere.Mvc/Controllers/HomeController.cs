using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBossService _bossManager;
        private readonly ICategoryService _categoryManager;
        private readonly ICityService _cityManager;
        private readonly ISaleMembershipService _saleMembershipManager;
        private readonly IShopService _shopManager;

        public HomeController(IBossService bossManager, ICategoryService categoryManager, ICityService cityManager, ISaleMembershipService saleMembershipManager, IShopService shopManager)
        {
            _bossManager = bossManager;
            _categoryManager = categoryManager;
            _cityManager = cityManager;
            _saleMembershipManager = saleMembershipManager;
            _shopManager = shopManager;
        }

        //public IActionResult Index()
        //{

        //    var model = _shopManager.GetAll().ToList();
        //    return View(model);
        //}

        public IActionResult Index()
        {

            var model = _categoryManager.GetAll().ToList();
            return View(model);
        }
    }
}
