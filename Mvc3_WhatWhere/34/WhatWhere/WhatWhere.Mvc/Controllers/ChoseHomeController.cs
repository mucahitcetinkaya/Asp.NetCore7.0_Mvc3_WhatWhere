using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class ChoseHomeController : Controller
    {
        private readonly IShopService _shopManager;

        public ChoseHomeController(IShopService shopManager)
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
