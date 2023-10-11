using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.Controllers
{
    public class SaleMembershipController : Controller
    {
        private readonly ISaleMembershipService _saleMembershipManager;

        public SaleMembershipController(ISaleMembershipService saleMembershipManager)
        {
            _saleMembershipManager = saleMembershipManager;
        }

        public IActionResult Index()
        {
            var model = _saleMembershipManager.GetAll();
            return View(model);
        }
    }
}
