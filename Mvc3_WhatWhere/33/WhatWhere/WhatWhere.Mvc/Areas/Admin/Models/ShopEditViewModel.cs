using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace WhatWhere.Mvc.Areas.Admin.Models
{
    public class ShopEditViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Description { get; set; }
        public string? Address { get; set; }
        public string? MailAdress { get; set; }
        public string? Url { get; set; }
        public string? ImageUrl { get; set; } = "default.jpg";
        [DisplayName("Resim Yükle")]
        public IFormFile? ImageFile { get; set; }

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        //public int BossId { get; set; }

        public int? CategoryId { get; set; }

        public int? CityId { get; set; }

        public int? TownId { get; set; }

        [DisplayName("Kategoriler")]
        public List<SelectListItem> CategoryList { get; set; }
        [DisplayName("Şehirler")]
        public List<SelectListItem> CityList { get; set; }
        [DisplayName("İlçeler")]
        public List<SelectListItem> TownList { get; set; }

    }
}
