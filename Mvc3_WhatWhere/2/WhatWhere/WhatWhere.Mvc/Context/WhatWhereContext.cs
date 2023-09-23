using Microsoft.EntityFrameworkCore;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Context
{
    public class WhatWhereContext : DbContext
    {
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Category> Categories { get; set; }

        public WhatWhereContext(DbContextOptions<WhatWhereContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Boss>()
            .HasData
            (
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
             );

            modelBuilder.Entity<Shop>()
            .HasData
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

            modelBuilder.Entity<Category>()
             .HasData
             (
                 new Category()
                {
                    Id = 1,
                    Name = "Kasap",
                    Description = "Kasap Kategorisi"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Eczane",
                    Description = "Eczane Kategorisi"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Kırtasiye",
                    Description = "Kırtasiye Kategorisi"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Terzi",
                    Description = "Terzi Kategorisi"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Dişçi",
                    Description = "Dişçi Kategorisi"
                },
                new Category()
                {
                    Id = 6,
                    Name = "Kiralık Katil",
                    Description = "Kiralık Katil Kategorisi"
                },
                new Category()
                {
                    Id = 7,
                    Name = "Gym",
                    Description = "Gym Kategorisi"
                },
                new Category()
                {
                    Id = 8,
                    Name = "Mantıcı",
                    Description = "Mantıcı Kategorisi"
                },
                new Category()
                {
                    Id = 9,
                    Name = "Futbol Sahası",
                    Description = "Futbol Sahası Kategorisi"
                },
                new Category()
                {
                    Id = 10,
                    Name = "Lostra",
                    Description = "Lostra Kategorisi"
                },
                new Category()
                {
                    Id = 11,
                    Name = "Bakkal",
                    Description = "Bakkal Kategorisi"
                },
                new Category()
                {
                    Id = 12,
                    Name = "Restoran",
                    Description = "Restoran Kategorisi"
                },
                new Category()
                {
                    Id = 13,
                    Name = "Kafe",
                    Description = "Kafe Kategorisi"
                },
                new Category()
                {
                    Id = 14,
                    Name = "Butik",
                    Description = "Butik Kategorisi"
                },
                new Category()
                {
                    Id = 15,
                    Name = "Optik",
                    Description = "Optik Kategorisi"
                },
                new Category()
                {
                    Id = 16,
                    Name = "Mobilya Mağazası",
                    Description = "Mobilya Mağazası Kategorisi"
                },
                new Category()
                {
                    Id = 17,
                    Name = "Oyuncakçı",
                    Description = "Oyuncakçı Kategorisi"
                },
                new Category()
                {
                    Id = 18,
                    Name = "Elektronik Mağaza",
                    Description = "Elektronik Mağaza Kategorisi"
                },
                new Category()
                {
                    Id = 19,
                    Name = "Çiçekçi",
                    Description = "Çiçekçi Kategorisi"
                },
                new Category()
                {
                    Id = 20,
                    Name = "Kitapçı",
                    Description = "Kitapçı Kategorisi"
                },
                new Category()
                {
                    Id = 21,
                    Name = "Genel",
                    Description = "Genel Kategorisi"
                }
             );  
        }
    }
}