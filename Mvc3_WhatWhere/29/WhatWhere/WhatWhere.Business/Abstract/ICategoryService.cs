using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICategoryService
    {
        // CRUD İşlemleri
        Task<Category> GetByIdAsync(int id);// Bir kategoriyi ID'ye göre getir
        Task<List<Category>> GetAllAsync();// Tüm kategorileri getir
        Task CreateAsync(Category category);// Yeni bir kategori oluştur
        void Update(Category category);// Bir kategoriyi güncelle
        void Delete(Category category);// Bir kategoriyi sil

        Task<List<Category>> GetAllCategoriesAsync(bool isDeleted, bool? isActive = null);

    }
}