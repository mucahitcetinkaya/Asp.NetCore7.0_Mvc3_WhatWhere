using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Rol Bilgileri
            List<Role> roles = new List<Role>
            {
                new Role { Name="Admin", Description="Yöneticilerin rolü bu.", NormalizedName="ADMIN"},
                new Role { Name="User", Description="Diğer tüm kullanıcıların rolü bu.", NormalizedName="USER"},
                new Role { Name="Editor", Description="Diğer tüm kullanıcıların rolü bu.", NormalizedName="EDITOR"},
                new Role { Name="Normal", Description="Diğer tüm kullanıcıların rolü bu.", NormalizedName="NORMAL"},
                new Role { Name="Strict", Description="Diğer tüm kullanıcıların rolü bu.", NormalizedName="STRICT"}
            };
            modelBuilder.Entity<Role>().HasData(roles);
            #endregion
            #region Kullanıcı Bilgileri
            List<User> users = new List<User>
            {
                 new User
                {
                    FirstName="Mücahit",
                    LastName="Çetinkaya",
                    UserName="admin",
                    NormalizedUserName="ADMIN",
                    Email="mucahitcetinkaya@outlook.com",
                    NormalizedEmail="MUCAHITCETINKAYA@OUTLOOK.COM",
                    Gender="Male",
                    DateOfBirth= new DateTime(1994, 6, 13),
                    Address="Kadıköy",
                    City="İstanbul",
                    EmailConfirmed=true,
                    SecurityStamp="",
                    LockoutEnabled=true,
                    PhoneNumber="+901234567",
                    PhoneNumberConfirmed=true
                },
                new User
                {
                    FirstName = "Mehmet",
                    LastName = "Kaya",
                    UserName="user",
                    NormalizedUserName="USER",
                    Email="mehmetkaya@example.com",
                    NormalizedEmail="MEHMETKAYA@EXAMPLE.COM",
                    Gender="Male",
                    DateOfBirth= new DateTime(1992, 2, 02),
                    Address="Barbaros Bulvarı Feda İş Hanı K:5 D:23 Beşiktaş",
                    City="İstanbul",
                    EmailConfirmed=true,
                    SecurityStamp="",
                    LockoutEnabled=true,
                    PhoneNumber = "+901234567",
                    PhoneNumberConfirmed=true
                },
            };
            modelBuilder.Entity<User>().HasData(users);
            #endregion
            #region Şifre İşlemleri
            var passwordHasher = new PasswordHasher<User>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            #endregion
            #region Rol Atama İşlemleri
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>{ UserId=users[0].Id, RoleId=roles[0].Id },
                new IdentityUserRole<string>{ UserId=users[1].Id, RoleId=roles[1].Id }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion
            #region Alışveriş Sepeti İşlemleri
            List<Cart> carts = new List<Cart>
            {
                new Cart{ Id=1, UserId=users[0].Id},
                new Cart{ Id=2, UserId=users[1].Id}
            };
            modelBuilder.Entity<Cart>().HasData(carts);
            #endregion
        }
    }
}
