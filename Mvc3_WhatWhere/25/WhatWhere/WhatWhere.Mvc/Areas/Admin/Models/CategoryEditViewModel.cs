using System.ComponentModel.DataAnnotations;

namespace WhatWhere.Mvc.Areas.Admin.Models
{
    public class CategoryEditViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı boş bırakılamalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş bırakılmamalıdır.")]
        public string Description { get; set; }

        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
