using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        Task<Cart> GetCartByUserId(string userId);
        Task AddToCartAsync(string userId, int saleMembershipId, int quantity);
    }
}
