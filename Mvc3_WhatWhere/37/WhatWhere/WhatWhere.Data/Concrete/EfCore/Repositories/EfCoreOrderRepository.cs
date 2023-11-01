using Microsoft.EntityFrameworkCore;
using WhatWhere.Data.Abstract;
using WhatWhere.Data.Concrete.EfCore.Context;
using WhatWhere.Entity.ComplexTypes;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Repositories
{
    public class EfCoreOrderRepository : EfCoreGenericRepository<Order>, IOrderRepository
    {
        private readonly WhatWhereContext _context;

        public EfCoreOrderRepository(WhatWhereContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllOrdersAsync(string userId = null, bool dateSort = false, OrderStatus? orderStatus = null)
        {
            var result = _context
                .Orders
                .AsQueryable();
            if (!String.IsNullOrEmpty(userId))
            {
                result = result.Where(o => o.UserId == userId);
            }
            if (dateSort)
            {
                result = result.OrderByDescending(o => o.OrderDate);
            }
            else
            {
                result = result.OrderBy(o => o.OrderDate);
            }
            if (orderStatus != null)
            {
                result = result.Where(o => o.OrderStatus == orderStatus);
            }
            result = result
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.SaleMembership);
            return await result.ToListAsync();
        }

        public async Task<string> GetTotalAsync(int action)
        {
            var orders = await _context
                .Orders
                .Include(o => o.OrderItems)
                .ToListAsync();
            decimal? total = 0;
            int count = 0;
            int countMembers = 0;
            string result = "";
            foreach (var order in orders)
            {
                foreach (var item in order.OrderItems)
                {
                    if (action == 0)
                    {
                        total += item.Quantity * item.Price;
                        result = total.ToString();
                    }
                    else if (action == 1)
                    {
                        count++;
                        result = count.ToString();
                    }
                    else
                    {
                        countMembers += item.Quantity;
                        result = countMembers.ToString();
                    }

                }
            }
            return result;


            //var result = await AppContext
            //    .Orders
            //    .Include(o => o.OrderItems)
            //    .Select(o => o.OrderItems.Sum(oi => Convert.ToInt32(oi.Quantity) * Convert.ToInt32(oi.Price)))
            //    .SingleOrDefaultAsync();
            //return result;
        }
    }
}