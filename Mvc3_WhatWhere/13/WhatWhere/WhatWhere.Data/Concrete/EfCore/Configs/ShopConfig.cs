using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Configs
{
    public class ShopConfig : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.Property(s => s.PhoneNumber).IsRequired().HasMaxLength(10);

            builder.HasOne(s => s.Boss)
                   .WithMany(b => b.Shops)
                   .HasForeignKey(s => s.BossId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(s => s.Category)
                    .WithMany(c => c.Shops)
                    .HasForeignKey(s => s.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.City)
                   .WithMany(b => b.Shops)
                   .HasForeignKey(s => s.CityId)
                   .OnDelete(DeleteBehavior.SetNull);

            // Town ile ilişkilendirme
            builder.HasOne(s => s.Town)
                  .WithMany(b => b.Shops)
                  .HasForeignKey(s => s.TownId)
                  .OnDelete(DeleteBehavior.SetNull);

            // Category ile ilişkilendirme
            builder.HasOne(s => s.Category)
                   .WithMany(c => c.Shops)
                   .HasForeignKey(s => s.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);


            builder.HasData
            (
                new Shop()
                {
                    Id = 1,
                    Name = "Özgün Kasap",
                    Description = "Lezzetli et ürünleriyle hizmet veren kasap dükkanı.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@kasap.com",
                    Url = "www.kasap.com",

                    ImageUrl = "kasap.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 1,
                    CategoryId = 1,
                    CityId = 34,
                    TownId = 455

                },
                new Shop()
                {
                    Id = 2,
                    Name = "Namık Eczanesi",
                    Description = "Sağlık ürünleri ve ilaçların bulunduğu eczane.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@eczane.com",
                    Url = "www.eczane.com",

                    ImageUrl = "eczane.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,

                    BossId = 2,
                    CategoryId = 2,
                    CityId = 34,
                    TownId = 432

                },
                new Shop()
                {
                    Id = 3,
                    Name = "Ozan Kırtasiyesi",
                    Description = "Kalemlerden defterlere, kırtasiye malzemelerinin satıldığı dükkân.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@kirtasiye.com",
                    Url = "www.kirtasiye.com",

                    ImageUrl = "kirtasiye.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 3,
                    CategoryId = 3,
                    CityId = 34,
                    TownId = 438

                },
                new Shop()
                {
                    Id = 4,
                    Name = "Neşe Terzi",
                    Description = "Kıyafet tamiratı ve dikimi yapan terzi dükkânı.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@terzi.com",
                    Url = "www.terzi.com",

                    ImageUrl = "terzi.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,

                    BossId = 4,
                    CategoryId = 4,
                    CityId = 34,
                    TownId = 425

                },
                new Shop()
                {
                    Id = 5,
                    Name = "İtina Dişçi",
                    Description = "Diş sağlığı hizmetleri sunan dişçi kliniği.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@disci.com",
                    Url = "www.disci.com",

                    ImageUrl = "disci.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 5,
                    CategoryId = 5,
                    CityId = 34,
                    TownId = 425

                },
                new Shop()
                {
                    Id = 6,
                    Name = "Prof Kiralık Katil",
                    Description = "Profesyonel hizmetlerle kiralık katil işleri yapan gizli dükkân.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@kiralik-katil.com",
                    Url = "www.kiralik-katil.com",

                    ImageUrl = "kiralik-katil.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,

                    BossId = 6,
                    CategoryId = 6,
                    CityId = 34,
                    TownId = 435
                },
                new Shop()
                {
                    Id = 7,
                    Name = "Şişman Gym",
                    Description = "Fitness ve spor salonu.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@gym.com",
                    Url = "www.gym.com",

                    ImageUrl = "gym.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 7,
                    CategoryId = 7,
                    CityId = 34,
                    TownId = 430
                },
                new Shop()
                {
                    Id = 8,
                    Name = "Enfes Mantıcı",
                    Description = "Lezzetli mantı çeşitlerinin servis edildiği mantı dükkânı.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@mantici.com",
                    Url = "www.mantici.com",

                    ImageUrl = "mantici.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,

                    BossId = 8,
                    CategoryId = 8,
                    CityId = 34,
                    TownId = 425,
                },
                new Shop()
                {
                    Id = 9,
                    Name = "Yeşil Futbol Sahası",
                    Description = "Futbol oynamak için ideal bir saha.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@futbol-sahasi.com",
                    Url = "www.futbol-sahasi.com",

                    ImageUrl = "futbol-sahasi.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 9,
                    CategoryId = 9,
                    CityId = 34,
                    TownId = 432
                },
                new Shop()
                {
                    Id = 10,
                    Name = "Dikkat Lostra",
                    Description = "Ayakkabı tamir ve bakımı yapan lostra dükkânı.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@lostra.com",
                    Url = "www.lostra.com",

                    ImageUrl = "lostra.jpg",
                    IsHome = true,
                    IsActive = true,
                    IsDeleted = false,

                    BossId = 10,
                    CategoryId = 10,
                    CityId = 34,
                    TownId = 444
                },
                new Shop()
                {
                    Id = 11,
                    Name = "Rafık Bakkal",
                    Description = "Sevilen mahalle bakkal amcanız.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@rafik-kasap.com",
                    Url = "www.rafik-bakkal.com",

                    ImageUrl = "bakkal.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 1,
                    CategoryId = 11,
                    CityId = 34,
                    TownId = 438
                },
                new Shop()
                {
                    Id = 12,
                    Name = "Lezzet Restoran",
                    Description = "Lezzetli yemekler sunan restoran.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@lezzet-restoran.com",
                    Url = "www.lezzet-restoran.com",

                    ImageUrl = "restoran.jpg",
                    IsActive = true,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 2,
                    CategoryId = 12,
                    CityId = 34,
                    TownId = 444
                },
                new Shop()
                {
                    Id = 13,
                    Name = "Keyifli Kafe",
                    Description = "Keyifli bir ortamda kahve ve atıştırmalıklar sunan kafe.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@keyifli-kafe.com",
                    Url = "www.keyifli-kafe.com",

                    ImageUrl = "kafe.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,

                    BossId = 3,
                    CategoryId = 13,
                    CityId = 6,
                    TownId = 60
                },
                new Shop()
                {
                    Id = 14,
                    Name = "Şık Butik",
                    Description = "Moda ve stilin buluştuğu şık butik mağaza.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@sik-butik.com",
                    Url = "www.sik-butik.com",

                    ImageUrl = "butik.jpg",
                    IsActive = true,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 4,
                    CategoryId = 14,
                    CityId = 34,
                    TownId = 432
                },
                new Shop()
                {
                    Id = 15,
                    Name = "Net Optik",
                    Description = "Gözlük ve güneş gözlüğü mağazası.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@net-optik.com",
                    Url = "www.net-optik.com",

                    ImageUrl = "optik.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 5,
                    CategoryId = 15,
                    CityId = 35,
                    TownId = 470
                },
                new Shop()
                {
                    Id = 16,
                    Name = "Rahat Mobilya Mağazası",
                    Description = "Konforlu ve şık mobilyaların satıldığı mağaza.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@rahat-mobilya.com",
                    Url = "www.rahat-mobilya.com",

                    ImageUrl = "mobilya.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,

                    BossId = 6,
                    CategoryId = 16,
                    CityId = 16,
                    TownId = 200
                },
                new Shop()
                {
                    Id = 17,
                    Name = "Neşeli Oyuncakçı",
                    Description = "Eğlenceli ve renkli oyuncakların satıldığı oyuncakçı dükkanı.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@neseli-oyuncakci.com",
                    Url = "www.neseli-oyuncakci.com",

                    ImageUrl = "oyuncakci.jpg",
                    IsActive = true,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 7,
                    CategoryId = 17,
                    CityId = 7,
                    TownId = 90
                },
                new Shop()
                {
                    Id = 18,
                    Name = "Teknoloji Elektronik Mağaza",
                    Description = "Son teknoloji elektronik ürünlerin satıldığı mağaza.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@teknoloji-elektronik.com",
                    Url = "www.teknoloji-elektronik.com",

                    ImageUrl = "elektronik.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 8,
                    CategoryId = 18,
                    CityId = 41,
                    TownId = 560
                },
                new Shop()
                {
                    Id = 19,
                    Name = "Renkli Çiçekçi",
                    Description = "Canlı ve renkli çiçeklerin satıldığı çiçekçi dükkanı.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@renkli-cicekci.com",
                    Url = "www.renkli-cicekci.com",

                    ImageUrl = "cicekci.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,

                    BossId = 9,
                    CategoryId = 19,
                    CityId = 1,
                    TownId = 10

                },
                new Shop()
                {
                    Id = 20,
                    Name = "Bilge Kitapçı",
                    Description = "Geniş bir kitap koleksiyonuna sahip olan kitapçı.",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@bilge-kitapci.com",
                    Url = "www.bilge-kitapci.com",

                    ImageUrl = "kitapci.jpg",
                    IsActive = true,
                    IsHome = false,
                    IsDeleted = false,

                    BossId = 10,
                    CategoryId = 20,
                    CityId = 34,
                    TownId = 444
                }
            );
        }
    }
}
