using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WhatWhere.Mvc.Models
{
    public class ResetPasswordViewModel
    {
        public string UserId { get; set; }
        public string Token { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage ="Lütfen boş bırakmayınız")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrar")]
        [Required(ErrorMessage = "Lütfen boş bırakmayınız")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler eşleşmedi")]
        public string RePassword { get; set; }
    }
}
