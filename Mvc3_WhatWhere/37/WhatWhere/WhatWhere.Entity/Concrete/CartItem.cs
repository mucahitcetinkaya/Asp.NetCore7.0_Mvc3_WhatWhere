namespace WhatWhere.Entity.Concrete
{
    public class CartItem
    {
        public int Id { get; set; }
        public int SaleMembershipId { get; set; }
        public SaleMembership SaleMembership { get; set; }
        public int CartId { get; set; } 
        public Cart Cart { get; set; }
        public int Quantity { get; set; }
    }
}
