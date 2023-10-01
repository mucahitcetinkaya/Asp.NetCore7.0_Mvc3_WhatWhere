using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;
using WhatWhere.Data.Concrete.EfCore.Context;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreCategoryRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        // Belirli bir dükkâna sahip olan kategorileri getir
        public List<Category> GetCategoriesByShop(int id)
        {
            return _context.Categories
                .Where(c => c.Id == id)
                .ToList();
        }

        // Belirli bir şehirde bulunan kategorileri getir
        public List<Category> GetCategoriesByCity(int cityId)
        {
            return _context.Categories
                .Where(c => c.Shops.Any(s => s.CityId == cityId))
                .ToList();
        }

        // Bir kategoriye bir dükkân atama
        public void AssignShopToCategory(int categoryId, int shopId)
        {
            var category = _context.Categories.Find(categoryId);
            var shop = _context.Shops.Find(shopId);

            if (category != null && shop != null)
            {
                category.Shops.Add(shop);
                _context.SaveChanges();
            }
        }

        // Bir kategoriden dükkân çıkarma
        public void RemoveShopFromCategory(int categoryId, int shopId)
        {
            var category = _context.Categories.Find(categoryId);
            var shop = category?.Shops.FirstOrDefault(s => s.Id == shopId);

            if (category != null && shop != null)
            {
                category.Shops.Remove(shop);
                _context.SaveChanges();
            }
        }
    }
}
