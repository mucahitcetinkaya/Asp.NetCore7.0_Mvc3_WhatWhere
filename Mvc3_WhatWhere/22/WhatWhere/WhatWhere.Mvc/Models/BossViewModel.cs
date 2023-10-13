namespace WhatWhere.Mvc.Models
{
    public class BossViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BossFullName { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
        public string Gender { get; set; }
        public int BirthOfYear { get; set; }
        public string Url { get; set; }

    }
}

/*

namespace WhatWhere.Mvc.Controllers
{
    public class ShopDenemeAController : Controller
    {
        private readonly IShopService _shopManager;

        public ShopDenemeAController(IShopService shopService)
        {
            _shopManager = shopService;
        }

        public async Task<IActionResult> Index()
        {
            List<Shop> shopList = await _shopManager.GetShopFullDataAsync();
            List<ShopViewModel> shopViewModelList = shopList.Select(s => new ShopViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                PhoneNumber = s.PhoneNumber,
            }).ToList();
            return View(shopViewModelList);
        }
    }
}


public async Task<List<Shop>> GetShopFullDataAsync()
        {
            var result = await _context
                .Shops
                .Include(s => s.Boss)
                .Include(s => s.Category)
                .Include(s => s.City)
                .Include(s => s.Town)
                .ToListAsync();
            return result;
        }


shopdenemea ındex
@model List<ShopViewModel>

<div class="row">
    <div class="col-2">
        @await Component.InvokeAsync("Categories")
    </div>
    <div class="col-10">
        <div class="row g-3">
            @foreach (var shopViewModel in Model)
            {
                <div class="col-2">
                    @await Html.PartialAsync("_ShopPartial", shopViewModel)
                </div>
            }
        </div>
    </div>
</div>

shoppartial
@model ShopViewModel

<div class="card">
    <a href="#">
        <img src="~/images/shop/@Model.ImageUrl" class="card-img-top" />
    </a>
    <div class="card-body pb-0 d-flex flex-column justify-content-between" style="height:140px;">
        <div> 
            <h4 class="card-title">@Model.Name</h4>
            <h4 class="card-title">@Model.PhoneNumber</h4>
        </div>
        <div class="d-flex justify-content-between">
            <button href="#" class="btn btn-info btn-sm">İncele</button>
            <button class="btn btn-danger btn-sm" style="cursor:default !important";>@($"{Model.Name:C0}")</button>
        </div>
    </div>
    <div class="card-footer bg-white d-grid gap-2 mt-2">
        
        <button href="#" class="btn btn-success btn-sm">Sepete Ekle</button>
    </div>
</div>


namespace WhatWhere.Mvc.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
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

            categoryListViewModel.CategoryViewModelList = categoryViewModelList;

            return View(categoryListViewModel);
        }
    }
}

@model CategoryListViewModel
<div class="list-group">
    <a class="list-group-item list-group-item-action @(Model.SelectedCategoryName=="" ? "active" : "")"
       asp-area=""
       asp-controller="Shop"
       asp-action="ShopList"
       asp-route-categoryurl=""
       asp-route-authorurl="">Tüm Kategoriler</a>
    @foreach (var categoryViewModel in Model.CategoryViewModelList)
    {
        <a class="list-group-item list-group-item-action @(Model.SelectedCategoryName==categoryViewModel.Name ? "active" : "")"
           asp-area=""
           asp-controller="Shop"
           asp-action="ShopList"
           asp-route-categoryurl="@categoryViewModel.Name"
           asp-route-authorurl="">@categoryViewModel.Name</a>
    }
</div>


namespace WhatWhere.Mvc.Controllers
{
    public class ShopDenemeBController : Controller
    {
        private readonly IShopService _shopManager;
        private readonly ICategoryService _categoryManager;

        public ShopDenemeBController(IShopService shopManager, ICategoryService categoryManager)
        {
            _shopManager = shopManager;
            _categoryManager = categoryManager;
        }

        public async Task<IActionResult> Index(string categoryName = null)
        {
            List<Shop> shopList = await _shopManager.GetAllShopsByCategoryAsync(categoryName);
            List<ShopViewModel> shopViewModelList = shopList.Select(s => new ShopViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Address = s.Address,
                PhoneNumber = s.PhoneNumber,
            }).ToList();

            CategoryListViewModel categoryListViewModel = new CategoryListViewModel
            {
                CategoryViewModelList = await _categoryManager.GetAllAsync(),
                SelectedCategoryName = categoryName
            };

            ShopListViewModel shopListViewModel = new ShopListViewModel
            {
                ShopViewModelList = shopViewModelList,
                ShopCategoryListViewModel = categoryListViewModel
            };

            return View(shopListViewModel);
        }
    }
}

public async Task<List<Shop>> GetAllShopsByCategoryAsync(string categoryName = null)
        {
            var result = _context.Shops
                .Where(s => s.IsActive && !s.IsDeleted)
                .Include(s => s.Boss)
                .Include(s => s.Category)
                .Include(s => s.City)
                .Include(s => s.Town)
                .AsQueryable();

            if (!string.IsNullOrEmpty(categoryName))
            {
                result = result
                    .Where(s => s.Category.Name == categoryName)
                    .AsQueryable();
            }

            return await result.ToListAsync();
        }


shopdenemeb index
@model List<ShopViewModel>

<div class="row">
    <div class="col-2">
        @await Component.InvokeAsync("Categories")
    </div>
    <div class="col-10">
        <div class="row g-3">
            @foreach (var shopViewModel in Model)
            {
                <div class="col-2">
                    @await Html.PartialAsync("_ShopPartial", shopViewModel)
                </div>
            }
        </div>
    </div>
</div>


namespace WhatWhere.Mvc.Models
{
    public class ShopViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public bool IsHome { get; set; } = true;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public int BossId { get; set; }
        public Boss Boss { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int TownId { get; set; }
        public Town Town { get; set; }
    }
}

namespace WhatWhere.Mvc.Models
{
    public class ShopListViewModel
    {
        public List<ShopViewModel> ShopViewModelList { get; set; }
        public CategoryListViewModel ShopCategoryListViewModel { get; set; }
    }
}

namespace WhatWhere.Mvc.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Models
{
    public class CategoryListViewModel
    {
        public List<CategoryViewModel> CategoryViewModelList { get; set; }
        public string SelectedCategoryName { get; set; }
    }
}



*/

/*
 
namespace BooksApp.MVC.Controllers;

public class HomeController : Controller
{
    private readonly IBookService _bookManager;

    public HomeController(IBookService bookManager)
    {
        _bookManager = bookManager;
    }

    public async Task<IActionResult> Index()
    {
        List<Book> bookList = await _bookManager.GetHomePageBooksAsync();

        List<BookViewModel> bookViewModelList = bookList.Select(b => new BookViewModel
        {
            Id = b.Id,
            Name = b.Name,
            Price = b.Price,
            Url = b.Url,
            ImageUrl = b.ImageUrl,
            AuthorName = b.Author.FirstName + " " + b.Author.LastName,
            AuthorUrl = b.Author.Url,
            PublisherName = b.Publisher.Name,
            PublisherUrl = b.Publisher.Url
        }).ToList();
        return View(bookViewModelList);
    }

}

public async Task<List<Book>> GetHomePageBooksAsync()
        {
            var result = await _context
                .Books
                .Where(b => b.IsActive && !b.IsDeleted && b.IsHome)
                .Include(b => b.BookCategories)
                .ThenInclude(bc => bc.Category)
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .ToListAsync();
            return result;
        }

@model List<BookViewModel>
@{
    ViewData["Title"] = "BooksApp Ana Sayfa";
}
<div class="row">
    <div class="col-2">
        @await Component.InvokeAsync("Categories")
    </div>
    <div class="col-10">
        <div class="row g-3">
            @foreach (var bookViewModel in Model)
            {
                <div class="col-2">
                    @await Html.PartialAsync("_BookPartial",bookViewModel)
                </div>
            }
        </div>
    </div>
</div>

namespace BooksApp.MVC.Controllers
{
    public class BooksShopController : Controller
    {
        private readonly IBookService _bookManager;

        public BooksShopController(IBookService bookManager)
        {
            _bookManager = bookManager;
        }

        public async Task<IActionResult> BookList(string categoryurl=null, string authorurl=null, string publisherurl=null)
        {
            List<Book> bookList = await _bookManager.GetAllActiveBooksAsync(categoryurl, authorurl, publisherurl);
            List<BookViewModel> bookViewModelList = bookList.Select(b => new BookViewModel
            {
                Id = b.Id,
                Name = b.Name,
                Price = b.Price,
                Url = b.Url,
                ImageUrl = b.ImageUrl,
                AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                AuthorUrl = b.Author.Url,
                PublisherName = b.Publisher.Name,
                PublisherUrl = b.Publisher.Url
            }).ToList();
            return View(bookViewModelList);
        }
    }
}

public async Task<List<Book>> GetAllActiveBooksAsync(string categoryUrl = null, string authorUrl = null, string publisherUrl = null)
        {
            
            var result = _context
                .Books
                .Where(b => b.IsActive && !b.IsDeleted)
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .AsQueryable();
            if (categoryUrl!=null)
            {
                result = result
                    .Include(b => b.BookCategories)
                    .ThenInclude(bc => bc.Category)
                    .Where(b => b.BookCategories.Any(bc => bc.Category.Url == categoryUrl))
                    .AsQueryable();
            }
            if (authorUrl != null)
            {
                result = result
                    .Where(b => b.Author.Url == authorUrl)
                    .AsQueryable();
            }
            if (publisherUrl != null)
            {
                result = result
                    .Where(b => b.Publisher.Url == publisherUrl)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }

@model List<BookViewModel>
@{
    ViewData["Title"] = "BooksApp Ana Sayfa";
}
<div class="row">

    <div class="col-10">
        <div class="row g-3">
            @foreach (var bookViewModel in Model)
            {
                <div class="col-2">
                    @await Html.PartialAsync("_BookPartial",bookViewModel)
                </div>
            }
        </div>
    </div>
    <div class="col-2">
        @await Component.InvokeAsync("Categories")
    </div>
</div>


@model BookViewModel
<div class="card">
    <a href="#">
        <img src="~/images/books/@Model.ImageUrl" class="card-img-top" />
    </a>
    <div class="card-body pb-0 d-flex flex-column justify-content-between" style="height:140px;">
        <div> 
            <h4 class="card-title">@Model.Name</h4>
            <h5 class="card-text">@Model.AuthorName</h5>
            <h6 class="card-text">@Model.PublisherName</h6>
        </div>
        <div class="d-flex justify-content-between">
            <button href="#" class="btn btn-info btn-sm">İncele</button>
            <button class="btn btn-danger btn-sm" style="cursor:default !important";>@($"{Model.Price:C0}")</button>
        </div>
    </div>
    <div class="card-footer bg-white d-grid gap-2 mt-2">
        
        <button href="#" class="btn btn-success btn-sm">Sepete Ekle</button>
    </div>
</div>


namespace BooksApp.MVC.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            CategoryListViewModel categoryListViewModel = new CategoryListViewModel();
            if (RouteData.Values["categoryurl"] != null)
            {
                categoryListViewModel.SelectedCategoryUrl = RouteData.Values["categoryurl"].ToString();
            }
            else
            {
                categoryListViewModel.SelectedCategoryUrl = "";
            }

            List<Category> categories = await _categoryManager.GetAllAsync();
            List<CategoryViewModel> categoryViewModelList = categories
                .Select(c => new CategoryViewModel
                {
                    Name = c.Name,
                    Url = c.Url
                }).ToList();

            categoryListViewModel.CategoryViewModelList= categoryViewModelList;
            
            return View(categoryListViewModel);
        }
    }
}

CategoriesViewComponent default 
@model CategoryListViewModel
<div class="list-group">
    <a
        class="list-group-item list-group-item-action @(Model.SelectedCategoryUrl=="" ? "active" : "")"
        asp-area=""
        asp-controller="BooksShop"
        asp-action="BookList"
        asp-route-categoryurl=""
        asp-route-authorurl=""
    >Tüm Kitaplar</a>
    @foreach (var categoryViewModel in Model.CategoryViewModelList)
    {
        <a class="list-group-item list-group-item-action @(Model.SelectedCategoryUrl==categoryViewModel.Url ? "active" : "")"
       asp-area=""
       asp-controller="BooksShop"
       asp-action="BookList"
       asp-route-categoryurl="@categoryViewModel.Url"
       asp-route-authorurl="">@categoryViewModel.Name</a>
    }
</div>

namespace BooksApp.MVC.Models
{
    public class CategoryListViewModel
    {
        public List<CategoryViewModel> CategoryViewModelList { get; set; }
        public string SelectedCategoryUrl { get; set; }
    }
}

namespace BooksApp.MVC.Models
{
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}

using BooksApp.Entity.Concrete;

namespace BooksApp.MVC.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUrl { get; set; }
        public string PublisherName { get; set; }
        public string PublisherUrl { get; set;}
    }
}


namespace BooksApp.Entity.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDeleted { get; set; } = false;
    }
}


amespace BooksApp.Entity.Concrete
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }
        public string Abstract { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public int EditionNumber { get; set; }
        public int EditionYear { get; set; }
        public bool IsHome { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}


namespace BooksApp.Entity.Concrete
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}

 
 */