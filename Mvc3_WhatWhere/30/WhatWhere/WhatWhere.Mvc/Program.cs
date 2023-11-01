using AspNetCoreHero.ToastNotification;
using Microsoft.EntityFrameworkCore;
using WhatWhere.Business.Abstract;
using WhatWhere.Business.Concrete;
using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Data.Concrete.EfCore.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WhatWhereContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
        b => b.MigrationsAssembly("WhatWhere.Data"));
});

builder.Services.AddScoped<IBossService, BossManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IShopService, ShopManager>();
builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<ITownService, TownManager>();
builder.Services.AddScoped<ISaleMembershipService, SaleMembershipManager>();

builder.Services.AddScoped<IBossRepository, EfCoreBossRepository>();
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
builder.Services.AddScoped<IShopRepository, EfCoreShopRepository>();
builder.Services.AddScoped<ICityRepository, EfCoreCityRepository>();
builder.Services.AddScoped<ITownRepository, EfCoreTownRepository>();
builder.Services.AddScoped<ISaleMembershipRepository, EfCoreSaleMembershipRepository>();


builder.Services.AddNotyf(config =>
{
    config.DurationInSeconds = 5;
    config.IsDismissable = true;
    config.Position = NotyfPosition.BottomRight;
});

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


//BOSS ALANI

//CATEGORY ALANI

//CITY ALANI

app.MapControllerRoute(
   name: "cGetCityNameWithOneCity",
   pattern: "Deneme/CGetCityNameWithOneCity/{cityName}",
   defaults: new { controller = "Deneme", action = "CGetCityNameWithOneCity" });

app.MapControllerRoute(
   name: "cGetTownsListWithCityName",
   pattern: "Deneme/CGetTownsListWithCityName/{cityName}",
   defaults: new { controller = "Deneme", action = "CGetTownsListWithCityName" });

// TOWN ALANI 

app.MapControllerRoute(
   name: "tGetTownListWithCityId",
   pattern: "Deneme/TGetTownListWithCityId/{cityId}",
   defaults: new { controller = "Deneme", action = "TGetTownListWithCityId" });

app.MapControllerRoute(
   name: "tGetTownsListWithCityName",
   pattern: "Deneme/TGetTownsListWithCityName/{cityName}",
   defaults: new { controller = "Deneme", action = "TGetTownsListWithCityName" });


// OPTIONS CONTROLLER

app.MapControllerRoute(
   name: "GetCategoriesByCityId",
   pattern: "Options/GetCategoriesByCityId/{cityId}",
   defaults: new { controller = "Options", action = "GetCategoriesByCityId" });

app.MapControllerRoute(
   name: "GetCategoriesByTownId",
   pattern: "Options/GetCategoriesByTownId/{townId}",
   defaults: new { controller = "Options", action = "GetCategoriesByTownId" });

app.MapControllerRoute(
   name: "GetFilteredShops",
   pattern: "Options/GetFilteredShops/{cityId, townId, categoryId}",
   defaults: new { controller = "Options", action = "GetFilteredShops" });

app.MapControllerRoute(
   name: "GetTownsByCityId",
   pattern: "Options/GetTownsByCityId/{cityId}",
   defaults: new { controller = "Options", action = "GetTownsByCityId" });

//ADMIN

app.MapAreaControllerRoute(
   name: "Admin",
   areaName: "Admin",
   pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

// HOME

app.MapControllerRoute(
   name: "default",
   pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
