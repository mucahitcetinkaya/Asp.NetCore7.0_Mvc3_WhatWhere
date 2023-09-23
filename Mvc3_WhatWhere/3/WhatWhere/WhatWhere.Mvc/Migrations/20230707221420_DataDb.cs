using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhatWhere.Mvc.Migrations
{
    /// <inheritdoc />
    public partial class DataDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    BirthOfYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    MailAdress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Town = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    MailAdress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "BirthOfYear", "FirstName", "Gender", "LastName", "MailAdress", "PhoneNumber", "Url" },
                values: new object[,]
                {
                    { 1, 1990, "Ahmet", "Male", "Yılmaz", "ahmet@example.com", "1234567890", "ahmet-yilmaz.com" },
                    { 2, 1985, "Mehmet", "Male", "Kaya", "mehmet@example.com", "1234567890", "mehmet-kaya.com" },
                    { 3, 1992, "Ayşe", "Female", "Demir", "ayse@example.com", "1234567890", "ayse-demir.com" },
                    { 4, 1988, "Fatma", "Female", "Yıldırım", "fatma@example.com", "1234567890", "fatma-yildirim.com" },
                    { 5, 1995, "Ali", "Male", "Öztürk", "ali@example.com", "1234567890", "ali-ozturk.com" },
                    { 6, 1991, "Zeynep", "Female", "Aktaş", "zeynep@example.com", "1234567890", "zeynep-aktas.com" },
                    { 7, 1987, "Hakan", "Male", "Koç", "hakan@example.com", "1234567890", "hakan-koc.com" },
                    { 8, 1994, "Selin", "Female", "Can", "selin@example.com", "1234567890", "selin-can.com" },
                    { 9, 1989, "Murat", "Male", "Şahin", "murat@example.com", "1234567890", "murat-sahin.com" },
                    { 10, 1993, "Deniz", "Female", "Arslan", "deniz@example.com", "1234567890", "deniz-arslan.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Kasap Kategorisi", "Kasap" },
                    { 2, "Eczane Kategorisi", "Eczane" },
                    { 3, "Kırtasiye Kategorisi", "Kırtasiye" },
                    { 4, "Terzi Kategorisi", "Terzi" },
                    { 5, "Dişçi Kategorisi", "Dişçi" },
                    { 6, "Kiralık Katil Kategorisi", "Kiralık Katil" },
                    { 7, "Gym Kategorisi", "Gym" },
                    { 8, "Mantıcı Kategorisi", "Mantıcı" },
                    { 9, "Futbol Sahası Kategorisi", "Futbol Sahası" },
                    { 10, "Lostra Kategorisi", "Lostra" },
                    { 11, "Bakkal Kategorisi", "Bakkal" },
                    { 12, "Restoran Kategorisi", "Restoran" },
                    { 13, "Kafe Kategorisi", "Kafe" },
                    { 14, "Butik Kategorisi", "Butik" },
                    { 15, "Optik Kategorisi", "Optik" },
                    { 16, "Mobilya Mağazası Kategorisi", "Mobilya Mağazası" },
                    { 17, "Oyuncakçı Kategorisi", "Oyuncakçı" },
                    { 18, "Elektronik Mağaza Kategorisi", "Elektronik Mağaza" },
                    { 19, "Çiçekçi Kategorisi", "Çiçekçi" },
                    { 20, "Kitapçı Kategorisi", "Kitapçı" },
                    { 21, "Genel Kategorisi", "Genel" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "City", "Country", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "MailAdress", "ModifiedDate", "Name", "PhoneNumber", "Town", "Url" },
                values: new object[,]
                {
                    { 1, "İstiklal Caddesi, Beyoğlu, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2944), "Lezzetli et ürünleriyle hizmet veren kasap dükkanı.", "kasap.jpg", false, false, false, "info@kasap.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2957), "Özgün Kasap", "1234567890", "Beyoğlu", "www.kasap.com" },
                    { 2, "Bağdat Caddesi, Kadıköy, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2963), "Sağlık ürünleri ve ilaçların bulunduğu eczane.", "eczane.jpg", true, false, true, "info@eczane.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2964), "Namık Eczanesi", "1234567890", "Kadıköy", "www.eczane.com" },
                    { 3, "Nişantaşı, Şişli, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2967), "Kalemlerden defterlere, kırtasiye malzemelerinin satıldığı dükkân.", "kirtasiye.jpg", false, false, false, "info@kirtasiye.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2967), "Ozan Kırtasiyesi", "1234567890", "Şişli", "www.kirtasiye.com" },
                    { 4, "Levent Mahallesi, Beşiktaş, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2970), "Kıyafet tamiratı ve dikimi yapan terzi dükkânı.", "terzi.jpg", true, false, true, "info@terzi.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2970), "Neşe Terzi", "1234567890", "Beşiktaş", "www.terzi.com" },
                    { 5, "Bebek, Beşiktaş, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2973), "Diş sağlığı hizmetleri sunan dişçi kliniği.", "disci.jpg", false, false, false, "info@disci.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2973), "İtina Dişçi", "1234567890", "Beşiktaş", "www.disci.com" },
                    { 6, "Moda Caddesi, Kadıköy, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2976), "Profesyonel hizmetlerle kiralık katil işleri yapan gizli dükkân.", "kiralik-katil.jpg", true, false, true, "info@kiralik-katil.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2976), "Prof Kiralık Katil", "1234567890", "Kadıköy", "www.kiralik-katil.com" },
                    { 7, "Sultanahmet Meydanı, Fatih, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2980), "Fitness ve spor salonu.", "gym.jpg", false, false, false, "info@gym.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(2980), "Şişman Gym", "1234567890", "Fatih", "www.gym.com" },
                    { 8, "Ortaköy, Beşiktaş, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3019), "Lezzetli mantı çeşitlerinin servis edildiği mantı dükkânı.", "mantici.jpg", true, false, true, "info@mantici.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3020), "Enfes Mantıcı", "1234567890", "Beşiktaş", "www.mantici.com" },
                    { 9, "Kadıköy İskelesi, Kadıköy, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3024), "Futbol oynamak için ideal bir saha.", "futbol-sahasi.jpg", false, false, false, "info@futbol-sahasi.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3024), "Yeşil Futbol Sahası", "1234567890", "Kadıköy", "www.futbol-sahasi.com" },
                    { 10, "Taksim Meydanı, Beyoğlu, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3027), "Ayakkabı tamir ve bakımı yapan lostra dükkânı.", "lostra.jpg", true, false, true, "info@lostra.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3027), "Dikkat Lostra", "1234567890", "Beyoğlu", "www.lostra.com" },
                    { 11, "İstiklal Caddesi, Beyoğlu, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3030), "Sevilen mahalle bakkal amcanız.", "bakkal.jpg", false, false, false, "info@rafik-kasap.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3030), "Rafık Bakkal", "1234567890", "Beyoğlu", "www.rafik-bakkal.com" },
                    { 12, "Merkez Mahallesi, İstanbul, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3033), "Lezzetli yemekler sunan restoran.", "restoran.jpg", true, false, false, "info@lezzet-restoran.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3033), "Lezzet Restoran", "1234567890", "Şişli", "www.lezzet-restoran.com" },
                    { 13, "Bahçe Sokak, Ankara, Türkiye", "Ankara", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3035), "Keyifli bir ortamda kahve ve atıştırmalıklar sunan kafe.", "kafe.jpg", true, false, true, "info@keyifli-kafe.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3036), "Keyifli Kafe", "1234567890", "Çankaya", "www.keyifli-kafe.com" },
                    { 14, "Bağdat Caddesi, Kadıköy, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3038), "Moda ve stilin buluştuğu şık butik mağaza.", "butik.jpg", true, false, false, "info@sik-butik.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3039), "Şık Butik", "1234567890", "Kadıköy", "www.sik-butik.com" },
                    { 15, "İzmir Caddesi, İzmir, Türkiye", "İzmir", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3041), "Gözlük ve güneş gözlüğü mağazası.", "optik.jpg", false, false, false, "info@net-optik.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3042), "Net Optik", "1234567890", "Konak", "www.net-optik.com" },
                    { 16, "Bağlar Sokak, Bursa, Türkiye", "Bursa", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3044), "Konforlu ve şık mobilyaların satıldığı mağaza.", "mobilya.jpg", true, false, true, "info@rahat-mobilya.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3045), "Rahat Mobilya Mağazası", "1234567890", "Osmangazi", "www.rahat-mobilya.com" },
                    { 17, "Çocuklar Caddesi, Antalya, Türkiye", "Antalya", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3048), "Eğlenceli ve renkli oyuncakların satıldığı oyuncakçı dükkanı.", "oyuncakci.jpg", true, false, false, "info@neseli-oyuncakci.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3048), "Neşeli Oyuncakçı", "1234567890", "Muratpaşa", "www.neseli-oyuncakci.com" },
                    { 18, "Teknoloji Sokak, İzmit, Türkiye", "Kocaeli", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3051), "Son teknoloji elektronik ürünlerin satıldığı mağaza.", "elektronik.jpg", false, false, false, "info@teknoloji-elektronik.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3051), "Teknoloji Elektronik Mağaza", "1234567890", "İzmit", "www.teknoloji-elektronik.com" },
                    { 19, "Çiçekler Sokak, Adana, Türkiye", "Adana", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3054), "Canlı ve renkli çiçeklerin satıldığı çiçekçi dükkanı.", "cicekci.jpg", true, false, true, "info@renkli-cicekci.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3054), "Renkli Çiçekçi", "1234567890", "Seyhan", "www.renkli-cicekci.com" },
                    { 20, "Kitaplar Sokak, İstanbul, Türkiye", "İstanbul", "Türkiye", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3057), "Geniş bir kitap koleksiyonuna sahip olan kitapçı.", "kitapci.jpg", true, false, false, "info@bilge-kitapci.com", new DateTime(2023, 7, 8, 1, 14, 20, 87, DateTimeKind.Local).AddTicks(3057), "Bilge Kitapçı", "1234567890", "Kadıköy", "www.bilge-kitapci.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
