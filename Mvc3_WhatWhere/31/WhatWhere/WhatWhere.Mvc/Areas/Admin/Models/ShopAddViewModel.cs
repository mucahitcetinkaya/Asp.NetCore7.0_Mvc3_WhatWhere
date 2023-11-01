using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace WhatWhere.Mvc.Areas.Admin.Models
{
    public class ShopAddViewModel
    {

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

        //public int BossId { get; set; }

        public int CategoryId { get; set; }

        public int CityId { get; set; }

        public int TownId { get; set; }

        [DisplayName("Kategoriler")]
        public List<SelectListItem>? CategoryList { get; set; }
        [DisplayName("Şehirler")]
        public List<SelectListItem>? CityList { get; set; } 
        [DisplayName("İlçeler")]
        public List<SelectListItem>? TownList { get; set; }


        //[DisplayName("Ad")]
        //[Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        //[MinLength(2, ErrorMessage = "{0} alanının uzunluğu {1} karakterden az olmamalalıdır.")]
        //[MaxLength(100, ErrorMessage = "{0} alanının uzunluğu {1} karakterden fazla olmamalıdır.")]
        //public string Name { get; set; }

        //[DisplayName("Telefon Numarası")]
        //[Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        //[RegularExpression("^[1-9][0-9]{9}$", ErrorMessage = "{0} geçerli bir telefon numarası değil. Telefon numarası 10 haneli olmalı ve sıfır ile başlamamalıdır.")]
        //public string PhoneNumber { get; set; }

        //[DisplayName("Açıklama")]
        //[Required(ErrorMessage = "{0} alanı boş bırakılmamalıdır.")]
        //[MinLength(5, ErrorMessage = "{0} alanının uzunluğu {1} karakterden az olmamalalıdır.")]
        //[MaxLength(1000, ErrorMessage = "{0} alanının uzunluğu {1} karakterden fazla olmamalıdır.")]
        //public string Description { get; set; }


        //[DisplayName("Adres")]
        //public string Address { get; set; }

        //public string MailAdress { get; set; }

        //[DisplayName("Site")]
        //public string? Url { get; set; }

        //[DisplayName("Resim")]
        //public IFormFile ImageFile { get; set; }
        //public string ImageUrl { get; set; }
        //public bool IsHome { get; set; } = true;

        //[DisplayName("Aktif mi?")]
        //public bool IsActive { get; set; } = true;

        //[DisplayName("Silinmiş mi?")]
        //public bool IsDeleted { get; set; } = false;

        //public DateTime CreatedDate { get; set; } = DateTime.Now;
        //public DateTime ModifiedDate { get; set; } = DateTime.Now;

        //public int BossId { get; set; }
        //public Boss Boss { get; set; }

        //public int CategoryId { get; set; }

        //[DisplayName("Kategori")]
        //public Category Category { get; set; }

        //public int CityId { get; set; }
        //public City City { get; set; }

        //public int TownId { get; set; }
        //public Town Town { get; set; }

        //public List<SelectListItem> CategoryList { get; set; }
        //public List<SelectListItem> CityList { get; set; }
        //public List<SelectListItem> TownList { get; set; }

    }
}