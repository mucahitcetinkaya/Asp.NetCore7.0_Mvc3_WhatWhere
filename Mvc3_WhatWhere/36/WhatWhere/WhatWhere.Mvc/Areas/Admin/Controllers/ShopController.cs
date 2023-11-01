using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Business.Abstract;
using WhatWhere.Core;
using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Areas.Admin.Models;

namespace WhatWhere.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ShopController : Controller
    {
        private readonly IShopService _shopManager;
        private readonly ICategoryService _categoryManager;
        private readonly ICityService _cityManager;
        private readonly ITownService _townManager;
        private readonly INotyfService _notyf;

        public ShopController(IShopService shopManager, ICategoryService categoryManager, ICityService cityManager, ITownService townManager, INotyfService notyf)
        {
            _shopManager = shopManager;
            _categoryManager = categoryManager;
            _cityManager = cityManager;
            _townManager = townManager;
            _notyf = notyf;
        }

        #region Listeleme

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Shop> shopList = await _shopManager.GetAllShopsWithCityTownCategoryAsync(false);
            List<ShopViewModel> shopViewModelList = shopList.Select(s => new ShopViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                PhoneNumber = s.PhoneNumber,
                IsActive = s.IsActive,
                ImageUrl = s.ImageUrl,
                Url = s.Url,
                Category = s.Category,
                City = s.City,
                Town = s.Town,
            }).ToList();
            ShopListViewModel model = new ShopListViewModel
            {
                ShopViewModels = shopViewModelList,
                SourceAction = "Index"
            };
            return View(model);
        }

        #endregion

        #region Yardımcı Metotlar (Action Olmayanlar)

        [NonAction]
        private async Task<List<SelectListItem>> GetCategorySelectList()
        {
            List<Category> categoryList = await _categoryManager.GetAllCategoriesAsync(false, true);
            List<SelectListItem> categoryViewModelList = categoryList.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
            return categoryViewModelList;
        }

        [NonAction]
        private async Task<List<SelectListItem>> GetCitySelectList()
        {
            List<City> cityList = await _cityManager.GetAllAsync();
            List<SelectListItem> cityViewModelList = cityList.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Sehir
            }).ToList();
            return cityViewModelList;
        }

        [NonAction]
        private async Task<List<SelectListItem>> GetTownSelectList()
        {
            List<Town> townList = await _townManager.GetAllAsync();
            List<SelectListItem> townViewModelList = townList.Select(t => new SelectListItem
            {
                Value = t.Id.ToString(),
                Text = t.Ilce
            }).ToList();
            return townViewModelList;
        }

        #endregion

        #region Yeni Dükkan

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categoryViewModelList = await GetCategorySelectList();
            var cityViewModelList = await GetCitySelectList();
            var townViewModelList = await GetTownSelectList();
            ShopAddViewModel shopAddViewModel = new ShopAddViewModel
            {
                CategoryList = categoryViewModelList,
                CityList = cityViewModelList,
                TownList = townViewModelList,
            };

            return View(shopAddViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ShopAddViewModel shopAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var photo = Jobs.GetUrl(shopAddViewModel.Name) + ".jpg";
                var shop = new Shop
                {
                    Name = shopAddViewModel.Name,
                    PhoneNumber = shopAddViewModel.PhoneNumber,
                    Address = shopAddViewModel.Address,
                    Description = shopAddViewModel.Description,
                    Url = shopAddViewModel.Url,
                    MailAdress = shopAddViewModel.MailAdress,
                    ImageUrl = Jobs.UploadImage(shopAddViewModel.ImageFile, photo, "shop"),
                    CategoryId = shopAddViewModel.CategoryId,
                    CityId = shopAddViewModel.CityId,
                    TownId = shopAddViewModel.TownId,
                    IsActive = shopAddViewModel.IsActive,
                };
                await _shopManager.CreateAsync(shop);
                _notyf.Success("Dükkan kaydı başarıyla tamamlanmıştır.");
                return RedirectToAction("Index");
            }

            var categoryViewModelList = await GetCategorySelectList();
            var cityViewModelList = await GetCitySelectList();
            var townViewModelList = await GetTownSelectList();

            shopAddViewModel.CategoryList = categoryViewModelList;
            shopAddViewModel.CityList = cityViewModelList;
            shopAddViewModel.TownList = townViewModelList;

            return View(shopAddViewModel);
        }

        #endregion


        #region CreateAction City Town ayarları

        [HttpGet]
        public async Task<IActionResult> GetTownsByCity(int cityId)
        {
            var towns = await _townManager.GetTownListWithCityIdAsync(cityId); // Yukarıda belirttiğiniz metodu kullanarak ilçeleri çekin
            var townList = towns.Select(town => new { id = town.Id, ilce = town.Ilce });
            return Json(townList);
        }
        #endregion


        #region Shop Güncelleme
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Shop shop = await _shopManager.GetByIdAsync(id);
            if (shop == null)
            {
                _notyf.Warning("Sadece aktif ve silinmemiş dükkanlar düzenlenebilir.");
                return RedirectToAction("Index");
            }
            ShopEditViewModel shopEditViewModel = new ShopEditViewModel
            {
                Id = shop.Id,
                Name = shop.Name,
                PhoneNumber = shop.PhoneNumber,
                Address = shop.Address,
                Description = shop.Description,
                Url = shop.Url,
                MailAdress = shop.MailAdress,
                ImageUrl = shop.ImageUrl,
                CategoryId = shop.CategoryId,
                CityId = shop.CityId,
                TownId = shop.TownId,
                IsActive = shop.IsActive,
                IsDeleted = shop.IsDeleted,
                CategoryList = await GetCategorySelectList(),
                CityList = await GetCitySelectList(),
                TownList = await GetTownSelectList(),

            };
            return View(shopEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ShopEditViewModel shopEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Shop shop = new Shop();
                var photo = Jobs.GetUrl(shopEditViewModel.Name) + ".jpg";
                shop.Id = shopEditViewModel.Id;
                shop.Name = shopEditViewModel.Name;
                shop.PhoneNumber = shopEditViewModel.PhoneNumber;
                shop.Address = shopEditViewModel.Address;
                shop.Description = shopEditViewModel.Description;
                shop.Url = shopEditViewModel.Url;
                shop.MailAdress = shopEditViewModel.MailAdress;
                shop.ImageUrl = shopEditViewModel.ImageUrl == null ? shopEditViewModel.ImageUrl : Jobs.UploadImage(shopEditViewModel.ImageFile, photo, "shop");
                shop.CategoryId = shopEditViewModel.CategoryId;
                shop.CityId = shopEditViewModel.CityId;
                shop.TownId = shopEditViewModel.TownId;
                shop.IsActive = shopEditViewModel.IsActive;
                shop.IsDeleted = shopEditViewModel.IsDeleted;
                shop.ModifiedDate = DateTime.Now;
                _shopManager.Update(shop);
                _notyf.Success("Dükkan başarıyla güncellenmiştir.", 2);
                return RedirectToAction("Index");
            }

            var categoryViewModelList = await GetCategorySelectList();
            var cityViewModelList = await GetCitySelectList();
            var townViewModelList = await GetTownSelectList();

            shopEditViewModel.CategoryList = categoryViewModelList;
            shopEditViewModel.CityList = cityViewModelList;
            shopEditViewModel.TownList = townViewModelList;

            return View(shopEditViewModel);
        }
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
            string isActive = shop.IsActive ? "Aktif" : "Pasif";
            _notyf.Success($"Dükkan başarıyla {isActive} duruma getirilmiştir.");
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
                Url = shop.Url,
                MailAdress = shop.MailAdress,
                IsActive = shop.IsActive,
                IsDeleted = shop.IsDeleted,
            };
            return View(shopDeleteViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            Shop shop = await _shopManager.GetByIdAsync(id);
            if (shop == null) return NotFound();
            _shopManager.Delete(shop);
            _notyf.Error("Dükkan başarıyla silinmiştir.", 2);
            return RedirectToAction("Index");
        }
        #endregion

        #region Shop Soft Silme

        public async Task<IActionResult> SoftDelete(int id)
        {
            Shop shop = await _shopManager.GetByIdAsync(id);
            if (shop == null)
            {
                return NotFound();
            }
            shop.IsDeleted = !shop.IsDeleted;
            shop.ModifiedDate = DateTime.Now;
            _shopManager.Update(shop);
            string message = shop.IsDeleted ? "Kayıt silinmiştir. Geri almak için ilgili bölüme geçiniz." : "Kayıt geri alınmıştır.";
            _notyf.Success(message);
            return shop.IsDeleted ? RedirectToAction("Index") : RedirectToAction("DeletedIndex");
        }

        #endregion

        #region Geri Dönüşüm Kutusu

        public async Task<IActionResult> DeletedIndex()
        {
            List<Shop> shopList = await _shopManager.GetAllShopsWithCityTownCategoryAsync(true);
            List<ShopViewModel> shopViewModelList = shopList
                .Select(s => new ShopViewModel
                {
                    Id = s.Id,
                    Name = s.Name,
                    CreatedDate = s.CreatedDate,
                    ModifiedDate = s.ModifiedDate,
                    IsActive = s.IsActive,
                }).ToList();
            ShopListViewModel model = new ShopListViewModel
            {
                ShopViewModels = shopViewModelList,
                SourceAction = "DeletedIndex"
            };
            return View("DeletedPage", model);
        }

        #endregion


    }
}