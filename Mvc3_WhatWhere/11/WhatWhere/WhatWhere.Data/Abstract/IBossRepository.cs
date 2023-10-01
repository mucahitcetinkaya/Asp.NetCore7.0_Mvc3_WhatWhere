using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface IBossRepository : IGenericRepository<Boss>
    {
        // Bir patrona bir dükkân atama
        void AssignShopToBoss(int bossId, int shopId);

        // Bir patronun dükkânından dükkân çıkarma
        void RemoveShopFromBoss(int bossId, int shopId);
    }
}
