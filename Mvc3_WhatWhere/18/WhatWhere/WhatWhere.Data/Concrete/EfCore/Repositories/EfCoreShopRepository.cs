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

        public List<Shop> GetAllIncludingCityAndTown()
        {
            var shop = _context.Shops.Include(s => s.City).Include(s => s.Town).ToList();
            return shop;
        }

        public void AssignBossToShop(int shopId, int bossId)
        {
            // TODO: Veritabanında shopId'e sahip dükkânın BossId'sini güncelle
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                shop.BossId = bossId;
                _context.SaveChanges();
            }
        }

        public void AssignCategoryToShop(int shopId, int categoryId)
        {
            // TODO: Veritabanında shopId'e sahip dükkâna kategori atama işlemleri
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                var category = _context.Categories.Find(categoryId);
                if (category != null)
                {
                    shop.CategoryId = categoryId;
                    _context.SaveChanges();
                }
            }
        }

        public void AssignCityToShop(int shopId, int cityId)
        {
            // TODO: Veritabanında shopId'e sahip dükkâna şehir atama işlemleri
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                var city = _context.Cities.Find(cityId);
                if (city != null)
                {
                    shop.CityId = cityId;
                    _context.SaveChanges();
                }
            }
        }

        public void AssignTownToShop(int shopId, int townId)
        {
            // TODO: Veritabanında shopId'e sahip dükkâna ilçe atama işlemleri
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                var town = _context.Towns.Find(townId);
                if (town != null)
                {
                    shop.TownId = townId;
                    _context.SaveChanges();
                }
            }
        }

        

        public Boss GetBossOfShop(int shopId)
        {
            // TODO: Veritabanında shopId'e sahip dükkânın patronunu getir
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                return _context.Bosses.Find(shop.BossId);
            }
            return null;
        }

        public Category GetCategoryOfShop(int shopId)
        {
            // TODO: Veritabanında shopId'e sahip dükkânın kategorisini getir
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                return _context.Categories.Find(shop.CategoryId);
            }
            return null;
        }

        public City GetCityOfShop(int shopId)
        {
            // TODO: Veritabanında shopId'e sahip dükkânın şehrini getir
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                return _context.Cities.Find(shop.CityId);
            }
            return null;
        }

        public Town GetTownOfShop(int shopId)
        {
            // TODO: Veritabanında shopId'e sahip dükkânın ilçesini getir
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                return _context.Towns.Find(shop.TownId);
            }
            return null;
        }

        public void RemoveBossFromShop(int shopId)
        {
            // TODO: Veritabanında shopId'e sahip dükkânın patronunu kaldır
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                shop.BossId = null;
                _context.SaveChanges();
            }
        }

        public void RemoveCategoryFromShop(int shopId, int categoryId)
        {
            // TODO: Veritabanında shopId'e sahip dükkândan belirli bir kategoriyi kaldırma işlemleri
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                if (shop.CategoryId == categoryId)
                {
                    shop.CategoryId = null;
                    _context.SaveChanges();
                }
            }
        }

        public void RemoveCityFromShop(int shopId)
        {
            // TODO: Veritabanında shopId'e sahip dükkândan şehiri kaldırma işlemleri
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                shop.CityId = null;
                _context.SaveChanges();
            }
        }

        public void RemoveTownFromShop(int shopId)
        {
            // TODO: Veritabanında shopId'e sahip dükkândan ilçeyi kaldırma işlemleri
            var shop = _context.Shops.Find(shopId);
            if (shop != null)
            {
                shop.TownId = null;
                _context.SaveChanges();
            }
        }
    }
}