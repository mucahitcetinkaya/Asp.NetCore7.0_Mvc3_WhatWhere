using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface IBossService
    {
        // CRUD İşlemleri

        // Belirli bir patronu getir
        Boss GetById(int id);

        // Tüm patronları getir
        List<Boss> GetAll();

        // Yeni bir patron oluştur
        void Create(Boss boss);

        // Bir patronu güncelle
        void Update(Boss boss);

        // Bir patronu sil
        void Delete(Boss boss);

        // Bir patrona bir dükkân atama
        void AssignShopToBoss(int bossId, int shopId);

        // Bir patrondan dükkân çıkarma
        void RemoveShopFromBoss(int bossId, int shopId);
    }
}
