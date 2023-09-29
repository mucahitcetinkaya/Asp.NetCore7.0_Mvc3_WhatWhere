using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface IShopService
    {
        Shop GetById(int id);
        List<Shop> GetAll();
        void Create(Shop shop);
        void Update(Shop shop);
        void Delete(Shop shop);

        List<Shop> GetHomePageShops();
    }
}
