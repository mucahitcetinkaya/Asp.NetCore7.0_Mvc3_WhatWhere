using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreShopRepository : EfCoreGenericRepository<Shop>, IShopRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreShopRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
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

        public async Task<List<Shop>> GetAllShopsWithCityTownCategoryAsync(bool isDeleted, bool? isActive = null)
        {
            var result = await _context
                .Shops
                .Where(b => b.IsDeleted == isDeleted)
                .Include(b => b.Category)
                .Include(b => b.City)
                .Include(b => b.Town)
                .ToListAsync();
            return result;
        }

        public async Task<List<Shop>> GetShopsByCategoryAsync(string categoryName = null)
        {
            var result = _context
                .Shops
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

        public async Task<List<Shop>> GetShopsByFilter(int? cityId, int? townId, int? categoryId)
        {
            var query = _context
                .Shops
                .Where(s => s.IsActive && !s.IsDeleted)
                .Include(s => s.Boss)
                .Include(s => s.Category)
                .Include(s => s.City)
                .Include(s => s.Town)
                .AsQueryable();

            if (cityId != 0)
            {
                query = query.Where(s => s.CityId == cityId);
            }

            if (townId != 0)
            {
                query = query.Where(s => s.TownId == townId);
            }

            if (categoryId != 0)
            {
                query = query.Where(s => s.CategoryId == categoryId);
            }

            return await query.ToListAsync();
        }

        

        //public async Task CreateShopAsync(Shop shop, int categoryId, int cityId, int townId)
        //{
        //    shop.CategoryId = categoryId; // Kategori atanıyor
        //    shop.CityId = cityId; // Şehir atanıyor
        //    shop.TownId = townId; // İlçe atanıyor

        //    await _context.Shops.AddAsync(shop);
        //    await _context.SaveChangesAsync();
        //}


        //public async Task CheckShopsCategories()
        //{
        //    var shops = await _context.Shops.ToListAsync();
        //    var generalCategoryId = await _context.Categories
        //        .Where(c => c.Name == "Genel")
        //        .Select(c => c.Id)
        //        .FirstOrDefaultAsync();

        //    if (generalCategoryId != default)
        //    {
        //        foreach (var shop in shops)
        //        {
        //            if (shop.CategoryId == null)
        //            {
        //                shop.CategoryId = generalCategoryId;
        //            }
        //        }

        //        await _context.SaveChangesAsync();
        //    }
        //}

        //public void UpdateShop(Shop shop)
        //{
        //    Shop oldShop = _context
        //        .Shops
        //        .Where(s => s.Id == shop.Id)
        //        .FirstOrDefault();

        //    if (oldShop != null)
        //    {
        //        oldShop.Name = shop.Name;
        //        oldShop.PhoneNumber = shop.PhoneNumber;
        //        oldShop.Address = shop.Address;
        //        oldShop.City = shop.City;
        //        oldShop.Town = shop.Town;
        //        oldShop.IsActive = shop.IsActive;
        //        oldShop.ModifiedDate = shop.ModifiedDate;
        //        oldShop.ImageUrl = shop.ImageUrl;
        //        oldShop.CategoryId = shop.CategoryId;

        //        _context.Shops.Update(oldShop);
        //        _context.SaveChanges();
        //    }
        //}

    }
}