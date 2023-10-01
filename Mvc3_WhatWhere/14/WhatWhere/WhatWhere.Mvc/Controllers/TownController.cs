using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class TownController : Controller
    {
        private readonly ITownService _townService;

        public TownController(ITownService townService)
        {
            _townService = townService;
        }

        public IActionResult Index()
        {
            var townList = _townService.GetAll().ToList();
            return View(townList);
        }
    }
}
