using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Models
{
    public class ShopViewModel
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public int CityId { get; set; }
        public int CategoryId { get; set; }

        public City City { get; set; }
        public Category Category { get; set; }

        public List<Shop> Shops { get; set; }
    }
}
