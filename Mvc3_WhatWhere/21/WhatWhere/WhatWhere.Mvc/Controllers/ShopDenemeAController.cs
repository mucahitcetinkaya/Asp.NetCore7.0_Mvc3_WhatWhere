using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class ShopDenemeAController : Controller
    {
        private readonly IShopService _shopManager;

        public ShopDenemeAController(IShopService shopService)
        {
            _shopManager = shopService;
        }

        public async Task<IActionResult> Index()
        {
            List<Shop> shopList = await _shopManager.GetShopFullDataAsync();
            List<ShopViewModel> shopViewModelList = shopList.Select(s => new ShopViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                PhoneNumber = s.PhoneNumber,
            }).ToList();
            return View(shopViewModelList);
        }
    }
}

