using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.ComplexTypes;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Models;
using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay;

namespace WhatWhere.Mvc.Controllers
{
    [Authorize(Roles = "Admin, User")]
    public class CartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICartService _cartManager;
        private readonly ICartItemService _cartItemManager;
        private readonly IOrderService _orderManager;
        private readonly INotyfService _notyf;

        public CartController(UserManager<User> userManager, ICartService cartManager, INotyfService notyf, ICartItemService cartItemManager, IOrderService orderManager)
        {
            _userManager = userManager;
            _cartManager = cartManager;
            _notyf = notyf;
            _cartItemManager = cartItemManager;
            _orderManager = orderManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var cart = await _cartManager.GetCartByUserId(userId);
            CartViewModel model = new CartViewModel
            {
                CartId = cart.Id,
                CartItems = cart.CartItems
                    .Select(sm => new CartItemViewModel
                    {
                        CartItemId = sm.Id,
                        SaleMembershipId = sm.SaleMembership.Id,
                        SaleMembershipName = sm.SaleMembership.Name,
                        SaleMembershipImageUrl = sm.SaleMembership.ImageUrl,
                        Price = sm.SaleMembership.Price,
                        Quantity = sm.Quantity
                    }).ToList()
            };
            return View(model);
        }
        public async Task<IActionResult> AddToCart(int saleMembershipId, int quantity)
        {
            var userId = _userManager.GetUserId(User);
            await _cartManager.AddToCartAsync(userId, saleMembershipId, quantity);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> ChangeQuantity(int cartItemId, int quantity)
        {
            if (ModelState.IsValid)
            {
                await _cartItemManager.ChangeQuantityAsync(cartItemId, quantity);
            }
            else
            {
                _notyf.Warning("Lütfen adedi boş bırakmayınız");
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteItemFromCart(int id)
        {
            var cartItem = await _cartItemManager.GetByIdAsync(id);
            _cartItemManager.Delete(cartItem);
            _notyf.Success("Üyelik sepetinizden silindi");
            return RedirectToAction("Index");
        }
        public IActionResult ClearCart(int id)
        {
            _cartItemManager.ClearCart(id);
            _notyf.Success("Sepetiniz boşaltılmıştır.");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Checkout()
        {
            string userId = _userManager.GetUserId(User);
            User user = await _userManager.FindByIdAsync(userId);
            Cart cart = await _cartManager.GetCartByUserId(userId);
            OrderViewModel model = new OrderViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                City = user.City,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Cart = new CartViewModel
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(sm => new CartItemViewModel
                    {
                        CartItemId = sm.Id,
                        SaleMembershipId = sm.SaleMembershipId,
                        SaleMembershipName = sm.SaleMembership.Name,
                        SaleMembershipImageUrl = sm.SaleMembership.ImageUrl,
                        Price = sm.SaleMembership.Price,
                        Quantity = sm.Quantity

                    }).ToList()
                },
                CardName = "Alex de Souza",
                CardNumber = "5890040000000016",
                ExpirationYear = "2028",
                ExpirationMonth = "10",
                Cvc = "123"
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Checkout(OrderViewModel model)
        {
            string userId = _userManager.GetUserId(User);
            Cart cart = await _cartManager.GetCartByUserId(userId);
            if (ModelState.IsValid)
            {
                model.Cart = new CartViewModel
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(sm => new CartItemViewModel
                    {
                        CartItemId = sm.Id,
                        SaleMembershipId = sm.SaleMembershipId,
                        SaleMembershipName = sm.SaleMembership.Name,
                        SaleMembershipImageUrl = sm.SaleMembership.ImageUrl,
                        Price = sm.SaleMembership.Price,
                        Quantity = sm.Quantity
                    }).ToList()
                };
                Payment payment = PaymentProcess(model);
                if (payment.Status == "success")
                {
                    await SaveOrder(model, userId);
                    _cartItemManager.ClearCart(model.Cart.CartId);
                    _notyf.Success("Ödeme işlemi başarıyla tamamlanmıştır");
                    return RedirectToAction("Index", "Home");
                }
                _notyf.Error("Bir hata oluştu");
            }

            return View();
        }
        [NonAction]
        private Payment PaymentProcess(OrderViewModel model)
        {
            #region Options
            
            Options options = new Options();
            options.ApiKey = "sandbox-313Mg6w05g35vEZZXgG5dL5YW6LiUGJl";
            options.SecretKey = "sandbox-tkue5CZOz5usUARA3DmXPQAVnbJkcXx5";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";
            #endregion
            #region Request
            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.Price = Convert.ToInt32(model.Cart.TotalPrice()).ToString();
            request.PaidPrice = Convert.ToInt32(model.Cart.TotalPrice()).ToString();
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = model.Cart.CartId.ToString();
            request.PaymentChannel = PaymentChannel.MOBILE_WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();
            #region PaymentCard
            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = model.CardName;
            paymentCard.CardNumber = model.CardNumber;
            paymentCard.ExpireMonth = model.ExpirationMonth;
            paymentCard.ExpireYear = model.ExpirationYear;
            paymentCard.Cvc = model.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;
            #endregion
            #region Buyer
            Buyer buyer = new Buyer();
            buyer.Id = "12345";
            buyer.Name = model.FirstName;
            buyer.Surname = model.LastName;
            buyer.GsmNumber = model.PhoneNumber;
            buyer.Email = model.Email;
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = model.Address;
            buyer.Ip = "85.34.78.112";
            buyer.City = model.City;
            buyer.Country = "Turkey";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;
            #endregion
            #region Addresses
            Address shippingAddress = new Address();
            shippingAddress.ContactName = model.FirstName + " " + model.LastName;
            shippingAddress.City = model.City;
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = model.Address;
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = model.FirstName + " " + model.LastName;
            billingAddress.City = model.City;
            billingAddress.Country = "Turkey";
            billingAddress.Description = model.Address;
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;
            #endregion
            #region Basket Items
            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem;
            foreach (var item in model.Cart.CartItems)
            {
                basketItem = new BasketItem();
                basketItem.Id = item.CartItemId.ToString();
                basketItem.Name = item.SaleMembershipName;
                basketItem.Category1 = "Uyelik";
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItem.Price = Convert.ToInt32(item.Price * item.Quantity).ToString();
                basketItems.Add(basketItem);
            }
            request.BasketItems = basketItems;
            #endregion
            #endregion
            Payment payment = Payment.Create(request, options);
            return payment;
        }
        [NonAction]
        private async Task SaveOrder(OrderViewModel model, string userId)
        {
            Order order = new Order();
            order.UserId = userId;
            order.OrderStatus = OrderStatus.Received;
            order.OrderType = OrderType.CreditCart;
            order.OrderDate = DateTime.Now;
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.PhoneNumber = model.PhoneNumber;
            order.Email = model.Email;
            order.Address = model.Address;
            order.City = model.City;
            order.OrderItems = new List<Entity.Concrete.OrderItem>();
            Entity.Concrete.OrderItem orderItem;
            foreach (var item in model.Cart.CartItems)
            {
                orderItem = new Entity.Concrete.OrderItem();
                orderItem.Price = item.Price;
                orderItem.Quantity = item.Quantity;
                orderItem.SaleMembershipId = item.SaleMembershipId;
                order.OrderItems.Add(orderItem);
            }
            await _orderManager.CreateAsync(order);
        }
    }
}