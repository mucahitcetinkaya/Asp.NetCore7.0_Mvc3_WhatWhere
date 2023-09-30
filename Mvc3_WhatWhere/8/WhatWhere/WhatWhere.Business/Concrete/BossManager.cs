using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatWhere.Business.Abstract;
using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Concrete
{
    public class BossManager : IBossService
    {
        private readonly IBossRepository _bossRepository;

        public BossManager(IBossRepository bossRepository)
        {
            _bossRepository = bossRepository;
        }

        public void Create(Boss boss)
        {
            throw new NotImplementedException();
        }

        public void Delete(Boss boss)
        {
            throw new NotImplementedException();
        }

        public List<Boss> GetAll()
        {
            return _bossRepository.GetAll();
        }

        public Boss GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Boss boss)
        {
            throw new NotImplementedException();
        }
    }
}
