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

        public async Task<IActionResult> Index()
        {
            var model = await _saleMembershipManager.GetAllAsync();
            return View(model);
        }
    }
}
