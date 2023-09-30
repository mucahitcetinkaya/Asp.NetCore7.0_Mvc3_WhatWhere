using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICityService
    {
        City GetById(int id);
        List<City> GetAll();
        void Create(City city);
        void Update(City city);
        void Delete(City city);

        List<City> GetCitiesByShop(int shopId);
    }
}
