using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

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

        //public async Task<IActionResult> ShopDetails(int id)
        //{
        //    Shop shopDetails = await _shopManager.GetByIdAsync(id);
        //    List<ShopViewModel> shopViewModeList = shopDetails.Select(s => new ShopViewModel
        //    {
        //        Id = shop.Id,
        //        Name = shop.Name,
        //        Description = shop.Description,
        //        Address = shop.Address,
        //        PhoneNumber = shop.PhoneNumber,
        //        MailAdress = shop.MailAdress,
        //        Url = shop.Url,
        //        ImageUrl = shop.ImageUrl,
        //        IsActive = shop.IsActive,
        //        IsHome = shop.IsHome,
        //        IsDeleted = shop.IsDeleted,
        //    };
        //    return View(shopViewModel);
        //}
    }
}

               