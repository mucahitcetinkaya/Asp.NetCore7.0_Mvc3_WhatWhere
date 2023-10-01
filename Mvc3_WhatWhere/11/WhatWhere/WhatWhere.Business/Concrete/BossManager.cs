using WhatWhere.Entity.Concrete;
using WhatWhere.Business.Abstract;
using WhatWhere.Data.Abstract;

namespace WhatWhere.Business.Concrete
{
    public class BossManager : IBossService
    {
        private readonly IBossRepository _bossRepository;

        public BossManager(IBossRepository bossRepository)
        {
            _bossRepository = bossRepository;
        }

        public Boss GetById(int id)
        {
            return _bossRepository.GetById(id);
        }

        public List<Boss> GetAll()
        {
            return _bossRepository.GetAll();
        }

        public void Create(Boss boss)
        {
            _bossRepository.Create(boss);
        }

        public void Update(Boss boss)
        {
            _bossRepository.Update(boss);
        }

        public void Delete(Boss boss)
        {
            _bossRepository.Delete(boss);
        }

        public void AssignShopToBoss(int bossId, int shopId)
        {
            _bossRepository.AssignShopToBoss(bossId, shopId);
        }

        public void RemoveShopFromBoss(int bossId, int shopId)
        {
            _bossRepository.RemoveShopFromBoss(bossId, shopId);
        }
    }
}
