//using Microsoft.AspNetCore.Mvc;
//using WhatWhere.Business.Abstract;
//using WhatWhere.Entity.Concrete;
//using WhatWhere.Mvc.Models;

//namespace WhatWhere.Mvc.ViewComponents
//{
//    public class OptionsViewComponent : ViewComponent
//    {
//        private readonly ICategoryService _categoryManager;

//        public OptionsViewComponent(ICategoryService categoryManager)
//        {
//            _categoryManager = categoryManager;
//        }

//        public async Task<IViewComponentResult> InvokeAsync()
//        {
//            CategoryListViewModel categoryListViewModel = new CategoryListViewModel();
//            if (RouteData.Values["categoryname"] != null)
//            {
//                categoryListViewModel.SelectedCategoryName = RouteData.Values["categoryname"].ToString();
//            }
//            else
//            {
//                categoryListViewModel.SelectedCategoryName = "";
//            }

//            List<Category> categories = await _categoryManager.GetAllAsync();
//            List<CategoryViewModel> categoryViewModelList = categories
//                .Select(c => new CategoryViewModel
//                {
//                    Id = c.Id,
//                    Name = c.Name,
//                    Description = c.Description,
//                    ImageUrl = c.ImageUrl
//                }).ToList();

//            categoryListViewModel.CategoryViewModels = categoryViewModelList;

//            return View(categoryListViewModel);
//        }
//    }
//}
