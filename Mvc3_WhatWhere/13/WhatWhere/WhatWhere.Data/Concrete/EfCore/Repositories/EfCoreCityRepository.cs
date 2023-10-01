using Microsoft.EntityFrameworkCore;
using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City>, ICityRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreCityRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public List<City> GetCitiesByShop(int shopId)
        {
            // Belirli bir dükkâna sahip şehirleri getirme işlemi
            return _context.Cities
                .Where(c => c.Shops.Any(s => s.Id == shopId))
                .ToList();
        }

        public List<City> GetCitiesByCategory(int categoryId)
        {
            // Belirli bir kategoriye sahip şehirleri getirme işlemi
            return _context.Cities
                .Where(c => c.Shops.Any(s => s.CategoryId == categoryId))
                .ToList();
        }

        public List<City> GetCitiesByTown(int townId)
        {
            // Belirli bir kasabada bulunan şehirleri getirme işlemi
            return _context.Cities
                .Where(c => c.Towns.Any(t => t.Id == townId))
                .ToList();
        }

        public void AssignShopToCity(int cityId, int shopId)
        {
            // Bir şehre bir dükkân atama işlemi
            var city = _context.Cities
                .Include(c => c.Shops)
                .FirstOrDefault(c => c.Id == cityId);

            var shop = _context.Shops.Find(shopId);

            if (city != null && shop != null)
            {
                city.Shops.Add(shop);
                _context.SaveChanges();
            }
        }

        public void RemoveShopFromCity(int cityId, int shopId)
        {
            // Bir şehirden dükkân çıkarma işlemi
            var city = _context.Cities
                .Include(c => c.Shops)
                .FirstOrDefault(c => c.Id == cityId);

            var shop = city?.Shops.FirstOrDefault(s => s.Id == shopId);

            if (city != null && shop != null)
            {
                city.Shops.Remove(shop);
                _context.SaveChanges();
            }
        }
    }
}
