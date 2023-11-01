using AspNetCoreHero.ToastNotification;
using BooksApp.MVC.EmailServices.Abstract;
using BooksApp.MVC.EmailServices.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WhatWhere.Business.Abstract;
using WhatWhere.Business.Concrete;
using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Data.Concrete.EfCore.Repositories;
using WhatWhere.Entity.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WhatWhereContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"),
        b => b.MigrationsAssembly("WhatWhere.Data"));
});


builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<WhatWhereContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;//Þifre içinde sayýsal deðer olmalý mý?
    options.Password.RequireLowercase = true;//Þifre içinde küçük harf olmalý mý?
    options.Password.RequireUppercase = true;//Þifre içinde büyük harf olmalý mý?
    options.Password.RequiredLength = 6;//Þifrenin uzunluðu en az kaç karakter olmalý?
    options.Password.RequireNonAlphanumeric = true;//Þifre içinde özel karakter olmalý mý?

    options.Lockout.MaxFailedAccessAttempts = 300; //Üst üste izin verilecek hatalý giriþ sayýsý
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(5);//Üst üste izin verilen kez hatalý giriþ yapmaya çalýþýlan hesap hangi süreyle kilitlenecek?

    options.User.RequireUniqueEmail = true;//Sistemden daha önce kayýtlý olmayan bir mail adresi kullanýlmak zorunda olsun mu?

    options.SignIn.RequireConfirmedEmail = false;//Kayýt olunurken email onayý istensin mi?
    options.SignIn.RequireConfirmedPhoneNumber = false; //Kayýt olunurken telefon onayý istensin mi?
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";//Eðer kullanýcý eriþebilmesi için login olmak zorunda olduðu bir istekte bulunursa, yönlendirilecek path.
    options.LogoutPath = "/account/logout";//Logout olduðunda yönlendirilecek action
    options.AccessDeniedPath = "/account/accessdenied";//Kullanýcý yetkisi olmayan bir endpointe istekte bulunursa yönlendirilecek path
    options.ExpireTimeSpan = TimeSpan.FromMinutes(3);//Cookiemizin yaþam süresi ne kadar olacak?
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        Name = "WhatWhere.Security.Cookie"
    };
});

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(option => new SmtpEmailSender
(
    builder.Configuration["EmailSender:Host"],
    builder.Configuration.GetValue<int>("EmailSender:Port"),
    builder.Configuration["EmailSender:UserName"],
    builder.Configuration["EmailSender:Password"],
    builder.Configuration.GetValue<bool>("EmailSender:EnableSsl")
));


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

app.UseAuthentication();

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

//app.MapControllerRoute(
//   name: "default",
//   pattern: "{controller=Options}/{action=Index}/{id?}");


app.Run();
