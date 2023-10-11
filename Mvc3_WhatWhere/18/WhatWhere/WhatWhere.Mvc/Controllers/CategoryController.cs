using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryManager)
        {
            _categoryService = categoryManager;
        }

        public IActionResult Index()
        {
            var model = _categoryService.GetAll().ToList();
            return View(model);
        }
    }
}
