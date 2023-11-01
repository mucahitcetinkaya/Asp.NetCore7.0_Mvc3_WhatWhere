using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.ViewComponents
{
    public class ChoseViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryManager;
        private readonly ICityService _cityManager;
        private readonly ITownService _townManager;

        public ChoseViewComponent(ICategoryService categoryManager, ICityService cityManager, ITownService townManager)
        {
            _categoryManager = categoryManager;
            _cityManager = cityManager;
            _townManager = townManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel();
            if (RouteData.Values["categoryname"] != null)
            {
                categoryListViewModel.SelectedCategoryName = RouteData.Values["categoryname"].ToString();
            }
            else
            {
                categoryListViewModel.SelectedCategoryName = "";
            }

            List<Category> categories = await _categoryManager.GetAllAsync();
            List<CategoryViewModel> categoryViewModelList = categories
                .Select(c => new CategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    ImageUrl = c.ImageUrl
                }).ToList();


            //Kategorileri SelectListItem listesine dönüştürme
            List<SelectListItem> categorySelectList = categories
                .Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(), // Burada kategori ID'sini değeri olarak ayarlayabilirsiniz
                    Text = c.Name // Kategori adını metin olarak ayarlayın
                }).ToList();

            categoryListViewModel.CategoryViewModels = categoryViewModelList;
            categoryListViewModel.CategoriesSelectList = categorySelectList;

            return View(categoryListViewModel);
        }




        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    CategoryListViewModel choseViewModel = new CategoryListViewModel();
        //    if (RouteData.Values["categoryname"] != null)
        //    {
        //        choseViewModel.SelectedCategoryName = RouteData.Values["categoryname"].ToString();
        //    }
        //    else
        //    {
        //        choseViewModel.SelectedCategoryName = "";
        //    }

        //    if (RouteData.Values["cityname"] != null)
        //    {
        //        choseViewModel.SelectedCityName = RouteData.Values["cityname"].ToString();
        //    }
        //    else
        //    {
        //        choseViewModel.SelectedCityName = "";
        //    }

        //    if (RouteData.Values["townname"] != null)
        //    {
        //        choseViewModel.SelectedTownName = RouteData.Values["townname"].ToString();
        //    }
        //    else
        //    {
        //        choseViewModel.SelectedTownName = "";
        //    }

        //    List<Category> categories = await _categoryManager.GetAllAsync();
        //    List<City> cities = await _cityManager.GetAllAsync();
        //    List<Town> towns = await _townManager.GetAllAsync();

        //    //Kategorileri SelectListItem listesine dönüştürme
        //    List<SelectListItem> categorySelectList = categories
        //        .Select(c => new SelectListItem
        //        {
        //            Value = c.Id.ToString(), // Burada kategori ID'sini değeri olarak ayarlayabilirsiniz
        //            Text = c.Name // Kategori adını metin olarak ayarlayın
        //        }).ToList();

        //    // Kategorileri SelectListItem listesine dönüştürme
        //    List<SelectListItem> citySelectList = cities
        //        .Select(c => new SelectListItem
        //        {
        //            Value = c.Id.ToString(), // Burada kategori ID'sini değeri olarak ayarlayabilirsiniz
        //            Text = c.Sehir // Kategori adını metin olarak ayarlayın
        //        }).ToList();

        //    // Kategorileri SelectListItem listesine dönüştürme
        //    List<SelectListItem> townSelectList = towns
        //        .Select(t => new SelectListItem
        //        {
        //            Value = t.Id.ToString(), // Burada kategori ID'sini değeri olarak ayarlayabilirsiniz
        //            Text = t.Ilce // Kategori adını metin olarak ayarlayın
        //        }).ToList();

        //    //Dropdown listesini model ile doldurma
        //    choseViewModel.CategoriesSelectList = categorySelectList;
        //    choseViewModel.CitiesSelectList = citySelectList;
        //    choseViewModel.TownsSelectList = townSelectList;

        //    return View(choseViewModel);
        //}
    }
}
