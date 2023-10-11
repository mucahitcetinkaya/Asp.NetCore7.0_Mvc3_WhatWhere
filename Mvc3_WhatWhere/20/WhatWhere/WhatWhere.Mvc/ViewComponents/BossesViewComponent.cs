using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;

namespace WhatWhere.Mvc.ViewComponents
{
    public class BossesViewComponent : ViewComponent
    {
        private readonly IBossService _bossManager;

        public BossesViewComponent(IBossService bossManager)
        {
            _bossManager = bossManager;
        }


    }
}
