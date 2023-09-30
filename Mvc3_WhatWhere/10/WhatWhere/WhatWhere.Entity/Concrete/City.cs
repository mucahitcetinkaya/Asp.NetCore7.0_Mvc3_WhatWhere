namespace WhatWhere.Entity.Concrete
{
    public class City
    {
        public int Id { get; set; }
        public string Sehir { get; set; }
        public string[] Ilce { get; set; }
        public List<Shop> Shops { get; set; }

    }

}
