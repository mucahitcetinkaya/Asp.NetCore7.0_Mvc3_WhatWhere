using Microsoft.EntityFrameworkCore;
using WhatWhere.Mvc.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WhatWhereContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

/*

diger projede veriler controller k�sm�nda new list ile list olarak gidiyor

diger projeden fark� bunda dbcontext e gectik

bunda context olusturup dbset ile nesneleri yazd�k

sonra kod ile database i�ine yukledik verileri hasdata kulland�k

onda controller uzer�nden tablo ile g�sterdik
bunda database olusturup ordan cekece�iz

db i�in paketleri y�kledik

        dotnet add package Microsoft.EntityFrameworkCore
        dotnet add package Microsoft.EntityFrameworkCore.Sqlite
        dotnet add package Microsoft.EntityFrameworkCore.Design

appsetting de yolun hepsini yazd�k mig yaparken baslang�c belirtmemek i�in


mig ve update yapmak i�in

        dotnet ef migrations add Data
        dotnet ef database update

mig ve update yapt�k 

sonra context �zerinden Dependency Injection ile baglanabilmesi i�in

private readonly WhatWhereContext _context;

        public BossController(WhatWhereContext context)
        {
            _context = context;
        }

olusturduk 

sonrada model uzer�nden view e gonderdik

        public IActionResult Index()
        {
            var model = _context.Bosses.ToList();
            return View(model);
        }

art�k dbcontext ile data uzer�nden cekiyor verileri

*/