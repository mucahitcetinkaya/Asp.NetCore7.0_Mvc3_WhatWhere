using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Models
{
    public class TownViewModel : BaseViewModel
    {
        public string Ilce { get; set; }
        public int CityId { get; set; }
        public string Sehir { get; set; }
        public List<Town> Towns { get; internal set; }
    }
}
