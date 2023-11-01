using WhatWhere.Entity.Concrete;

namespace WhatWhere.Mvc.Models
{
    public class ShopDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string MailAdress { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        public int BossId { get; set; }
        public Boss Boss { get; set; }
    }
}
