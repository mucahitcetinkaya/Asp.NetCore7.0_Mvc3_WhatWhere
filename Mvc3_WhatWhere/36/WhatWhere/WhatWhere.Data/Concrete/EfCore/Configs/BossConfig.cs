using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Configs
{
    public class BossConfig : IEntityTypeConfiguration<Boss>
    {
        public void Configure(EntityTypeBuilder<Boss> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);

            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);

            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(10);

            builder.HasData
            (
                new Boss()
                {
                    Id = 1,
                    FirstName = "Mücahit",
                    LastName = "Çetinkaya",
                    Gender = "Male",
                    BirthOfYear = new DateTime(1994, 6, 13),
                    PhoneNumber = "+901234567",
                    MailAdress = "mucahitcetinkaya@outlook.com",
                    Url = "www.mucahitcetinkaya.com",
                },
                new Boss()
                {
                    Id = 2,
                    FirstName = "Mehmet",
                    LastName = "Kaya",
                    Gender = "Male",
                    BirthOfYear = new DateTime(1992, 2, 02),
                    PhoneNumber = "+901234567",
                    MailAdress = "mehmetkaya@example.com",
                    Url = "www.mehmetkaya.com"
                },
                new Boss()
                {
                    Id = 3,
                    FirstName = "Ayşe",
                    LastName = "Demir",
                    Gender = "Female",
                    BirthOfYear = new DateTime(1993, 3, 03),
                    PhoneNumber = "+901234567",
                    MailAdress = "aysedemir@example.com",
                    Url = "www.aysedemir.com"
                },
                new Boss()
                {
                    Id = 4,
                    FirstName = "Fatma",
                    LastName = "Yıldırım",
                    Gender = "Female",
                    BirthOfYear = new DateTime(1994, 4, 04),
                    PhoneNumber = "+901234567",
                    MailAdress = "fatmayildirim@example.com",
                    Url = "www.fatmayildirim.com"
                },
                new Boss()
                {
                    Id = 5,
                    FirstName = "Ali",
                    LastName = "Öztürk",
                    Gender = "Male",
                    BirthOfYear = new DateTime(1995, 5, 05),
                    PhoneNumber = "+901234567",
                    MailAdress = "aliozturk@example.com",
                    Url = "www.aliozturk.com"
                },
                new Boss()
                {
                    Id = 6,
                    FirstName = "Zeynep",
                    LastName = "Aktaş",
                    Gender = "Female",
                    BirthOfYear = new DateTime(1996, 6, 06),
                    PhoneNumber = "+901234567",
                    MailAdress = "zeynepaktas@example.com",
                    Url = "www.zeynepaktas.com"
                },
                new Boss()
                {
                    Id = 7,
                    FirstName = "Hakan",
                    LastName = "Koç",
                    Gender = "Male",
                    BirthOfYear = new DateTime(1997, 7, 07),
                    PhoneNumber = "+901234567",
                    MailAdress = "hakankoc@example.com",
                    Url = "www.hakankoc.com"
                },
                new Boss()
                {
                    Id = 8,
                    FirstName = "Selin",
                    LastName = "Can",
                    Gender = "Female",
                    BirthOfYear = new DateTime(1998, 8, 08),
                    PhoneNumber = "+901234567",
                    MailAdress = "selincan@example.com",
                    Url = "www.selincan.com"
                },
                new Boss()
                {
                    Id = 9,
                    FirstName = "Murat",
                    LastName = "Şahin",
                    Gender = "Male",
                    BirthOfYear = new DateTime(1999, 9, 09),
                    PhoneNumber = "+901234567",
                    MailAdress = "muratsahin@example.com",
                    Url = "www.muratsahin.com"
                },
                new Boss()
                {
                    Id = 10,
                    FirstName = "Deniz",
                    LastName = "Arslan",
                    Gender = "Female",
                    BirthOfYear = new DateTime(2000, 1, 01),
                    PhoneNumber = "+901234567",
                    MailAdress = "denizarslan@example.com",
                    Url = "www.denizarslan.com"
                }
            );
        }
    }

}
