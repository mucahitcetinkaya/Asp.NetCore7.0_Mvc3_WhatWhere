using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreShopRepository : EfCoreGenericRepository<Shop>, IShopRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreShopRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public List<Category> GetCategoriesOfShop(int shopId)
        {
            // Veritabanından belirli bir dükkânın kategorisini getirme işlemi
            return _context.Shops
                .Where(s => s.Id == shopId)
                .Select(s => s.Category)
                .ToList();
        }

        public City GetCityOfShop(int shopId)
        {
            // Veritabanından belirli bir dükkânın bulunduğu şehri getirme işlemi
            return _context.Shops
                .Where(s => s.Id == shopId)
                .Select(s => s.City)
                .FirstOrDefault();
        }

        public Town GetTownOfShop(int shopId)
        {
            // Veritabanından belirli bir dükkânın bulunduğu kasabayı getirme işlemi
            return _context.Shops
                .Where(s => s.Id == shopId)
                .Select(s => s.Town)
                .FirstOrDefault();
        }

        public Boss GetBossOfShop(int shopId)
        {
            // Veritabanından belirli bir dükkânın patronunu getirme işlemi
            return _context.Shops
                .Where(s => s.Id == shopId)
                .Select(s => s.Boss)
                .FirstOrDefault();
        }

        public void AssignBossToShop(int shopId, int bossId)
        {
            // Belirli bir dükkâna bir patron atama işlemi
            var shop = _context.Shops.Find(shopId);
            var boss = _context.Bosses.Find(bossId);

            if (shop != null && boss != null)
            {
                shop.Boss = boss;
                _context.SaveChanges();
            }
        }

        public void RemoveBossFromShop(int shopId, int bossId)
        {
            // Belirli bir dükkândan patron çıkarma işlemi
            var shop = _context.Shops.Find(shopId);

            if (shop != null && shop.BossId == bossId)
            {
                shop.Boss = null;
                _context.SaveChanges();
            }
        }

        public void ActivateShop(int shopId)
        {
            // Belirli bir dükkânı etkinleştirme işlemi
            var shop = _context.Shops.Find(shopId);

            if (shop != null && !shop.IsActive)
            {
                shop.IsActive = true;
                _context.SaveChanges();
            }
        }

        public void DeactivateShop(int shopId)
        {
            // Belirli bir dükkânı pasifleştirme işlemi
            var shop = _context.Shops.Find(shopId);

            if (shop != null && shop.IsActive)
            {
                shop.IsActive = false;
                _context.SaveChanges();
            }
        }

        public List<Shop> GetShopOfTown(int townId, int categoryId)
        {
            if (townId == null && categoryId == null)
            {
                return _context.Shops.ToList();
            }
            else
            {
                return _context.Shops.Where(s => s.TownId == townId && s.CategoryId == categoryId).ToList();
            }
        }
        public List<Shop> GetShopsByCityTownAndCategory(int cityId, int townId, int categoryId)
        {
            if (cityId == 0 && townId == 0 && categoryId == 0)
            {
                // Şehir, ilçe ve kategori parametrelerinin hepsi 0 (varsayılan değerleri) olarak geldiyse
                // Tüm dükkânları getir.
                return _context.Shops.ToList();
            }

            // Şehir, ilçe ve kategori parametrelerine göre filtreleme yaparak dükkânları getir.
            return _context.Shops
                .Where(s => (cityId == 0 || s.CityId == cityId)
                         && (townId == 0 || s.TownId == townId)
                         && (categoryId == 0 || s.CategoryId == categoryId))
                .ToList();
        }
    }
}