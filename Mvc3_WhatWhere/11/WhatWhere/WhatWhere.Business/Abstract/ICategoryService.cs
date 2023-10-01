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

        // Özelleştirme: Belirli bir dükkâna sahip olan kategorileri getir
        List<Category> GetCategoriesByShop(int shopId);

        // Özelleştirme: Belirli bir şehirde bulunan kategorileri getir
        List<Category> GetCategoriesByCity(int cityId);

        // Özelleştirme: Belirli bir kasabada bulunan kategorileri getir
        List<Category> GetCategoriesByTown(int townId);

        // Özelleştirme: Bir kategoriye bir dükkân atama
        void AssignShopToCategory(int categoryId, int shopId);

        // Özelleştirme: Bir kategoriden dükkân çıkarma
        void RemoveShopFromCategory(int categoryId, int shopId);
    }
}
