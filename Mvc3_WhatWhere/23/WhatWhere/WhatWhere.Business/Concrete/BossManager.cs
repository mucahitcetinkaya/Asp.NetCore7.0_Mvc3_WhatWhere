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

        public async Task CreateAsync(Boss boss)
        {
            await _bossRepository.CreateAsync(boss);
        }

        public void Delete(Boss boss)
        {
            _bossRepository.Delete(boss);
        }

        public async Task<List<Boss>> GetAllAsync()
        {
            return await _bossRepository.GetAllAsync();
        }

        public async Task<Boss> GetByIdAsync(int id)
        {
            return await _bossRepository.GetByIdAsync(id);
        }

        public void Update(Boss boss)
        {
            _bossRepository.Update(boss);
        }
    }
}
