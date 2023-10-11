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

        //public IActionResult Index()
        //{
        //    var model = _townManager.GetAll().ToList();
        //    return View(model);
        //}

        public IActionResult Index()
        {
            var model = _townManager.GetAllIncludingCity();
            return View(model);
        }
    }
}
