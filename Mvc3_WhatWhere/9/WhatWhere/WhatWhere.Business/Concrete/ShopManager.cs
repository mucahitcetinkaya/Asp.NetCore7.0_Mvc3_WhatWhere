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
    public class ShopManager : IShopService
    {
        private readonly IShopRepository _shopRepository;

        public ShopManager(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public void Create(Shop shop)
        {
            throw new NotImplementedException();
        }

        public void Delete(Shop shop)
        {
            throw new NotImplementedException();
        }

        public List<Shop> GetAll()
        {
            return _shopRepository.GetAll();
        }

        public Shop GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shop> GetHomePageShops()
        {
            throw new NotImplementedException();
        }

        public void Update(Shop shop)
        {
            throw new NotImplementedException();
        }
    }
}
