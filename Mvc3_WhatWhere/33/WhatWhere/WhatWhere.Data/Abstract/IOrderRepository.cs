using WhatWhere.Entity.ComplexTypes;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Abstract
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<List<Order>> GetAllOrdersAsync(string userId = null, bool dateSort = false, OrderStatus? orderStatus = null);
        Task<string> GetTotalAsync(int action);

    }
}
