using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Areas.Admin.Models
{
    public class ShopViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        public string Url { get; set; }

        public string Description { get; set; }
        public string ImageUrl { get; set; } = "default.jpg";
        public string Address { get; set; }
        public bool IsHome { get; set; } = true;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;


        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;


        public int BossId { get; set; }
        public Boss Boss { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }

        public List<SelectListItem> Cities { get; set; }
        public List<SelectListItem> Towns { get; set; }

    }
}
