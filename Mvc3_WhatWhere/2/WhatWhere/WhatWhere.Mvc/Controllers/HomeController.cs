using Microsoft.AspNetCore.Mvc;

namespace WhatWhere.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}