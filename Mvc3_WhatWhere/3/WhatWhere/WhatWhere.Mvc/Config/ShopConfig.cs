using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Config
{
    public class ShopConfig : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasData
            (
                new Shop()
                {
                    Id = 1,
                    Name = "Özgün Kasap",
                    Description = "Lezzetli et ürünleriyle hizmet veren kasap dükkanı.",
                    Address = "İstiklal Caddesi, Beyoğlu, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@kasap.com",
                    Url = "www.kasap.com",

                    ImageUrl = "kasap.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Beyoğlu"
                },
                new Shop()
                {
                    Id = 2,
                    Name = "Namık Eczanesi",
                    Description = "Sağlık ürünleri ve ilaçların bulunduğu eczane.",
                    Address = "Bağdat Caddesi, Kadıköy, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@eczane.com",
                    Url = "www.eczane.com",

                    ImageUrl = "eczane.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Kadıköy"
                },
                new Shop()
                {
                    Id = 3,
                    Name = "Ozan Kırtasiyesi",
                    Description = "Kalemlerden defterlere, kırtasiye malzemelerinin satıldığı dükkân.",
                    Address = "Nişantaşı, Şişli, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@kirtasiye.com",
                    Url = "www.kirtasiye.com",

                    ImageUrl = "kirtasiye.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Şişli"
                },
                new Shop()
                {
                    Id = 4,
                    Name = "Neşe Terzi",
                    Description = "Kıyafet tamiratı ve dikimi yapan terzi dükkânı.",
                    Address = "Levent Mahallesi, Beşiktaş, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@terzi.com",
                    Url = "www.terzi.com",

                    ImageUrl = "terzi.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Beşiktaş"
                },
                new Shop()
                {
                    Id = 5,
                    Name = "İtina Dişçi",
                    Description = "Diş sağlığı hizmetleri sunan dişçi kliniği.",
                    Address = "Bebek, Beşiktaş, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@disci.com",
                    Url = "www.disci.com",

                    ImageUrl = "disci.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Beşiktaş"
                },
                new Shop()
                {
                    Id = 6,
                    Name = "Prof Kiralık Katil",
                    Description = "Profesyonel hizmetlerle kiralık katil işleri yapan gizli dükkân.",
                    Address = "Moda Caddesi, Kadıköy, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@kiralik-katil.com",
                    Url = "www.kiralik-katil.com",

                    ImageUrl = "kiralik-katil.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Kadıköy"
                },
                new Shop()
                {
                    Id = 7,
                    Name = "Şişman Gym",
                    Description = "Fitness ve spor salonu.",
                    Address = "Sultanahmet Meydanı, Fatih, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@gym.com",
                    Url = "www.gym.com",

                    ImageUrl = "gym.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Fatih"
                },
                new Shop()
                {
                    Id = 8,
                    Name = "Enfes Mantıcı",
                    Description = "Lezzetli mantı çeşitlerinin servis edildiği mantı dükkânı.",
                    Address = "Ortaköy, Beşiktaş, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@mantici.com",
                    Url = "www.mantici.com",

                    ImageUrl = "mantici.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Beşiktaş"
                },
                new Shop()
                {
                    Id = 9,
                    Name = "Yeşil Futbol Sahası",
                    Description = "Futbol oynamak için ideal bir saha.",
                    Address = "Kadıköy İskelesi, Kadıköy, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@futbol-sahasi.com",
                    Url = "www.futbol-sahasi.com",

                    ImageUrl = "futbol-sahasi.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Kadıköy"
                },
                new Shop()
                {
                    Id = 10,
                    Name = "Dikkat Lostra",
                    Description = "Ayakkabı tamir ve bakımı yapan lostra dükkânı.",
                    Address = "Taksim Meydanı, Beyoğlu, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@lostra.com",
                    Url = "www.lostra.com",

                    ImageUrl = "lostra.jpg",
                    IsHome = true,
                    IsActive = true,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Beyoğlu"
                },
                new Shop()
                {
                    Id = 11,
                    Name = "Rafık Bakkal",
                    Description = "Sevilen mahalle bakkal amcanız.",
                    Address = "İstiklal Caddesi, Beyoğlu, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@rafik-kasap.com",
                    Url = "www.rafik-bakkal.com",

                    ImageUrl = "bakkal.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Beyoğlu"
                },
                new Shop()
                {
                    Id = 12,
                    Name = "Lezzet Restoran",
                    Description = "Lezzetli yemekler sunan restoran.",
                    Address = "Merkez Mahallesi, İstanbul, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@lezzet-restoran.com",
                    Url = "www.lezzet-restoran.com",

                    ImageUrl = "restoran.jpg",
                    IsActive = true,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Şişli"
                },
                new Shop()
                {
                    Id = 13,
                    Name = "Keyifli Kafe",
                    Description = "Keyifli bir ortamda kahve ve atıştırmalıklar sunan kafe.",
                    Address = "Bahçe Sokak, Ankara, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@keyifli-kafe.com",
                    Url = "www.keyifli-kafe.com",

                    ImageUrl = "kafe.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "Ankara",
                    Town = "Çankaya"
                },
                new Shop()
                {
                    Id = 14,
                    Name = "Şık Butik",
                    Description = "Moda ve stilin buluştuğu şık butik mağaza.",
                    Address = "Bağdat Caddesi, Kadıköy, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@sik-butik.com",
                    Url = "www.sik-butik.com",

                    ImageUrl = "butik.jpg",
                    IsActive = true,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Kadıköy"
                },
                new Shop()
                {
                    Id = 15,
                    Name = "Net Optik",
                    Description = "Gözlük ve güneş gözlüğü mağazası.",
                    Address = "İzmir Caddesi, İzmir, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@net-optik.com",
                    Url = "www.net-optik.com",

                    ImageUrl = "optik.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İzmir",
                    Town = "Konak"
                },
                new Shop()
                {
                    Id = 16,
                    Name = "Rahat Mobilya Mağazası",
                    Description = "Konforlu ve şık mobilyaların satıldığı mağaza.",
                    Address = "Bağlar Sokak, Bursa, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@rahat-mobilya.com",
                    Url = "www.rahat-mobilya.com",

                    ImageUrl = "mobilya.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "Bursa",
                    Town = "Osmangazi"
                },
                new Shop()
                {
                    Id = 17,
                    Name = "Neşeli Oyuncakçı",
                    Description = "Eğlenceli ve renkli oyuncakların satıldığı oyuncakçı dükkanı.",
                    Address = "Çocuklar Caddesi, Antalya, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@neseli-oyuncakci.com",
                    Url = "www.neseli-oyuncakci.com",

                    ImageUrl = "oyuncakci.jpg",
                    IsActive = true,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "Antalya",
                    Town = "Muratpaşa"
                },
                new Shop()
                {
                    Id = 18,
                    Name = "Teknoloji Elektronik Mağaza",
                    Description = "Son teknoloji elektronik ürünlerin satıldığı mağaza.",
                    Address = "Teknoloji Sokak, İzmit, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@teknoloji-elektronik.com",
                    Url = "www.teknoloji-elektronik.com",

                    ImageUrl = "elektronik.jpg",
                    IsActive = false,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "Kocaeli",
                    Town = "İzmit"
                },
                new Shop()
                {
                    Id = 19,
                    Name = "Renkli Çiçekçi",
                    Description = "Canlı ve renkli çiçeklerin satıldığı çiçekçi dükkanı.",
                    Address = "Çiçekler Sokak, Adana, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@renkli-cicekci.com",
                    Url = "www.renkli-cicekci.com",

                    ImageUrl = "cicekci.jpg",
                    IsActive = true,
                    IsHome = true,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "Adana",
                    Town = "Seyhan"

                },
                new Shop()
                {
                    Id = 20,
                    Name = "Bilge Kitapçı",
                    Description = "Geniş bir kitap koleksiyonuna sahip olan kitapçı.",
                    Address = "Kitaplar Sokak, İstanbul, Türkiye",
                    PhoneNumber = "1234567890",
                    MailAdress = "info@bilge-kitapci.com",
                    Url = "www.bilge-kitapci.com",

                    ImageUrl = "kitapci.jpg",
                    IsActive = true,
                    IsHome = false,
                    IsDeleted = false,
                    Country = "Türkiye",
                    City = "İstanbul",
                    Town = "Kadıköy"
                }
            );
        }
    }
}
