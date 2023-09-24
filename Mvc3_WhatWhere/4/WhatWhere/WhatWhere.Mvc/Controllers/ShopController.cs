using Microsoft.AspNetCore.Mvc;
using WhatWhere.Mvc.Context;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class ShopController : Controller
    {
        private readonly WhatWhereContext _context;

        public ShopController(WhatWhereContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Shops.ToList();
            return View(model);
        }
    }
}
