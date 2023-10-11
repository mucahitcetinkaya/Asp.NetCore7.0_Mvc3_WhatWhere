using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICategoryService
    {
        // CRUD İşlemleri
        Category GetById(int id);// Bir kategoriyi ID'ye göre getir
        List<Category> GetAll();// Tüm kategorileri getir
        void Create(Category category);// Yeni bir kategori oluştur
        void Update(Category category);// Bir kategoriyi güncelle
        void Delete(Category category);// Bir kategoriyi sil
    }
}