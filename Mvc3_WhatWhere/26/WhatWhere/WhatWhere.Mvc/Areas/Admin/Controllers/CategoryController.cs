using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Areas.Admin.Models;

namespace WhatWhere.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;

        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }


        #region Listeleme
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<Category> categoryList = await _categoryManager.GetAllAsync();
            List<CategoryViewModel> categoryViewModelList = categoryList.Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                IsActive = c.IsActive,
                ImageUrl = c.ImageUrl
            }).ToList();
            return View(categoryViewModelList);
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
                    IsActive = categoryAddViewModel.IsActive,
                };
                await _categoryManager.CreateAsync(category);
                return RedirectToAction("Index");
            }
            return View();
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
                _categoryManager.Update(category);
                return RedirectToAction("Index");
            }
            return View();
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
                ImageUrl = category.ImageUrl,
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
            return RedirectToAction("Index");
        }
        #endregion

        #region Kategori GeriDönüşüm Silme
        public async Task<IActionResult> SoftDelete(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsDeleted = true;
            category.ModifiedDate = DateTime.Now;
            _categoryManager.Update(category);
            return RedirectToAction("Index");
        }
        #endregion

    }
}
