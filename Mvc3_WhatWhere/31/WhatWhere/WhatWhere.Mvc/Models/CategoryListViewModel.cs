using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace WhatWhere.Mvc.Models
{
    public class CategoryListViewModel 
    {
        public List<CategoryViewModel>? CategoryViewModels { get; set; }
        public string? SelectedCategoryName { get; set; }
        public string? SelectedCityName { get; set; }
        public string? SelectedTownName { get; set; }

        [DisplayName("Kategoriler")]
        public List<SelectListItem>? CategoriesSelectList { get; set; }
        [DisplayName("Şehirler")]
        public List<SelectListItem>? CitiesSelectList { get; set; }
        [DisplayName("İlçeler")]
        public List<SelectListItem>? TownsSelectList { get; set; }

        public int? CategoryId { get; set; }
        public int? CityId { get; set; }
        public int? TownId { get; set; }
    }
}
