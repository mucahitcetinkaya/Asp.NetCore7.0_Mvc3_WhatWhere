using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Models
{
    public class TownViewModel
    {
        public int Id { get; set; }
        public string Ilce { get; set; }
        public int? CityId { get; set; }
        public City? City { get; set; }
    }
}
