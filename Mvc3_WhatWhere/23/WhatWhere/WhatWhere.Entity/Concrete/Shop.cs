using WhatWhere.Entity.Abstract;

namespace WhatWhere.Entity.Concrete
{
    public class Shop : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public bool IsHome { get; set; } = true;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;


        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public int? BossId { get; set; }
        public Boss Boss { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public int? CityId { get; set; }
        public City City { get; set; }

        public int? TownId { get; set; }
        public Town Town { get; set; }
        
    }
}
