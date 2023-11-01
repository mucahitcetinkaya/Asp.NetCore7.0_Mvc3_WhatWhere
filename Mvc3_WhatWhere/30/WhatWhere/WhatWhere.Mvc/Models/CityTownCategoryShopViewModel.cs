using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Models
{
    public class CityTownCategoryShopViewModel
    {
        [DisplayName("Şehirler")]
        public List<SelectListItem>? CitiesSelectList { get; set; }
        [DisplayName("İlçeler")]
        public List<SelectListItem>? TownsSelectList { get; set; }
        [DisplayName("Kategoriler")]
        public List<SelectListItem>? CategoriesSelectList { get; set; }

        public int SelectedCityId { get; set; }
        public int SelectedTownId { get; set; }
        public int SelectedCategoryId { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }

        public string? PhoneNumber { get; set; }
        public string? MailAdress { get; set; }
        public string? Url { get; set; }

        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Address { get; set; }
        public bool IsHome { get; set; } = true;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;


        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;


        public int? BossId { get; set; }
        public Boss? Boss { get; set; }

        public List<ShopViewModel> Shops { get; set; }
        public List<Shop> ListShops { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        public int? CityId { get; set; }
        public City? City { get; set; }

        public int? TownId { get; set; }
        public Town? Town { get; set; }
    }
}
