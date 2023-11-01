﻿namespace WhatWhere.Entity.Concrete
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } = "default.jpg";
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public List<Shop> Shops { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
