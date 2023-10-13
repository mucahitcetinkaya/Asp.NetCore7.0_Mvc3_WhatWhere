using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Models
{
    public class CategoryListViewModel
    {
        public List<CategoryViewModel> CategoryViewModelList { get; set; }
        public string SelectedCategoryName { get; set; }
        
    }
}
