using System.ComponentModel.DataAnnotations;

namespace WhatWhere.Mvc.Models
{
    public class CartViewModel
    {
        public int CartId { get; set; }
        public List<CartItemViewModel> CartItems { get; set; }
        public decimal? TotalPrice()
        {
            return CartItems.Sum(ci => ci.Price * ci.Quantity);
        }
    }
    public class CartItemViewModel
    {
        public int CartItemId { get; set; }
        public int SaleMembershipId { get; set; }
        public string SaleMembershipName { get; set; }
        public string SaleMembershipImageUrl { get; set; }
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Boş bırakılmalalıdır.")]
        public int Quantity { get; set; }
    }
}
