using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WhatWhere.Mvc.Models;

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