using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;

        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            var model = _categoryManager.GetAll().ToList();
            return View(model);
        }


    }
}
