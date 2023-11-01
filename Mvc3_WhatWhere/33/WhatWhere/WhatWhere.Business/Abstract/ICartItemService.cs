using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface ICartItemService
    {
        Task ChangeQuantityAsync(int cartItemId, int quantity);
        void ClearCart(int cartId);
        void Delete(CartItem item);
        Task<CartItem> GetByIdAsync(int cartItemId);
    }
}
