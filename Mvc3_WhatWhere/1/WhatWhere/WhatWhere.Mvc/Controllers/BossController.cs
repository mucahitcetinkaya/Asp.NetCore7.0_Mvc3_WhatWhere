using Microsoft.AspNetCore.Mvc;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Controllers
{
    public class BossController : Controller
    {
        public IActionResult Index()
        {
            var bossList = new List<Boss>()
            {
                new Boss()
                {
                    Id = 1,
                    FirstName = "Ahmet",
                    LastName = "Yılmaz",
                    Gender = "Male",
                    BirthOfYear = 1990,
                    PhoneNumber = "1234567890",
                    MailAdress = "ahmet@example.com",
                    Url = "ahmet-yilmaz.com",
                },
                new Boss()
                {
                    Id = 2,
                    FirstName = "Mehmet",
                    LastName = "Kaya",
                    Gender = "Male",
                    BirthOfYear = 1985,
                    PhoneNumber = "1234567890",
                    MailAdress = "mehmet@example.com",
                    Url = "mehmet-kaya.com"
                },
                new Boss()
                {
                    Id = 3,
                    FirstName = "Ayşe",
                    LastName = "Demir",
                    Gender = "Female",
                    BirthOfYear = 1992,
                    PhoneNumber = "1234567890",
                    MailAdress = "ayse@example.com",
                    Url = "ayse-demir.com"
                },
                new Boss()
                {
                    Id = 4,
                    FirstName = "Fatma",
                    LastName = "Yıldırım",
                    Gender = "Female",
                    BirthOfYear = 1988,
                    PhoneNumber = "1234567890",
                    MailAdress = "fatma@example.com",
                    Url = "fatma-yildirim.com"
                },
                new Boss()
                {
                    Id = 5,
                    FirstName = "Ali",
                    LastName = "Öztürk",
                    Gender = "Male",
                    BirthOfYear = 1995,
                    PhoneNumber = "1234567890",
                    MailAdress = "ali@example.com",
                    Url = "ali-ozturk.com"
                },
                new Boss()
                {
                    Id = 6,
                    FirstName = "Zeynep",
                    LastName = "Aktaş",
                    Gender = "Female",
                    BirthOfYear = 1991,
                    PhoneNumber = "1234567890",
                    MailAdress = "zeynep@example.com",
                    Url = "zeynep-aktas.com"
                },
                new Boss()
                {
                    Id = 7,
                    FirstName = "Hakan",
                    LastName = "Koç",
                    Gender = "Male",
                    BirthOfYear = 1987,
                    PhoneNumber = "1234567890",
                    MailAdress = "hakan@example.com",
                    Url = "hakan-koc.com"
                },
                new Boss()
                {
                    Id = 8,
                    FirstName = "Selin",
                    LastName = "Can",
                    Gender = "Female",
                    BirthOfYear = 1994,
                    PhoneNumber = "1234567890",
                    MailAdress = "selin@example.com",
                    Url = "selin-can.com"
                },
                new Boss()
                {
                    Id = 9,
                    FirstName = "Murat",
                    LastName = "Şahin",
                    Gender = "Male",
                    BirthOfYear = 1989,
                    PhoneNumber = "1234567890",
                    MailAdress = "murat@example.com",
                    Url = "murat-sahin.com"
                },
                new Boss()
                {
                    Id = 10,
                    FirstName = "Deniz",
                    LastName = "Arslan",
                    Gender = "Female",
                    BirthOfYear = 1993,
                    PhoneNumber = "1234567890",
                    MailAdress = "deniz@example.com",
                    Url = "deniz-arslan.com"
                }
            };
            return View("Index", bossList);
        }
    }
}

