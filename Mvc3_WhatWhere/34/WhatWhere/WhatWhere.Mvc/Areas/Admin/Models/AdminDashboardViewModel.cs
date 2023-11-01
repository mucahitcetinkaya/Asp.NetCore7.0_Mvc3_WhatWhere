using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Areas.Admin.Models
{
    public class AdminDashboardViewModel
    {
        public decimal? TotalSalesAmount { get; set; }
        public int TotalSalesCount { get; set; }
        public int TotalMemberSalesCount { get; set; }
        public List<OrderViewModel> ReceivedOrders { get; set; }
        public List<OrderViewModel> PreparingOrders { get; set; }
        public List<OrderViewModel> SentOrders { get; set; }
        public List<OrderViewModel> DeliveredOrders { get; set; }
    }
}