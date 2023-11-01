using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface IBossService
    {
        // CRUD İşlemleri
        Task<Boss> GetByIdAsync(int id);// Bir patronu ID'ye göre getir
        Task<List<Boss>> GetAllAsync();// Tüm patronları getir
        Task CreateAsync(Boss boss);// Yeni bir patron oluştur
        void Update(Boss boss);// Bir patronu güncelle
        void Delete(Boss boss);// Bir patronu sil
    }
}