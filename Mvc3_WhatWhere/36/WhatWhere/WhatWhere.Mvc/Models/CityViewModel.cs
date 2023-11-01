﻿using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Models
{
    public class CityViewModel
    {
        public int Id { get; set; }
        public string Sehir { get; set; }
        public List<Shop> Shops { get; set; }
        public List<Town> Towns { get; set; }
    }
}
