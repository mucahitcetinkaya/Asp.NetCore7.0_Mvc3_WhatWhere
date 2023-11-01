using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class ChoseCategoryController : Controller
    {
        private readonly IShopService _shopManager;

        public ChoseCategoryController(IShopService shopManager)
        {
            _shopManager = shopManager;
        }

        public async Task<IActionResult> Index(string categoryName = null)
        {
            List<Shop> shopList = await _shopManager.GetShopsByCategoryAsync(categoryName);
            List<ShopViewModel> shopViewModelList = shopList.Select(s => new ShopViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                PhoneNumber = s.PhoneNumber,
                ImageUrl = s.ImageUrl,
                City = s.City,
                Town = s.Town,
            }).ToList();
            return View(shopViewModelList);
        }
    }
}