namespace WhatWhere.Entity.Concrete
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int SaleMembershipId { get; set; }
        public SaleMembership SaleMembership { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
    }
}
