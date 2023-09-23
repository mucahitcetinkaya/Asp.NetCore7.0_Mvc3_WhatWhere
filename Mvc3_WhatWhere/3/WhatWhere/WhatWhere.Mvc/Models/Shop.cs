namespace WhatWhere.Mvc.Models
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }


        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public bool IsHome { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public string Country { get; set; }
        public string City { get; set; }
        public string Town { get; set; }


        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}