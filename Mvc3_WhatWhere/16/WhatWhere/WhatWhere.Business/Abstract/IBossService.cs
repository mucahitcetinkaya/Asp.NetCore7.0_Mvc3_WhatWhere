using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface IBossService
    {
        // CRUD İşlemleri
        Boss GetById(int id);// Bir patronu ID'ye göre getir
        List<Boss> GetAll();// Tüm patronları getir
        void Create(Boss boss);// Yeni bir patron oluştur
        void Update(Boss boss);// Bir patronu güncelle
        void Delete(Boss boss);// Bir patronu sil
    }
}