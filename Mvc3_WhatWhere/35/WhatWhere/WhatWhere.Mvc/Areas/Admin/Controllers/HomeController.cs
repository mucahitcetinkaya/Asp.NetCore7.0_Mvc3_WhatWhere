using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WhatWhere.Business.Abstract;
using WhatWhere.Entity.ComplexTypes;
using WhatWhere.Entity.Concrete;
using WhatWhere.Mvc.Areas.Admin.Models;
using WhatWhere.Mvc.Models;
using WhatWhere.MVC.Extensions;

namespace WhatWhere.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly IOrderService _orderManager;
        private readonly ICartService _cartManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly INotyfService _notyf;

        public HomeController(IOrderService orderManager, UserManager<User> userManager, INotyfService notyf, ICartService cartManager, RoleManager<Role> roleManager)
        {
            _orderManager = orderManager;
            _userManager = userManager;
            _notyf = notyf;
            _cartManager = cartManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var totalSalesAmount = await _orderManager.GetTotalAsync(0);
            var totalSalesCount = await _orderManager.GetTotalAsync(1);
            var totalMemberSalesCount = await _orderManager.GetTotalAsync(2);
            AdminDashboardViewModel model = new AdminDashboardViewModel
            {
                TotalSalesAmount = totalSalesAmount == "" ? 0 : Convert.ToDecimal(totalSalesAmount),
                TotalSalesCount = totalSalesCount == "" ? 0 : Convert.ToInt32(totalSalesCount),
                TotalMemberSalesCount = totalMemberSalesCount == "" ? 0 : Convert.ToInt32(totalMemberSalesCount)
            };
            List<Order> receivedOrderList = await _orderManager.GetAllOrdersAsync(null, true, OrderStatus.Received);
            List<OrderViewModel> receivedOrders = receivedOrderList.Select(o => new OrderViewModel
            {
                Id = o.Id,
                FirstName = o.FirstName,
                LastName = o.LastName,
                City = o.City,
                Address = o.Address,
                PhoneNumber = o.PhoneNumber,
                Email = o.Email,
                OrderDate = o.OrderDate,
                OrderItems = o.OrderItems,
                OrderStatus = o.OrderStatus.GetDisplayName()
            }).ToList();
            model.ReceivedOrders = receivedOrders;

            List<Order> preparingOrderList = await _orderManager.GetAllOrdersAsync(null, true, OrderStatus.Preparing);
            List<OrderViewModel> preparingOrders = preparingOrderList.Select(o => new OrderViewModel
            {
                Id = o.Id,
                FirstName = o.FirstName,
                LastName = o.LastName,
                City = o.City,
                Address = o.Address,
                PhoneNumber = o.PhoneNumber,
                Email = o.Email,
                OrderDate = o.OrderDate,
                OrderItems = o.OrderItems,
                OrderStatus = o.OrderStatus.GetDisplayName()
            }).ToList();
            model.PreparingOrders = preparingOrders;


            return View(model);
        }
        #region User İşlemleri

        public async Task<IActionResult> UserList()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }
        public async Task<IActionResult> UserDelete(string id)
        {
            //Silinecek User bilgisini buluyoruz
            User user = await _userManager.FindByIdAsync(id);

            //Silinecek User'a atanan rolü kaldırıyoruz.
            await _userManager.RemoveFromRoleAsync(user, "User");

            //Silinecek User'ın Sepetini siliyoruz.
            await _cartManager.DeleteAsync(user.Id);

            //Şimdi de User'ı silebiliriz.
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                _notyf.Success($"{user.UserName} kullanıcı adlı kullanıcı silinmiştir.");
            }
            else
            {
                _notyf.Error("Silme işlemi sırasında bir sorun oluştu");
            }
            return RedirectToAction("UserList");
        }
        public async Task<IActionResult> ConfirmEmail(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            user.EmailConfirmed = !user.EmailConfirmed;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("UserList");
        }
        [HttpGet]
        public async Task<IActionResult> UserEdit(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            UserUpdateViewModel model = new UserUpdateViewModel
            {
                User = user,
                SelectedRoles = await _userManager.GetRolesAsync(user),
                Roles = await _roleManager.Roles.ToListAsync()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UserEdit(UserUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByIdAsync(model.User.Id);
                user.UserName = model.User.UserName;
                user.FirstName = model.User.FirstName;
                user.LastName = model.User.LastName;
                user.Address = model.User.Address;
                user.EmailConfirmed = model.User.EmailConfirmed;
                await _userManager.UpdateAsync(user);

                //Şimdi de rol güncellemesi
                var userRoles = await _userManager.GetRolesAsync(user);

                //Rol ata(daha önceden var olan rollere karışma)
                await _userManager.AddToRolesAsync(user, model.SelectedRoles.Except(userRoles).ToList<string>());

                //Rol çıkar((hariç olanlar)
                await _userManager.RemoveFromRolesAsync(user, userRoles.Except(model.SelectedRoles).ToList<string>());
                _notyf.Success("Kullanıcı bilgileri başarıyla güncellenemiştir.");
                return RedirectToAction("UserList");
            }

            return View(model);
        }

        #endregion

        #region Role İşlemleri

        public async Task<IActionResult> RoleList()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> RoleEdit(string id)
        {
            Role role = await _roleManager.FindByIdAsync(id);
            var users = await _userManager.Users.ToListAsync();
            var members = new List<User>();
            var nonMembers = new List<User>();
            List<User> list = new List<User>();
            foreach (var user in users)
            {
                list = await _userManager.IsInRoleAsync(user, role.Name) ? members : nonMembers;
                list.Add(user);
            }
            RoleUpdateViewModel model = new RoleUpdateViewModel
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers,
                UpdateAll = TempData["UpdateAll"] == null ? true : (bool)TempData["UpdateAll"]
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleUpdateViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Role.Id);
            //İlgili role atanacak olan userlarla ilgili işlemler
            foreach (var userId in model.IdsToAdd ?? new string[] { })
            {
                User user = await _userManager.FindByIdAsync(userId);
                var result = await _userManager.AddToRoleAsync(user, role.Name);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", "Bir hata oluştu");
                    }
                }
            }
            //İlgili rolden çıkarılacak olan userlarla ilgili işlemler
            foreach (var userId in model.IdsFromRemove ?? new string[] { })
            {
                User user = await _userManager.FindByIdAsync(userId);
                var result = await _userManager.RemoveFromRoleAsync(user ?? new User(), role.Name);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            TempData["UpdateAll"] = model.UpdateAll;
            return Redirect($"/Admin/Home/RoleEdit/{role.Id}");
        }
        #endregion
    }
}