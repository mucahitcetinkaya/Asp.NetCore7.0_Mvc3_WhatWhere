using Microsoft.AspNetCore.Mvc;
using WhatWhere.Mvc.Context;

namespace WhatWhere.Mvc.Controllers
{
    public class BossController : Controller
    {
        private readonly WhatWhereContext _context;

        public BossController(WhatWhereContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Bosses.ToList();
            return View(model);
        }
    }
}

