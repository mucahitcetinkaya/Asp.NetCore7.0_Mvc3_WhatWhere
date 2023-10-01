using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICategoryService
    {
        // CRUD İşlemleri

        // Belirli bir kategoriyi getir
        Category GetById(int id);

        // Tüm kategorileri getir
        List<Category> GetAll();

        // Yeni bir kategori oluştur
        void Create(Category category);

        // Bir kategoriyi güncelle
        void Update(Category category);

        // Bir kategoriyi sil
        void Delete(Category category);

        // Belirli bir dükkâna sahip olan kategorileri getir
        List<Category> GetCategoriesByShop(int shopId);

        // Belirli bir şehirde bulunan kategorileri getir
        List<Category> GetCategoriesByCity(int cityId);

        // Bir kategoriye bir dükkân atama
        void AssignShopToCategory(int categoryId, int shopId);

        // Bir kategoriden dükkân çıkarma
        void RemoveShopFromCategory(int categoryId, int shopId);
    }
}
