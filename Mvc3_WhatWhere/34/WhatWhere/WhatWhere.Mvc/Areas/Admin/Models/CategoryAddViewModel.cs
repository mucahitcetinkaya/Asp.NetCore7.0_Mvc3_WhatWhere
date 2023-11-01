using System.ComponentModel.DataAnnotations;

namespace WhatWhere.Mvc.Areas.Admin.Models
{
    public class CategoryAddViewModel
    {
        [Required(ErrorMessage = "Ad alanı boş bırakılamalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş bırakılmamalıdır.")]
        public string Description { get; set; }
        public string ImageUrl { get; set; } = "default.jpg";

        public bool IsActive { get; set; }
    }
}