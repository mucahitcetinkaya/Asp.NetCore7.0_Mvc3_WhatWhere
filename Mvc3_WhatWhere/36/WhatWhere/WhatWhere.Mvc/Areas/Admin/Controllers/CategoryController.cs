using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Core;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Areas.Admin.Models;

namespace WhatWhere.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;
        private readonly IShopService _shopManager;
        private readonly INotyfService _notyf;

        public CategoryController(ICategoryService categoryManager, INotyfService notyf, IShopService shopManager)
        {
            _categoryManager = categoryManager;
            _notyf = notyf;
            _shopManager = shopManager;
        }


        #region Listeleme
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Category> categoryList = await _categoryManager.GetAllCategoriesAsync(false);
            List<CategoryViewModel> categoryViewModelList = categoryList.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                IsActive = c.IsActive,
                ImageUrl = c.ImageUrl
            }).ToList();
            CategoryListViewModel model = new CategoryListViewModel
            {
                CategoryViewModels = categoryViewModelList,
                SourceAction = "Index"
            };
            return View(model);
        }
        #endregion

        #region Yeni Kategori
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddViewModel categoryAddViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    Name = categoryAddViewModel.Name,
                    Description = categoryAddViewModel.Description,
                    ImageUrl = Jobs.GetUrl(categoryAddViewModel.Name) + ".jpg",
                    IsActive = categoryAddViewModel.IsActive,
                };
                await _categoryManager.CreateAsync(category);
                _notyf.Success("Kategori kaydı başarıyla tamamlanmıştır.");
                return RedirectToAction("Index");
            }
            return View(categoryAddViewModel);
        }
        #endregion

        #region Kategori Güncelleme
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            CategoryEditViewModel categoryEditViewModel = new CategoryEditViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                IsActive = category.IsActive,
                IsDeleted = category.IsDeleted
            };
            return View(categoryEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(CategoryEditViewModel categoryEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = await _categoryManager.GetByIdAsync(categoryEditViewModel.Id);
                category.Name = categoryEditViewModel.Name;
                category.Description = categoryEditViewModel.Description;
                category.IsActive = categoryEditViewModel.IsActive;
                category.IsDeleted = categoryEditViewModel.IsDeleted;
                category.ImageUrl = Jobs.GetUrl(categoryEditViewModel.Name) + ".jpg";
                category.ModifiedDate = DateTime.Now;
                _categoryManager.Update(category);
                _notyf.Success("Kategori başarıyla güncellenmiştir.", 2);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsActive = !category.IsActive;
            category.ModifiedDate = DateTime.Now;
            _categoryManager.Update(category);
            string isActive = category.IsActive ? "Aktif" : "Pasif";
            _notyf.Success($"Kategori başarıyla {isActive} duruma getirilmiştir.");
            return RedirectToAction("Index");
        }
        #endregion

        #region Kategori Kalıcı Silme
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null) return NotFound();
            CategoryDeleteViewModel categoryDeleteViewModel = new CategoryDeleteViewModel
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                ImageUrl = category.Name + ".jpg",
                IsActive = category.IsActive,
                IsDeleted = category.IsDeleted,
                CreatedDate = category.CreatedDate,
                ModifiedDate = category.ModifiedDate
            };
            return View(categoryDeleteViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null) return NotFound();
            _categoryManager.Delete(category);
            //await _shopManager.CheckShopsCategories();
            _notyf.Error("Kategori başarıyla silinmiştir.", 2);
            return RedirectToAction("Index");
        }
        #endregion

        #region Kategori Soft Silme
        public async Task<IActionResult> SoftDelete(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsDeleted = !category.IsDeleted;
            category.ModifiedDate = DateTime.Now;
            _categoryManager.Update(category);
            string message = category.IsDeleted ? "Kayıt silinmiştir. Geri almak için ilgili bölüme geçiniz." : "Kayıt geri alınmıştır.";
            _notyf.Success(message);
            return category.IsDeleted ? RedirectToAction("Index") : RedirectToAction("DeletedIndex");
        }
        #endregion

        #region Geri Dönüşüm Kutusu

        public async Task<IActionResult> DeletedIndex()
        {
            List<Category> categoryList = await _categoryManager.GetAllCategoriesAsync(true);
            List<CategoryViewModel> categoryViewModelList = categoryList
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    CreatedDate = c.CreatedDate,
                    ModifiedDate = c.ModifiedDate,
                    Description = c.Description,
                    IsActive = c.IsActive,
                }).ToList();
            CategoryListViewModel model = new CategoryListViewModel
            {
                CategoryViewModels = categoryViewModelList,
                SourceAction = "DeletedIndex"
            };
            return View("DeletedPage", model);
        }

        #endregion

    }
}
