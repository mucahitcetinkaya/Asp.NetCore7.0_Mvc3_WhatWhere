using Microsoft.AspNetCore.Mvc;
using WhatWhere.Data.Concrete.EfCore.Context;

namespace WhatWhere.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly WhatWhereContext _context;

        public CategoryController(WhatWhereContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Categories.ToList();
            return View(model);
        }
    }
}
