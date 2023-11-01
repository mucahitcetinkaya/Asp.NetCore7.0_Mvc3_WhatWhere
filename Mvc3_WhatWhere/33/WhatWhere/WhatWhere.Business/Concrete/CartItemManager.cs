using WhatWhere.Business.Abstract;
using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Concrete
{
    public class CartItemManager : ICartItemService
    {
        private readonly ICartItemRepository _cartItemRepository;

        public CartItemManager(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task ChangeQuantityAsync(int cartItemId, int quantity)
        {
            var cart = await GetByIdAsync(cartItemId);
            await _cartItemRepository.ChangeQuantityAsync(cart, quantity);
        }

        public void ClearCart(int cartId)
        {
            _cartItemRepository.ClearCart(cartId);
        }

        public void Delete(CartItem item)
        {
            _cartItemRepository.Delete(item);
        }

        public async Task<CartItem> GetByIdAsync(int cartItemId)
        {
            return await _cartItemRepository.GetByIdAsync(cartItemId);
        }
    }
}
