using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class DenemeController : Controller
    {
        private readonly IBossService _bossManager;
        private readonly ICategoryService _categoryManager;
        private readonly ICityService _cityManager;
        private readonly ISaleMembershipService _saleMembershipManager;
        private readonly IShopService _shopManager;
        private readonly ITownService _townManager;

        public DenemeController(IBossService bossManager, ICategoryService categoryManager, ICityService cityManager, ISaleMembershipService saleMembershipManager, IShopService shopManager, ITownService townManager)
        {
            _bossManager = bossManager;
            _categoryManager = categoryManager;
            _cityManager = cityManager;
            _saleMembershipManager = saleMembershipManager;
            _shopManager = shopManager;
            _townManager = townManager;
        }



        // PATRON ALANI
        public async Task<IActionResult> GetByIdBoss(int id)
        {
            Boss model = await _bossManager.GetByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> GetAllBoss()
        {
            var model = await _bossManager.GetAllAsync();
            return View(model);
        }



        // CATEGORY ALANI
        public async Task<IActionResult> GetByIdCategory(int id)
        {
            var model = await _categoryManager.GetByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> GetAllCategory()
        {
            var model = await _categoryManager.GetAllAsync();
            return View(model);
        }



        // CIYT ALANI
        public async Task<IActionResult> GetByIdCity(int id)
        {
            var model = await _cityManager.GetByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> GetAllCity()
        {
            var model = await _cityManager.GetAllAsync();
            return View(model);
        }



        // SALEMEMBERSHIP ALANI
        public async Task<IActionResult> GetByIdSaleMembership(int id)
        {
            var model = await _saleMembershipManager.GetByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> GetAllSaleMembership()
        {
            var model = await _saleMembershipManager.GetAllAsync();
            return View(model);
        }



        // SHOP ALANI
        public async Task<IActionResult> GetByIdShop(int id)
        {
            var model = await _shopManager.GetByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> GetAllShop()
        {
            var model = await _shopManager.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> GetFullDataShop1()
        {
            var shops = await _shopManager.GetShopFullDataAsync();
            var model = shops.Select(s => new ShopViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Address = s.Address,
                PhoneNumber = s.PhoneNumber,
                MailAdress = s.MailAdress,
                Url = s.Url,
                IsActive = s.IsActive,
                ImageUrl = s.ImageUrl,
                IsHome = s.IsHome,
                BossId = (int)s.BossId,
                CategoryId = (int)s.CategoryId,
                CityId = (int)s.CityId,
                TownId = (int)s.TownId
            }).ToList();

            return View(model);
        }

        public async Task<IActionResult> GetFullDataShop2()
        {
            List<Shop> model = await _shopManager.GetShopFullDataAsync();
            return View(model);
        }



        // TOWN ALANI
        public async Task<IActionResult> GetByIdTown(int id)
        {
            var model = await _townManager.GetByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> GetAllTown()
        {
            var model = await _townManager.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> GetFullDataTown()
        {
            var model = await _townManager.GetTownFullDataAsync();
            return View(model);
        }

    }
}
