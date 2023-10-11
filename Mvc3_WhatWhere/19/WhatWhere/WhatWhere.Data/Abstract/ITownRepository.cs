using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ITownRepository : IGenericRepository<Town>
    {
        List<Town> GetTownsByCity(int cityId);// Bir şehre bağlı olan kasabaları getir
        List<Town> GetAllIncludingCity();

    }
}
