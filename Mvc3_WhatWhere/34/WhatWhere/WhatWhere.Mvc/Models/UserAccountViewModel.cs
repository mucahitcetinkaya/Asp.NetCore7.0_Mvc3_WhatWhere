using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WhatWhere.Mvc.Models
{
    public class UserAccountViewModel
    {
        public string Id  { get; set; }

        [DisplayName("Ad")]
        [Required(ErrorMessage ="{0} alanı boş bırakılmamalı.")]
        public string FirstName { get; set; }

        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı.")]
        public string LastName { get; set; }

        [DisplayName("Cinsiyet")]
        public string Gender { get; set; }

        [DisplayName("Doğum Tarihi")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Adres")]
        public string Address { get; set; }

        [DisplayName("Şehir")]
        public string City { get; set; }

        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı.")]
        public string UserName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı.")]
        public string Email { get; set; }

        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }

        public List<SelectListItem> GenderSelectList { get; set; }
    }
}
