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

diger projede veriler controller kýsmýnda new list ile list olarak gidiyor

diger projeden farký bunda dbcontext e gectik

bunda context olusturup dbset ile nesneleri yazdýk

sonra kod ile database içine yukledik verileri hasdata kullandýk

onda controller uzerýnden tablo ile gösterdik
bunda database olusturup ordan cekeceðiz

db için paketleri yükledik

        dotnet add package Microsoft.EntityFrameworkCore
        dotnet add package Microsoft.EntityFrameworkCore.Sqlite
        dotnet add package Microsoft.EntityFrameworkCore.Design

appsetting de yolun hepsini yazdýk mig yaparken baslangýc belirtmemek için


mig ve update yapmak için

        dotnet ef migrations add Data
        dotnet ef database update

mig ve update yaptýk 

sonra context üzerinden Dependency Injection ile baglanabilmesi için

private readonly WhatWhereContext _context;

        public BossController(WhatWhereContext context)
        {
            _context = context;
        }

olusturduk 

sonrada model uzerýnden view e gonderdik

        public IActionResult Index()
        {
            var model = _context.Bosses.ToList();
            return View(model);
        }

artýk dbcontext ile data uzerýnden cekiyor verileri

*/