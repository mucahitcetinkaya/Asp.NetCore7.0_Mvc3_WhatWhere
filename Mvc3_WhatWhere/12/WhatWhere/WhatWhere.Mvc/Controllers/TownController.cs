using Microsoft.AspNetCore.Mvc;

namespace WhatWhere.Mvc.Controllers
{
    public class TownController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
