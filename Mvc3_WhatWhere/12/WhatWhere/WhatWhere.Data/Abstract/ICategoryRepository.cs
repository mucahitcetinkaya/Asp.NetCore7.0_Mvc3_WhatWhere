using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        // Belirli bir dükkâna sahip olan kategorileri getirir
        List<Category> GetCategoriesByShop(int shopId);

        // Belirli bir şehre sahip olan kategorileri getirir
        List<Category> GetCategoriesByCity(int cityId);

        // Bir kategoriye bir dükkân atar
        void AssignShopToCategory(int categoryId, int shopId);

        // Bir kategoriden dükkânı çıkarır
        void RemoveShopFromCategory(int categoryId, int shopId);
    }
}
