using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShopService _shopService;

        public HomeController(IShopService shopService)
        {
            _shopService = shopService;
        }

        public IActionResult Index()
        {
            var model = _shopService.GetAll().ToList();
            return View(model);
        }
    }
}
