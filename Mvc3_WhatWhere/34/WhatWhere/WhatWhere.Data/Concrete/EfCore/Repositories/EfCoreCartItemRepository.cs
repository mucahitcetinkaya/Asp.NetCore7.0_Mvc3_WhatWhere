using Microsoft.EntityFrameworkCore;
using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCartItemRepository : EfCoreGenericRepository<CartItem>, ICartItemRepository
    {

        private readonly WhatWhereContext _context;

        public EfCoreCartItemRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public async Task ChangeQuantityAsync(CartItem item, int quantity)
        {
            item.Quantity = quantity;
            _context.CartItems.Update(item);
            await _context.SaveChangesAsync();
        }

        public void ClearCart(int cartId)
        {
            _context
                .CartItems
                .Where(ci => ci.CartId == cartId)
                .ExecuteDelete();
        }
    }
}
