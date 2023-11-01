using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShopService _shopManager;

        public HomeController(IShopService shopManager)
        {
            _shopManager = shopManager;
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
                ImageUrl = s.ImageUrl,
            }).ToList();
            return View(shopViewModelList);
        }
    }
}