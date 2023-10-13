using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Configs
{
    public class SaleMembershipConfig : IEntityTypeConfiguration<SaleMembership>
    {
        public void Configure(EntityTypeBuilder<SaleMembership> builder)
        {
           builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.ImageUrl).IsRequired();

            builder.HasData
            (
                new SaleMembership()
                {
                    Id = 1,
                    Name = "1 Aylık Üyelik",
                    Description = "1 Aylık üyelik ücretsizdir. Birinci ay sonunda hesaplar pasif olur.",
                    Price = "0$",
                    ImageUrl = "aylik-uyelik-1.jpg"
                },
                new SaleMembership()
                {
                    Id = 2,
                    Name = "2 Aylık Üyelik",
                    Description = "2 Aylık üyelik. İkinci ay sonunda hesaplar pasif olur.",
                    Price = "20$",
                    ImageUrl = "aylik-uyelik-2.jpg"
                },
                new SaleMembership()
                {
                    Id = 3,
                    Name = "3 Aylık Üyelik",
                    Description = "3 Aylık üyelik. Üçüncü ay sonunda hesaplar pasif olur.",
                    Price = "30$",
                    ImageUrl = "aylik-uyelik-3.jpg"
                },
                new SaleMembership()
                {
                    Id = 4,
                    Name = "4 Aylık Üyelik",
                    Description = "4 Aylık üyelik. Dördüncü ay sonunda hesaplar pasif olur.",
                    Price = "40$",
                    ImageUrl = "aylik-uyelik-4.jpg"
                },
                new SaleMembership()
                {
                    Id = 5,
                    Name = "5 Aylık Üyelik",
                    Description = "5 Aylık üyelik. Beşinci ay sonunda hesaplar pasif olur.",
                    Price = "50$",
                    ImageUrl = "aylik-uyelik-5.jpg"
                },
                new SaleMembership()
                {
                    Id = 6,
                    Name = "6 Aylık Üyelik",
                    Description = "6 Aylık üyelik. Altıncı ay sonunda hesaplar pasif olur.",
                    Price = "60$",
                    ImageUrl = "aylik-uyelik-6.jpg"
                },
                new SaleMembership()
                {
                    Id = 7,
                    Name = "7 Aylık Üyelik",
                    Description = "7 Aylık üyelik. Yedinci ay sonunda hesaplar pasif olur.",
                    Price = "70$",
                    ImageUrl = "aylik-uyelik-7.jpg"
                },
                new SaleMembership()
                {
                    Id = 8,
                    Name = "8 Aylık Üyelik",
                    Description = "8 Aylık üyelik. Sekizinci ay sonunda hesaplar pasif olur.",
                    Price = "80$",
                    ImageUrl = "aylik-uyelik-8.jpg"
                },
                new SaleMembership()
                {
                    Id = 9,
                    Name = "9 Aylık Üyelik",
                    Description = "9 Aylık üyelik. Dokuzuncu ay sonunda hesaplar pasif olur.",
                    Price = "90$",
                    ImageUrl = "aylik-uyelik-9.jpg"
                },
                new SaleMembership()
                {
                    Id = 10,
                    Name = "10 Aylık Üyelik",
                    Description = "10 Aylık üyelik. Onuncu ay sonunda hesaplar pasif olur.",
                    Price = "100$",
                    ImageUrl = "aylik-uyelik-10.jpg"
                },
                new SaleMembership()
                {
                    Id = 11,
                    Name = "11 Aylık Üyelik",
                    Description = "11 Aylık üyelik. Onbirinci ay sonunda hesaplar pasif olur.",
                    Price = "110$",
                    ImageUrl = "aylik-uyelik-11.jpg"
                },
                new SaleMembership()
                {
                    Id = 12,
                    Name = "12 Aylık Üyelik",
                    Description = "12 Aylık üyelik. Onikinci ay sonunda hesaplar pasif olur.",
                    Price = "120$",
                    ImageUrl = "aylik-uyelik-12.jpg"
                }
            );
        }
    }
}