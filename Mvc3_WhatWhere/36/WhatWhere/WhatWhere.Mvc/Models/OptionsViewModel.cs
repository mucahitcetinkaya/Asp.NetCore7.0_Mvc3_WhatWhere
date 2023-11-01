using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Models
{
    public class OptionsViewModel
    {
        public List<City>? Cities { get; set; }
        public List<Town>? Towns { get; set; }
        public List<Category>? Categories { get; set; }
        public List<Shop>? Shops { get; set; }
    }
}
