using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatWhere.Entity.Concrete
{
    public class CustomCityType
    {
        public int Id { get; set; }
        public string Sehir { get; set; }
        public int? ParentId { get; set; }
    }
}
