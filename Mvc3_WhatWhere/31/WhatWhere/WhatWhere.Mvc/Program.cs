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
    options.Password.RequireDigit = true;//�ifre i�inde say�sal de�er olmal� m�?
    options.Password.RequireLowercase = true;//�ifre i�inde k���k harf olmal� m�?
    options.Password.RequireUppercase = true;//�ifre i�inde b�y�k harf olmal� m�?
    options.Password.RequiredLength = 6;//�ifrenin uzunlu�u en az ka� karakter olmal�?
    options.Password.RequireNonAlphanumeric = true;//�ifre i�inde �zel karakter olmal� m�?

    options.Lockout.MaxFailedAccessAttempts = 300; //�st �ste izin verilecek hatal� giri� say�s�
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(5);//�st �ste izin verilen kez hatal� giri� yapmaya �al���lan hesap hangi s�reyle kilitlenecek?

    options.User.RequireUniqueEmail = true;//Sistemden daha �nce kay�tl� olmayan bir mail adresi kullan�lmak zorunda olsun mu?

    options.SignIn.RequireConfirmedEmail = false;//Kay�t olunurken email onay� istensin mi?
    options.SignIn.RequireConfirmedPhoneNumber = false; //Kay�t olunurken telefon onay� istensin mi?
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login";//E�er kullan�c� eri�ebilmesi i�in login olmak zorunda oldu�u bir istekte bulunursa, y�nlendirilecek path.
    options.LogoutPath = "/account/logout";//Logout oldu�unda y�nlendirilecek action
    options.AccessDeniedPath = "/account/accessdenied";//Kullan�c� yetkisi olmayan bir endpointe istekte bulunursa y�nlendirilecek path
    options.ExpireTimeSpan = TimeSpan.FromMinutes(3);//Cookiemizin ya�am s�resi ne kadar olacak?
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
