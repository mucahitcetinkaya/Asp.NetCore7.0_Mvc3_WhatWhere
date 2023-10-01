using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;
        private readonly IBossService _bossManager;
        private readonly IShopService _shopManager;

        public CategoryController(ICategoryService categoryManager, IBossService bossManager, IShopService shopManager)
        {
            _categoryManager = categoryManager;
            _bossManager = bossManager;
            _shopManager = shopManager;
        }

        public IActionResult Index()
        {
            List<Category> categories = _categoryManager.GetAll();
            return View(categories);
        }
    }
}
