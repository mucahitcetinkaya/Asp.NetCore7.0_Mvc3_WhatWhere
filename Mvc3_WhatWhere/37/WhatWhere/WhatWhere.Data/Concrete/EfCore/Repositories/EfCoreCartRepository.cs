using Microsoft.EntityFrameworkCore;
using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart>, ICartRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreCartRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddToCartAsync(string userId, int saleMembershipId, int quantity)
        {
            var cart = await GetCartByUserId(userId);
            if (cart != null)
            {
                var index = cart.CartItems.FindIndex(ci => ci.SaleMembershipId == saleMembershipId);
                if (index < 0)//Üyelik daha önceden sepete eklenmemişse
                {
                    cart.CartItems.Add(new CartItem
                    {
                        SaleMembershipId = saleMembershipId,
                        CartId = cart.Id,
                        Quantity = quantity
                    });
                }
                else //Eğer Üyelik daha önceden sepete eklenmişse -- adedi arttıracağız
                {
                    cart.CartItems[index].Quantity += quantity;
                }

                _context.Carts.Update(cart);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cart> GetCartByUserId(string userId)
        {
            var result = await _context
                .Carts
                .Where(c => c.UserId == userId)
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.SaleMembership)
                .FirstOrDefaultAsync();
            return result;
        }
    }
}
