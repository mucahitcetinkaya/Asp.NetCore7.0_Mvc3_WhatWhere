using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ISaleMembershipService
    {
        // CRUD İşlemleri
        Task<SaleMembership> GetByIdAsync(int id);// Bir satılan süreli üyeliği ID'ye göre getir
        Task<List<SaleMembership>> GetAllAsync();// Tüm satılan süreli üyeliklerin hepsini getir
        Task CreateAsync(SaleMembership saleMembership);// Yeni bir satılan süreli üyeliği oluştur
        void Update(SaleMembership saleMembership);// Bir satılan süreli üyeliği güncelle
        void Delete(SaleMembership saleMembership);// Bir satılan süreli üyeliği sil
    }
}