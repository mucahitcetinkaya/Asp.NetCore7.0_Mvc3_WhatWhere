namespace WhatWhere.Entity.Concrete
{
    public class City
    {
        public int Id { get; set; }
        public string Sehir { get; set; }

        public List<Shop> Shops { get; set; }
        public List<Town> Towns { get; set; }

    }

}
