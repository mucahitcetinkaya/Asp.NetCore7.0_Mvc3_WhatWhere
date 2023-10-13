using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _shopManager;

        public ShopController(IShopService shopManager)
        {
            _shopManager = shopManager;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _shopManager.GetShopFullDataAsync();
            return View(model);
        }
    }
}

               