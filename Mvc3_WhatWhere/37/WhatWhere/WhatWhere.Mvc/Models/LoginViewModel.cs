using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WhatWhere.Mvc.Models
{
    public class LoginViewModel
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adı boş bırakılmamalıdır.")]
        public string UserName { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage ="Şifre boş bırakılmamalıdır")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Beni hatırla")]
        public bool IsPersistent { get; set; }
        public string ReturnUrl { get; set; }
    }
}
