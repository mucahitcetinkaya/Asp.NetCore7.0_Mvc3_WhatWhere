using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ISaleMembershipService
    {
        // CRUD İşlemleri
        SaleMembership GetById(int id);// Bir satılan süreli üyeliği ID'ye göre getir
        List<SaleMembership> GetAll();// Tüm satılan süreli üyeliklerin hepsini getir
        void Create(SaleMembership saleMembership);// Yeni bir satılan süreli üyeliği oluştur
        void Update(SaleMembership saleMembership);// Bir satılan süreli üyeliği güncelle
        void Delete(SaleMembership saleMembership);// Bir satılan süreli üyeliği sil
    }
}