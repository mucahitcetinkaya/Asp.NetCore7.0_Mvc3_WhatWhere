using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface IBossService
    {
        Boss GetById(int id);
        List<Boss> GetAll();
        void Create(Boss boss);
        void Update(Boss boss);
        void Delete(Boss boss);
    }
}
