namespace WhatWhere.Mvc.Models
{
    public class Boss : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int BirthOfYear { get; set; }
        public string Url { get; set; }
        public List<Shop> Shops { get; set; }
    }
}
