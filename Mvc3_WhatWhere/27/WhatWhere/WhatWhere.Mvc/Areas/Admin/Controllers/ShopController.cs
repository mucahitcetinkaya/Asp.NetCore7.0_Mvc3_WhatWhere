using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Business.Concrete;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Areas.Admin.Models;

namespace WhatWhere.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShopController : Controller
    {
        private readonly IShopService _shopManager;

        public ShopController(IShopService shopManager)
        {
            _shopManager = shopManager;
        }

        #region Listeleme
        public async Task<IActionResult> Index()
        {
            List<Shop> shopList = await _shopManager.GetAllAsync();
            List<ShopViewModel> shopViewModelList = shopList.Select(s => new ShopViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                PhoneNumber = s.PhoneNumber,
                Description = s.Description,
                Url = s.Url,
                MailAdress = s.MailAdress,
                IsActive = s.IsActive,
                IsDeleted = s.IsDeleted,
                IsHome = s.IsHome,
            }).ToList();
            return View(shopViewModelList);
        }
        #endregion

        #region Yeni Dükkan
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ShopAddViewModel shopAddViewModel)
        {
            if (ModelState.IsValid)
            {
                Shop shop = new Shop
                {
                    Name = shopAddViewModel.Name,
                    PhoneNumber = shopAddViewModel.PhoneNumber,
                    Address = shopAddViewModel.Address,
                    IsActive = shopAddViewModel.IsActive,
                };
                await _shopManager.CreateAsync(shop);
                return RedirectToAction("Index");
            }
            return View();
        }
        #endregion

        #region Shop Güncelleme
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Shop shop = await _shopManager.GetByIdAsync(id);
            if (shop == null)
            {
                return NotFound();
            }
            ShopEditViewModel shopEditViewModel = new ShopEditViewModel
            {
                Id = shop.Id,
                Name = shop.Name,
                IsActive = shop.IsActive,
                IsDeleted = shop.IsDeleted,
                Address = shop.Address,
                PhoneNumber = shop.PhoneNumber
            };
            return View(shopEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ShopEditViewModel shopEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Shop shop = await _shopManager.GetByIdAsync(shopEditViewModel.Id);
                shop.Name = shopEditViewModel.Name;
                shop.IsActive = shopEditViewModel.IsActive;
                shop.IsDeleted = shopEditViewModel.IsDeleted;
                shop.Address = shopEditViewModel.Address;
                shop.PhoneNumber = shopEditViewModel.PhoneNumber;
                _shopManager.Update(shop);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            Shop shop = await _shopManager.GetByIdAsync(id);
            if (shop == null)
            {
                return NotFound();
            }
            shop.IsActive = !shop.IsActive;
            shop.ModifiedDate = DateTime.Now;
            _shopManager.Update(shop);
            return RedirectToAction("Index");
        }
        #endregion

        #region Shop Kalıcı Silme
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Shop shop = await _shopManager.GetByIdAsync(id);
            if (shop == null) return NotFound();
            ShopDeleteViewModel shopDeleteViewModel = new ShopDeleteViewModel
            {
                Id = shop.Id,
                Name = shop.Name,
                PhoneNumber = shop.PhoneNumber,
                Address = shop.Address,
                Description = shop.Description,
                ImageUrl = shop.ImageUrl,
                IsActive = shop.IsActive,
                IsDeleted = shop.IsDeleted,
                CreatedDate = shop.CreatedDate,
                ModifiedDate = shop.ModifiedDate
            };
            return View(shopDeleteViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            Shop shop = await _shopManager.GetByIdAsync(id);
            if (shop == null) return NotFound();
            _shopManager.Delete(shop);
            return RedirectToAction("Index");
        }
        #endregion

        #region Kategori GeriDönüşüm Silme
        public async Task<IActionResult> SoftDelete(int id)
        {
            Shop shop = await _shopManager.GetByIdAsync(id);
            if (shop == null)
            {
                return NotFound();
            }
            shop.IsDeleted = true;
            shop.ModifiedDate = DateTime.Now;
            _shopManager.Update(shop);
            return RedirectToAction("Index");
        }
        #endregion


    }
}
