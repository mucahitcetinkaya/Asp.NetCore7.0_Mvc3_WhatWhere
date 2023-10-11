using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class BossController : Controller
    {
        private readonly IBossService _bossManager;

        public BossController(IBossService bossService)
        {
            _bossManager = bossService;
        }

        public async Task<IActionResult> Index()
        {
            List<Boss> bossList = await _bossManager.GetAllAsync();

            List<BossViewModel> bossViewModelList = bossList.Select(b => new BossViewModel
            {
                Id = b.Id,
                BossFullName = b.FirstName + " " + b.LastName,
                PhoneNumber = b.PhoneNumber,
                MailAdress = b.MailAdress,
                Gender = b.Gender,
                BirthOfYear = b.BirthOfYear,
                Url = b.Url,
            }).ToList();
            return View(bossViewModelList);

        }
    }
}

