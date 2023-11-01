using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICartService
    {
        Task InitializeCart(string userId);
        Task AddToCartAsync(string userId, int saleMembershipId, int quantity);
        Task<Cart> GetByIdAsync(int id);
        Task<Cart> GetCartByUserId(string id);
        Task DeleteAsync(string userId);
    }
}
