using System.Linq;
using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreTownRepository : EfCoreGenericRepository<Town>, ITownRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreTownRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public void AssignShopToTown(int townId, int shopId)
        {
            var town = _context.Towns.Find(townId);
            var shop = _context.Shops.Find(shopId);

            if (town != null && shop != null)
            {
                town.Shops.Add(shop);
                _context.SaveChanges();
            }
        }

        public List<City> GetCitiesByTowns(List<int> townIds)
        {
            return _context.Towns
                .Where(t => townIds.Contains(t.Id))
                .Select(t => t.City)
                .Distinct()
                .ToList();
        }

        public List<Shop> GetShopsByCategory(List<int> categoryIds)
        {
            return _context.Shops
                .Where(s => categoryIds.Contains((int)s.CategoryId))
                .ToList();
        }

        public Town GetTownByShop(int shopId)
        {
            // Veritabanından belirli bir dükkâna bağlı olan kasabayı getirme işlemi
            return _context.Towns
                .FirstOrDefault(t => t.Shops.Any(s => s.Id == shopId));
        }

        public List<Town> GetTownsByCity(int cityId)
        {
            // Veritabanından belirli bir şehre bağlı olan kasabaları getirme işlemi
            return _context.Towns
                .Where(t => t.CityId == cityId)
                .ToList();
        }

        public void RemoveShopFromTown(int townId, int shopId)
        {
            var town = _context.Towns.Find(townId);
            var shop = town?.Shops.FirstOrDefault(s => s.Id == shopId);

            if (town != null && shop != null)
            {
                town.Shops.Remove(shop);
                _context.SaveChanges();
            }
        }
    }
}