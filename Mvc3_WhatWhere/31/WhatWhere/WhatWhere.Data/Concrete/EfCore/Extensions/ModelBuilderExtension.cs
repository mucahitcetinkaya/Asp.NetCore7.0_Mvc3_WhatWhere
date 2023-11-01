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
                new Role { Name="User", Description="Diğer tüm kullanıcıların rolü bu.", NormalizedName="USER"}
            };
            modelBuilder.Entity<Role>().HasData(roles);
            #endregion
            #region Kullanıcı Bilgileri
            List<User> users = new List<User>
            {
                new User
                {
                    FirstName="Deniz",
                    LastName="Foça",
                    UserName="admin",
                    NormalizedUserName="ADMIN",
                    Email="denizfoca@gmail.com",
                    NormalizedEmail="DENIZFOCA@GMAIL.COM",
                    Gender="Kadın",
                    DateOfBirth= new DateTime(1985,7,12),
                    Address="Kemalpaşa Mh. Zühtübey Sk. No:12 D:3 Üsküdar",
                    City="İstanbul",
                    EmailConfirmed=true,
                    SecurityStamp="",
                    LockoutEnabled=true
                },
                new User
                {
                    FirstName="Murat",
                    LastName="Kendirli",
                    UserName="user",
                    NormalizedUserName="USER",
                    Email="muratkendirli@gmail.com",
                    NormalizedEmail="MURATKENDIRLI@GMAIL.COM",
                    Gender="Erkek",
                    DateOfBirth= new DateTime(1983,9,10),
                    Address="Barbaros Bulvarı Feda İş Hanı K:5 D:23 Beşiktaş",
                    City="İstanbul",
                    EmailConfirmed=true,
                    SecurityStamp="",
                    LockoutEnabled=true
                }
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

            #endregion
        }
    }
}
