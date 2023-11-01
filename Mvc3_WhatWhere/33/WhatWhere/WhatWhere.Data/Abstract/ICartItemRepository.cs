using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface ICartItemRepository : IGenericRepository<CartItem>
    {
        Task ChangeQuantityAsync(CartItem item, int quantity);
        void ClearCart(int cartId);
    }
}
