using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Configs
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Sehir).IsRequired();

            builder.HasMany(c => c.Towns)
                   .WithOne(t => t.City)
                   .HasForeignKey(t => t.CityId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasData
            (
                new City { Id = 1, Sehir = "Adana" },
                new City { Id = 2, Sehir = "Adıyaman" },
                new City { Id = 3, Sehir = "Afyonkarahisar" },
                new City { Id = 4, Sehir = "Ağrı" },
                new City { Id = 5, Sehir = "Amasya" },
                new City { Id = 6, Sehir = "Ankara" },
                new City { Id = 7, Sehir = "Antalya" },
                new City { Id = 8, Sehir = "Artvin" },
                new City { Id = 9, Sehir = "Aydın" },
                new City { Id = 10, Sehir = "Balıkesir" },
                new City { Id = 11, Sehir = "Bilecik" },
                new City { Id = 12, Sehir = "Bingöl" },
                new City { Id = 13, Sehir = "Bitlis" },
                new City { Id = 14, Sehir = "Bolu" },
                new City { Id = 15, Sehir = "Burdur" },
                new City { Id = 16, Sehir = "Bursa" },
                new City { Id = 17, Sehir = "Çanakkale" },
                new City { Id = 18, Sehir = "Çankırı" },
                new City { Id = 19, Sehir = "Çorum" },
                new City { Id = 20, Sehir = "Denizli" },
                new City { Id = 21, Sehir = "Diyarbakır" },
                new City { Id = 22, Sehir = "Edirne" },
                new City { Id = 23, Sehir = "Elazığ" },
                new City { Id = 24, Sehir = "Erzincan" },
                new City { Id = 25, Sehir = "Erzurum" },
                new City { Id = 26, Sehir = "Eskişehir" },
                new City { Id = 27, Sehir = "Gaziantep" },
                new City { Id = 28, Sehir = "Giresun" },
                new City { Id = 29, Sehir = "Gümüşhane" },
                new City { Id = 30, Sehir = "Hakkari" },
                new City { Id = 31, Sehir = "Hatay" },
                new City { Id = 32, Sehir = "Isparta" },
                new City { Id = 33, Sehir = "Mersin" },
                new City { Id = 34, Sehir = "İstanbul" },
                new City { Id = 35, Sehir = "İzmir" },
                new City { Id = 36, Sehir = "Kars" },
                new City { Id = 37, Sehir = "Kastamonu" },
                new City { Id = 38, Sehir = "Kayseri" },
                new City { Id = 39, Sehir = "Kırklareli" },
                new City { Id = 40, Sehir = "Kırşehir" },
                new City { Id = 41, Sehir = "Kocaeli" },
                new City { Id = 42, Sehir = "Konya" },
                new City { Id = 43, Sehir = "Kütahya" },
                new City { Id = 44, Sehir = "Malatya" },
                new City { Id = 45, Sehir = "Manisa" },
                new City { Id = 46, Sehir = "Kahramanmaraş" },
                new City { Id = 47, Sehir = "Mardin" },
                new City { Id = 48, Sehir = "Muğla" },
                new City { Id = 49, Sehir = "Muş" },
                new City { Id = 50, Sehir = "Nevşehir" },
                new City { Id = 51, Sehir = "Niğde" },
                new City { Id = 52, Sehir = "Ordu" },
                new City { Id = 53, Sehir = "Rize" },
                new City { Id = 54, Sehir = "Sakarya" },
                new City { Id = 55, Sehir = "Samsun" },
                new City { Id = 56, Sehir = "Siirt" },
                new City { Id = 57, Sehir = "Sinop" },
                new City { Id = 58, Sehir = "Sivas" },
                new City { Id = 59, Sehir = "Tekirdağ" },
                new City { Id = 60, Sehir = "Tokat" },
                new City { Id = 61, Sehir = "Trabzon" },
                new City { Id = 62, Sehir = "Tunceli" },
                new City { Id = 63, Sehir = "Şanlıurfa" },
                new City { Id = 64, Sehir = "Uşak" },
                new City { Id = 65, Sehir = "Van" },
                new City { Id = 66, Sehir = "Yozgat" },
                new City { Id = 67, Sehir = "Zonguldak" },
                new City { Id = 68, Sehir = "Aksaray" },
                new City { Id = 69, Sehir = "Bayburt" },
                new City { Id = 70, Sehir = "Karaman" },
                new City { Id = 71, Sehir = "Kırıkkale" },
                new City { Id = 72, Sehir = "Batman" },
                new City { Id = 73, Sehir = "Şırnak" },
                new City { Id = 74, Sehir = "Bartın" },
                new City { Id = 75, Sehir = "Ardahan" },
                new City { Id = 76, Sehir = "Iğdır" },
                new City { Id = 77, Sehir = "Yalova" },
                new City { Id = 78, Sehir = "Karabük" },
                new City { Id = 79, Sehir = "Kilis" },
                new City { Id = 80, Sehir = "Osmaniye" },
                new City { Id = 81, Sehir = "Düzce" }
             );
        }
    }
}
