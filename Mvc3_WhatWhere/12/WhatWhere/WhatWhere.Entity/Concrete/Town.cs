namespace WhatWhere.Entity.Concrete
{
    public class Town
    {
        public int Id { get; set; }
        public string Ilce { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public List<Shop> Shops { get; set; }
        //public List<Category> Categories { get; set; }
    }
}