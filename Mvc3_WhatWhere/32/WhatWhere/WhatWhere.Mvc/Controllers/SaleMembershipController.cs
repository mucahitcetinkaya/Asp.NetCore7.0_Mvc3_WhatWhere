using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Mvc.Models;

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
            List<SaleMembershipViewModel> saleMembershipViewModels = model.Select(sm => new SaleMembershipViewModel
            {
                Id = sm.Id,
                Name = sm.Name,
                Description = sm.Description,
                Price = sm.Price,
                ImageUrl = sm.ImageUrl,
            }).ToList();
            return View(saleMembershipViewModels);
        }
    }
}
