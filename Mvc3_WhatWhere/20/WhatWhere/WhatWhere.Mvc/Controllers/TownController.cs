using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class TownController : Controller
    {
        private readonly ITownService _townManager;

        public TownController(ITownService townManager)
        {
            _townManager = townManager;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _townManager.GetTownFullDataAsync();
            return View(model);
        }
    }
}
