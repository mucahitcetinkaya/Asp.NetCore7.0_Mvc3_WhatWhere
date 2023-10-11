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

        public void Create(SaleMembership saleMembership)
        {
            _saleMembershipRepository.Create(saleMembership);
        }

        public void Delete(SaleMembership saleMembership)
        {
            _saleMembershipRepository.Delete(saleMembership);
        }

        public List<SaleMembership> GetAll()
        {
            return _saleMembershipRepository.GetAll();
        }

        public SaleMembership GetById(int id)
        {
            return _saleMembershipRepository.GetById(id);
        }

        public void Update(SaleMembership saleMembership)
        {
            _saleMembershipRepository.Update(saleMembership);
        }
    }
}