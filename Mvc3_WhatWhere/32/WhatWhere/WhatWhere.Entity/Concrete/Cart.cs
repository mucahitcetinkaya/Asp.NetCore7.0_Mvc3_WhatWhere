namespace WhatWhere.Entity.Concrete
{
    public class Cart
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
        public List<CartItem> CartItems { get; set; }


        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDeleted { get; set; } = false;
    }
}
