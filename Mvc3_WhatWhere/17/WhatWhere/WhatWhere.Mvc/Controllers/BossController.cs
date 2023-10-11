using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;

namespace WhatWhere.Mvc.Controllers
{
    public class BossController : Controller
    {
        private readonly IBossService _bossService;

        public BossController(IBossService bossService)
        {
            _bossService = bossService;
        }

        public IActionResult Index()
        {
            var model = _bossService.GetAll().ToList();
            return View(model);
        }
    }
}

