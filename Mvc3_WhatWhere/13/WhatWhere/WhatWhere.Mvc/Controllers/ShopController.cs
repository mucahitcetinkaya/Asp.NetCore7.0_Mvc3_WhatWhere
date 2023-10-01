using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        public IActionResult Index(int townId, int categoryId)
        {
            townId = (int)TempData["townId"];
            var shops = _shopService.GetShopOfTown(townId, categoryId);
            return View(shops);
        }
    }
}
