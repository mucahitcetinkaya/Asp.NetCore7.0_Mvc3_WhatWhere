using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    CategoryListViewModel categoryListViewModel = new CategoryListViewModel();
        //    if (RouteData.Values["categoryurl"] != null)
        //    {
        //        categoryListViewModel.SelectedCategoryUrl = RouteData.Values["categoryurl"].ToString();
        //    }
        //    else
        //    {
        //        categoryListViewModel.SelectedCategoryUrl = "";
        //    }

        //    List<Category> categories = await _categoryManager.GetAllAsync();
        //    List<CategoryViewModel> categoryViewModelList = categories
        //        .Select(c => new CategoryViewModel
        //        {
        //            Name = c.Name,
        //            Description = c.Description,
        //            ImageUrl = c.ImageUrl
        //        }).ToList();

        //    categoryListViewModel.CategoryViewModelList = categoryViewModelList;

        //    return View(categoryListViewModel);
        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> categoryList = await _categoryManager.GetAllAsync();

            List<CategoryViewModel> categoryViewModelList = categoryList.Select(c => new CategoryViewModel
            {
                Name = c.Name,
                Description = c.Description,
                ImageUrl = c.ImageUrl,
            }).ToList();
            return View(categoryViewModelList);
        }
    }
}
