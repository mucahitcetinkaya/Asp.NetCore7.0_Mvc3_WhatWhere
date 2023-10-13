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


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapAreaControllerRoute(
name: "Admin",
areaName: "Admin",
pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();