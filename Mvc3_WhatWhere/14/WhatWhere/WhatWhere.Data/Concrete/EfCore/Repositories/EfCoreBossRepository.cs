using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Data.Concrete.EfCore.Repositories;
using WhatWhere.Entity.Concrete;

public class EfCoreBossRepository : EfCoreGenericRepository<Boss>, IBossRepository
{
    private readonly WhatWhereContext _context;

    public EfCoreBossRepository(WhatWhereContext context) : base(context)
    {
        _context = context;
    }

    // Belirli bir patrona bir dükkân atama işlemini gerçekleştirir.
    public void AssignShopToBoss(int bossId, int shopId)
    {
        var boss = _context.Bosses.Find(bossId);
        var shop = _context.Shops.Find(shopId);

        if (boss != null && shop != null)
        {
            boss.Shops.Add(shop);
            _context.SaveChanges();
        }
    }

    // Belirli bir patronun bir dükkânını çıkarma işlemini gerçekleştirir.
    public void RemoveShopFromBoss(int bossId, int shopId)
    {
        var boss = _context.Bosses.Find(bossId);
        var shop = boss?.Shops.FirstOrDefault(s => s.Id == shopId);

        if (boss != null && shop != null)
        {
            boss.Shops.Remove(shop);
            _context.SaveChanges();
        }
    }
}
