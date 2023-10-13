using WhatWhere.Business.Abstract;
using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Concrete
{
    public class SaleMembershipManager : ISaleMembershipService
    {
        private readonly ISaleMembershipRepository _saleMembershipRepository;

        public SaleMembershipManager(ISaleMembershipRepository saleMembershipRepository)
        {
            _saleMembershipRepository = saleMembershipRepository;
        }

        public async Task CreateAsync(SaleMembership saleMembership)
        {
            await _saleMembershipRepository.CreateAsync(saleMembership);
        }

        public void Delete(SaleMembership saleMembership)
        {
            _saleMembershipRepository.Delete(saleMembership);
        }

        public async Task<List<SaleMembership>> GetAllAsync()
        {
            return await _saleMembershipRepository.GetAllAsync();
        }

        public async Task<SaleMembership> GetByIdAsync(int id)
        {
            return await _saleMembershipRepository.GetByIdAsync(id);
        }

        public void Update(SaleMembership saleMembership)
        {
            _saleMembershipRepository.Update(saleMembership);
        }
    }
}