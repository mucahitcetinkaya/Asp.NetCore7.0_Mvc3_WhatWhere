using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhatWhere.Data.Migrations
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
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    BirthOfYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
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
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sehir = table.Column<string>(type: "TEXT", nullable: false),
                    Ilce = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BossId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CityId = table.Column<int>(type: "INTEGER", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    MailAdress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shops_Bosses_BossId",
                        column: x => x.BossId,
                        principalTable: "Bosses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Shops_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shops_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
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
                table: "Cities",
                columns: new[] { "Id", "Ilce", "Sehir" },
                values: new object[,]
                {
                    { 1, "Aladağ,Ceyhan,Çukurova,Feke,İmamoğlu,Karaisalı,Karataş,Kozan,Pozantı,Saimbeyli,Sarıçam,Seyhan,Tufanbeyli,Yumurtalık,Yüreğir", "Adana" },
                    { 2, "Besni,Çelikhan,Gerger,Gölbaşı,Kahta,Merkez,Samsat,Sincik,Tut", "Adıyaman" },
                    { 3, "Başmakçı,Bayat,Bolvadin,Çay,Çobanlar,Dazkırı,Dinar,Emirdağ,Evciler,Hocalar,İhsaniye,İscehisar,Kızılören,Merkez,Sandıklı,Sinanpaşa,Sultandağı,Şuhut", "Afyonkarahisar" },
                    { 4, "Diyadin,Doğubayazıt,Eleşkirt,Hamur,Merkez,Patnos,Taşlıçay,Tutak", "Ağrı" },
                    { 5, "Göynücek,Gümüşhacıköy,Hamamözü,Merkez,Merzifon,Suluova,Taşova", "Amasya" },
                    { 6, "Altındağ,Ayaş,Bala,Beypazarı,Çamlıdere,Çankaya,Çubuk,Elmadağ,Güdül,Haymana,Kalecik,Kızılcahamam,Nallıhan,Polatlı,Şereflikoçhisar,Yenimahalle,Gölbaşı,Keçiören,Mamak,Sincan,Kazan,Akyurt,Etimesgut,Evren,Pursaklar", "Ankara" },
                    { 7, "Akseki,Alanya,Elmalı,Finike,Gazipaşa,Gündoğmuş,Kaş,Korkuteli,Kumluca,Manavgat,Serik,Demre,İbradı,Kemer,Aksu,Döşemealtı,Kepez,Konyaaltı,Muratpaşa", "Antalya" },
                    { 8, "Ardanuç,Arhavi,Merkez,Borçka,Hopa,Şavşat,Yusufeli,Murgul", "Artvin" },
                    { 9, "Merkez,Bozdoğan,Efeler,Çine,Germencik,Karacasu,Koçarlı,Kuşadası,Kuyucak,Nazilli,Söke,Sultanhisar,Yenipazar,Buharkent,İncirliova,Karpuzlu,Köşk,Didim", "Aydın" },
                    { 10, "Altıeylül,Ayvalık,Merkez,Balya,Bandırma,Bigadiç,Burhaniye,Dursunbey,Edremit,Erdek,Gönen,Havran,İvrindi,Karesi,Kepsut,Manyas,Savaştepe,Sındırgı,Gömeç,Susurluk,Marmara", "Balıkesir" },
                    { 11, "Merkez,Bozüyük,Gölpazarı,Osmaneli,Pazaryeri,Söğüt,Yenipazar,İnhisar", "Bilecik" },
                    { 12, "Merkez,Genç,Karlıova,Kiğı,Solhan,Adaklı,Yayladere,Yedisu", "Bingöl" },
                    { 13, "Adilcevaz,Ahlat,Merkez,Hizan,Mutki,Tatvan,Güroymak", "Bitlis" },
                    { 14, "Merkez,Gerede,Göynük,Kıbrıscık,Mengen,Mudurnu,Seben,Dörtdivan,Yeniçağa", "Bolu" },
                    { 15, "Ağlasun,Bucak,Merkez,Gölhisar,Tefenni,Yeşilova,Karamanlı,Kemer,Altınyayla,Çavdır,Çeltikçi", "Burdur" },
                    { 16, "Gemlik,İnegöl,İznik,Karacabey,Keles,Mudanya,Mustafakemalpaşa,Orhaneli,Orhangazi,Yenişehir,Büyükorhan,Harmancık,Nilüfer,Osmangazi,Yıldırım,Gürsu,Kestel", "Bursa" },
                    { 17, "Ayvacık,Bayramiç,Biga,Bozcaada,Çan,Merkez,Eceabat,Ezine,Gelibolu,Gökçeada,Lapseki,Yenice", "Çanakkale" },
                    { 18, "Merkez,Çerkeş,Eldivan,Ilgaz,Kurşunlu,Orta,Şabanözü,Yapraklı,Atkaracalar,Kızılırmak,Bayramören,Korgun", "Çankırı" },
                    { 19, "Alaca,Bayat,Merkez,İskilip,Kargı,Mecitözü,Ortaköy,Osmancık,Sungurlu,Boğazkale,Uğurludağ,Dodurga,Laçin,Oğuzlar", "Çorum" },
                    { 20, "Acıpayam,Buldan,Çal,Çameli,Çardak,Çivril,Merkez,Merkezefendi,Pamukkale,Güney,Kale,Sarayköy,Tavas,Babadağ,Bekilli,Honaz,Serinhisar,Baklan,Beyağaç,Bozkurt", "Denizli" },
                    { 21, "Kocaköy,Çermik,Çınar,Çüngüş,Dicle,Ergani,Hani,Hazro,Kulp,Lice,Silvan,Eğil,Bağlar,Kayapınar,Sur,Yenişehir,Bismil", "Diyarbakır" },
                    { 22, "Merkez,Enez,Havsa,İpsala,Keşan,Lalapaşa,Meriç,Uzunköprü,Süloğlu", "Edirne" },
                    { 23, "Ağın,Baskil,Merkez,Karakoçan,Keban,Maden,Palu,Sivrice,Arıcak,Kovancılar,Alacakaya", "Elazığ" },
                    { 24, "Çayırlı,Merkez,İliç,Kemah,Kemaliye,Refahiye,Tercan,Üzümlü,Otlukbeli", "Erzincan" },
                    { 25, "Aşkale,Çat,Hınıs,Horasan,İspir,Karayazı,Narman,Oltu,Olur,Pasinler,Şenkaya,Tekman,Tortum,Karaçoban,Uzundere,Pazaryolu,Köprüköy,Palandöken,Yakutiye,Aziziye", "Erzurum" },
                    { 26, "Çifteler,Mahmudiye,Mihalıççık,Sarıcakaya,Seyitgazi,Sivrihisar,Alpu,Beylikova,İnönü,Günyüzü,Han,Mihalgazi,Odunpazarı,Tepebaşı", "Eskişehir" },
                    { 27, "Araban,İslahiye,Nizip,Oğuzeli,Yavuzeli,Şahinbey,Şehitkamil,Karkamış,Nurdağı", "Gaziantep" },
                    { 28, "Alucra,Bulancak,Dereli,Espiye,Eynesil,Merkez,Görele,Keşap,Şebinkarahisar,Tirebolu,Piraziz,Yağlıdere,Çamoluk,Çanakçı,Doğankent,Güce", "Giresun" },
                    { 29, "Merkez,Kelkit,Şiran,Torul,Köse,Kürtün", "Gümüşhane" },
                    { 30, "Çukurca,Merkez,Şemdinli,Yüksekova", "Hakkari" },
                    { 31, "Altınözü,Arsuz,Defne,Dörtyol,Hassa,Antakya,İskenderun,Kırıkhan,Payas,Reyhanlı,Samandağ,Yayladağı,Erzin,Belen,Kumlu", "Hatay" },
                    { 32, "Atabey,Eğirdir,Gelendost,Merkez,Keçiborlu,Senirkent,Sütçüler,Şarkikaraağaç,Uluborlu,Yalvaç,Aksu,Gönen,Yenişarbademli", "Isparta" },
                    { 33, "Anamur,Erdemli,Gülnar,Mut,Silifke,Tarsus,Aydıncık,Bozyazı,Çamlıyayla,Akdeniz,Mezitli,Toroslar,Yenişehir", "Mersin" },
                    { 34, "Adalar,Bakırköy,Beşiktaş,Beykoz,Beyoğlu,Çatalca,Eyüp,Fatih,Gaziosmanpaşa,Kadıköy,Kartal,Sarıyer,Silivri,Şile,Şişli,Üsküdar,Zeytinburnu,Büyükçekmece,Kağıthane,Küçükçekmece,Pendik,Ümraniye,Bayrampaşa,Avcılar,Bağcılar,Bahçelievler,Güngören,Maltepe,Sultanbeyli,Tuzla,Esenler,Arnavutköy,Ataşehir,Başakşehir,Beylikdüzü,Çekmeköy,Esenyurt,Sancaktepe,Sultangazi", "İstanbul" },
                    { 35, "Aliağa,Bayındır,Bergama,Bornova,Çeşme,Dikili,Foça,Karaburun,Karşıyaka,Kemalpaşa,Kınık,Kiraz,Menemen,Ödemiş,Seferihisar,Selçuk,Tire,Torbalı,Urla,Beydağ,Buca,Konak,Menderes,Balçova,Çiğli,Gaziemir,Narlıdere,Güzelbahçe,Bayraklı,Karabağlar", "İzmir" },
                    { 36, "Arpaçay,Digor,Kağızman,Merkez,Sarıkamış,Selim,Susuz,Akyaka", "Kars" },
                    { 37, "Abana,Araç,Azdavay,Bozkurt,Cide,Çatalzeytin,Daday,Devrekani,İnebolu,Merkez,Küre,Taşköprü,Tosya,İhsangazi,Pınarbaşı,Şenpazar,Ağlı,Doğanyurt,Hanönü,Seydiler", "Kastamonu" },
                    { 38, "Bünyan,Develi,Felahiye,İncesu,Pınarbaşı,Sarıoğlan,Sarız,Tomarza,Yahyalı,Yeşilhisar,Akkışla,Talas,Kocasinan,Melikgazi,Hacılar,Özvatan", "Kayseri" },
                    { 39, "Babaeski,Demirköy,Merkez,Kofçaz,Lüleburgaz,Pehlivanköy,Pınarhisar,Vize", "Kırklareli" },
                    { 40, "Çiçekdağı,Kaman,Merkez,Mucur,Akpınar,Akçakent,Boztepe", "Kırşehir" },
                    { 41, "Gebze,Gölcük,Kandıra,Karamürsel,Körfez,Derince,Başiskele,Çayırova,Darıca,Dilovası,İzmit,Kartepe", "Kocaeli" },
                    { 42, "Akşehir,Beyşehir,Bozkır,Cihanbeyli,Çumra,Doğanhisar,Ereğli,Hadim,Ilgın,Kadınhanı,Karapınar,Kulu,Sarayönü,Seydişehir,Yunak,Akören,Altınekin,Derebucak,Hüyük,Karatay,Meram,Selçuklu,Taşkent,Ahırlı,Çeltik,Derbent,Emirgazi,Güneysınır,Halkapınar,Tuzlukçu,Yalıhüyük", "Konya" },
                    { 43, "Altıntaş,Domaniç,Emet,Gediz,Merkez,Simav,Tavşanlı,Aslanapa,Dumlupınar,Hisarcık,Şaphane,Çavdarhisar,Pazarlar", "Kütahya" },
                    { 44, "Akçadağ,Arapgir,Arguvan,Darende,Doğanşehir,Hekimhan,Merkez,Pütürge,Yeşilyurt,Battalgazi,Doğanyol,Kale,Kuluncak,Yazıhan", "Malatya" },
                    { 45, "Akhisar,Alaşehir,Demirci,Gördes,Kırkağaç,Kula,Merkez,Salihli,Sarıgöl,Saruhanlı,Selendi,Soma,Şehzadeler,Yunusemre,Turgutlu,Ahmetli,Gölmarmara,Köprübaşı", "Manisa" },
                    { 46, "Afşin,Andırın,Dulkadiroğlu,Onikişubat,Elbistan,Göksun,Merkez,Pazarcık,Türkoğlu,Çağlayancerit,Ekinözü,Nurhak", "Kahramanmaraş" },
                    { 47, "Derik,Kızıltepe,Artuklu,Merkez,Mazıdağı,Midyat,Nusaybin,Ömerli,Savur,Dargeçit,Yeşilli", "Mardin" },
                    { 48, "Bodrum,Datça,Fethiye,Köyceğiz,Marmaris,Menteşe,Milas,Ula,Yatağan,Dalaman,Seydikemer,Ortaca,Kavaklıdere", "Muğla" },
                    { 49, "Bulanık,Malazgirt,Merkez,Varto,Hasköy,Korkut", "Muş" },
                    { 50, "Avanos,Derinkuyu,Gülşehir,Hacıbektaş,Kozaklı,Merkez,Ürgüp,Acıgöl", "Nevşehir" },
                    { 51, "Bor,Çamardı,Merkez,Ulukışla,Altunhisar,Çiftlik", "Niğde" },
                    { 52, "Akkuş,Altınordu,Aybastı,Fatsa,Gölköy,Korgan,Kumru,Mesudiye,Perşembe,Ulubey,Ünye,Gülyalı,Gürgentepe,Çamaş,Çatalpınar,Çaybaşı,İkizce,Kabadüz,Kabataş", "Ordu" },
                    { 53, "Ardeşen,Çamlıhemşin,Çayeli,Fındıklı,İkizdere,Kalkandere,Pazar,Merkez,Güneysu,Derepazarı,Hemşin,İyidere", "Rize" },
                    { 54, "Akyazı,Geyve,Hendek,Karasu,Kaynarca,Sapanca,Kocaali,Pamukova,Taraklı,Ferizli,Karapürçek,Söğütlü,Adapazarı,Arifiye,Erenler,Serdivan", "Sakarya" },
                    { 55, "Alaçam,Bafra,Çarşamba,Havza,Kavak,Ladik,Terme,Vezirköprü,Asarcık,Ondokuzmayıs,Salıpazarı,Tekkeköy,Ayvacık,Yakakent,Atakum,Canik,İlkadım", "Samsun" },
                    { 56, "Baykan,Eruh,Kurtalan,Pervari,Merkez,Şirvan,Tillo", "Siirt" },
                    { 57, "Ayancık,Boyabat,Durağan,Erfelek,Gerze,Merkez,Türkeli,Dikmen,Saraydüzü", "Sinop" },
                    { 58, "Divriği,Gemerek,Gürün,Hafik,İmranlı,Kangal,Koyulhisar,Merkez,Suşehri,Şarkışla,Yıldızeli,Zara,Akıncılar,Altınyayla,Doğanşar,Gölova,Ulaş", "Sivas" },
                    { 59, "Çerkezköy,Çorlu,Ergene,Hayrabolu,Malkara,Muratlı,Saray,Süleymanpaşa,Kapaklı,Şarköy,Marmaraereğlisi", "Tekirdağ" },
                    { 60, "Almus,Artova,Erbaa,Niksar,Reşadiye,Merkez,Turhal,Zile,Pazar,Yeşilyurt,Başçiftlik,Sulusaray", "Tokat" },
                    { 61, "Akçaabat,Araklı,Arsin,Çaykara,Maçka,Of,Ortahisar,Sürmene,Tonya,Vakfıkebir,Yomra,Beşikdüzü,Şalpazarı,Çarşıbaşı,Dernekpazarı,Düzköy,Hayrat,Köprübaşı", "Trabzon" },
                    { 62, "Çemişgezek,Hozat,Mazgirt,Nazımiye,Ovacık,Pertek,Pülümür,Merkez", "Tunceli" },
                    { 63, "Akçakale,Birecik,Bozova,Ceylanpınar,Eyyübiye,Halfeti,Haliliye,Hilvan,Karaköprü,Siverek,Suruç,Viranşehir,Harran", "Şanlıurfa" },
                    { 64, "Banaz,Eşme,Karahallı,Sivaslı,Ulubey,Merkez", "Uşak" },
                    { 65, "Başkale,Çatak,Erciş,Gevaş,Gürpınar,İpekyolu,Muradiye,Özalp,Tuşba,Bahçesaray,Çaldıran,Edremit,Saray", "Van" },
                    { 66, "Akdağmadeni,Boğazlıyan,Çayıralan,Çekerek,Sarıkaya,Sorgun,Şefaatli,Yerköy,Merkez,Aydıncık,Çandır,Kadışehri,Saraykent,Yenifakılı", "Yozgat" },
                    { 67, "Çaycuma,Devrek,Ereğli,Merkez,Alaplı,Gökçebey", "Zonguldak" },
                    { 68, "Ağaçören,Eskil,Gülağaç,Güzelyurt,Merkez,Ortaköy,Sarıyahşi", "Aksaray" },
                    { 69, "Merkez,Aydıntepe,Demirözü", "Bayburt" },
                    { 70, "Ermenek,Merkez,Ayrancı,Kazımkarabekir,Başyayla,Sarıveliler", "Karaman" },
                    { 71, "Delice,Keskin,Merkez,Sulakyurt,Bahşili,Balışeyh,Çelebi,Karakeçili,Yahşihan", "Kırıkkale" },
                    { 72, "Merkez,Beşiri,Gercüş,Kozluk,Sason,Hasankeyf", "Batman" },
                    { 73, "Beytüşşebap,Cizre,İdil,Silopi,Merkez,Uludere,Güçlükonak", "Şırnak" },
                    { 74, "Merkez,Kurucaşile,Ulus,Amasra", "Bartın" },
                    { 75, "Merkez,Çıldır,Göle,Hanak,Posof,Damal", "Ardahan" },
                    { 76, "Aralık,Merkez,Tuzluca,Karakoyunlu", "Iğdır" },
                    { 77, "Merkez,Altınova,Armutlu,Çınarcık,Çiftlikköy,Termal", "Yalova" },
                    { 78, "Eflani,Eskipazar,Merkez,Ovacık,Safranbolu,Yenice", "Karabük" },
                    { 79, "Merkez,Elbeyli,Musabeyli,Polateli", "Kilis" },
                    { 80, "Bahçe,Kadirli,Merkez,Düziçi,Hasanbeyli,Sumbas,Toprakkale", "Osmaniye" },
                    { 81, "Akçakoca,Merkez,Yığılca,Cumayeri,Gölyaka,Çilimli,Gümüşova,Kaynaşlı", "Düzce" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "Id", "Address", "BossId", "CategoryId", "CityId", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "MailAdress", "ModifiedDate", "Name", "PhoneNumber", "Url" },
                values: new object[,]
                {
                    { 1, "İstiklal Caddesi, Beyoğlu, İstanbul, Türkiye", 1, 1, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2280), "Lezzetli et ürünleriyle hizmet veren kasap dükkanı.", "kasap.jpg", false, false, false, "info@kasap.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2295), "Özgün Kasap", "1234567890", "www.kasap.com" },
                    { 2, "Bağdat Caddesi, Kadıköy, İstanbul, Türkiye", 2, 2, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2305), "Sağlık ürünleri ve ilaçların bulunduğu eczane.", "eczane.jpg", true, false, true, "info@eczane.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2306), "Namık Eczanesi", "1234567890", "www.eczane.com" },
                    { 3, "Nişantaşı, Şişli, İstanbul, Türkiye", 3, 3, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2311), "Kalemlerden defterlere, kırtasiye malzemelerinin satıldığı dükkân.", "kirtasiye.jpg", false, false, false, "info@kirtasiye.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2311), "Ozan Kırtasiyesi", "1234567890", "www.kirtasiye.com" },
                    { 4, "Levent Mahallesi, Beşiktaş, İstanbul, Türkiye", 4, 4, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2316), "Kıyafet tamiratı ve dikimi yapan terzi dükkânı.", "terzi.jpg", true, false, true, "info@terzi.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2316), "Neşe Terzi", "1234567890", "www.terzi.com" },
                    { 5, "Bebek, Beşiktaş, İstanbul, Türkiye", 5, 5, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2322), "Diş sağlığı hizmetleri sunan dişçi kliniği.", "disci.jpg", false, false, false, "info@disci.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2323), "İtina Dişçi", "1234567890", "www.disci.com" },
                    { 6, "Moda Caddesi, Kadıköy, İstanbul, Türkiye", 6, 6, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2327), "Profesyonel hizmetlerle kiralık katil işleri yapan gizli dükkân.", "kiralik-katil.jpg", true, false, true, "info@kiralik-katil.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2328), "Prof Kiralık Katil", "1234567890", "www.kiralik-katil.com" },
                    { 7, "Sultanahmet Meydanı, Fatih, İstanbul, Türkiye", 7, 7, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2332), "Fitness ve spor salonu.", "gym.jpg", false, false, false, "info@gym.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2333), "Şişman Gym", "1234567890", "www.gym.com" },
                    { 8, "Ortaköy, Beşiktaş, İstanbul, Türkiye", 8, 8, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2338), "Lezzetli mantı çeşitlerinin servis edildiği mantı dükkânı.", "mantici.jpg", true, false, true, "info@mantici.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2338), "Enfes Mantıcı", "1234567890", "www.mantici.com" },
                    { 9, "Kadıköy İskelesi, Kadıköy, İstanbul, Türkiye", 9, 9, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2342), "Futbol oynamak için ideal bir saha.", "futbol-sahasi.jpg", false, false, false, "info@futbol-sahasi.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2343), "Yeşil Futbol Sahası", "1234567890", "www.futbol-sahasi.com" },
                    { 10, "Taksim Meydanı, Beyoğlu, İstanbul, Türkiye", 10, 10, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2348), "Ayakkabı tamir ve bakımı yapan lostra dükkânı.", "lostra.jpg", true, false, true, "info@lostra.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2348), "Dikkat Lostra", "1234567890", "www.lostra.com" },
                    { 11, "İstiklal Caddesi, Beyoğlu, İstanbul, Türkiye", 1, 11, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2352), "Sevilen mahalle bakkal amcanız.", "bakkal.jpg", false, false, false, "info@rafik-kasap.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2353), "Rafık Bakkal", "1234567890", "www.rafik-bakkal.com" },
                    { 12, "Ümraniye, İstanbul, Türkiye", 2, 12, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2358), "Lezzetli yemekler sunan restoran.", "restoran.jpg", true, false, false, "info@lezzet-restoran.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2358), "Lezzet Restoran", "1234567890", "www.lezzet-restoran.com" },
                    { 13, "Bahçe Sokak, Ankara, Türkiye", 3, 13, 6, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2362), "Keyifli bir ortamda kahve ve atıştırmalıklar sunan kafe.", "kafe.jpg", true, false, true, "info@keyifli-kafe.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2363), "Keyifli Kafe", "1234567890", "www.keyifli-kafe.com" },
                    { 14, "Bağdat Caddesi, Kadıköy, İstanbul, Türkiye", 4, 14, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2367), "Moda ve stilin buluştuğu şık butik mağaza.", "butik.jpg", true, false, false, "info@sik-butik.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2367), "Şık Butik", "1234567890", "www.sik-butik.com" },
                    { 15, "İzmir Caddesi, İzmir, Türkiye", 5, 15, 35, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2371), "Gözlük ve güneş gözlüğü mağazası.", "optik.jpg", false, false, false, "info@net-optik.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2372), "Net Optik", "1234567890", "www.net-optik.com" },
                    { 16, "Bağlar Sokak, Bursa, Türkiye", 6, 16, 16, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2377), "Konforlu ve şık mobilyaların satıldığı mağaza.", "mobilya.jpg", true, false, true, "info@rahat-mobilya.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2377), "Rahat Mobilya Mağazası", "1234567890", "www.rahat-mobilya.com" },
                    { 17, "Çocuklar Caddesi, Antalya, Türkiye", 7, 17, 7, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2383), "Eğlenceli ve renkli oyuncakların satıldığı oyuncakçı dükkanı.", "oyuncakci.jpg", true, false, false, "info@neseli-oyuncakci.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2384), "Neşeli Oyuncakçı", "1234567890", "www.neseli-oyuncakci.com" },
                    { 18, "Teknoloji Sokak, İzmit, Kocaeli Türkiye", 8, 18, 41, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2388), "Son teknoloji elektronik ürünlerin satıldığı mağaza.", "elektronik.jpg", false, false, false, "info@teknoloji-elektronik.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2388), "Teknoloji Elektronik Mağaza", "1234567890", "www.teknoloji-elektronik.com" },
                    { 19, "Çiçekler Sokak, Adana, Türkiye", 9, 19, 1, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2392), "Canlı ve renkli çiçeklerin satıldığı çiçekçi dükkanı.", "cicekci.jpg", true, false, true, "info@renkli-cicekci.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2393), "Renkli Çiçekçi", "1234567890", "www.renkli-cicekci.com" },
                    { 20, "Kitaplar Sokak, İstanbul, Türkiye", 10, 20, 34, new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2397), "Geniş bir kitap koleksiyonuna sahip olan kitapçı.", "kitapci.jpg", true, false, false, "info@bilge-kitapci.com", new DateTime(2023, 7, 11, 15, 49, 16, 765, DateTimeKind.Local).AddTicks(2397), "Bilge Kitapçı", "1234567890", "www.bilge-kitapci.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shops_BossId",
                table: "Shops",
                column: "BossId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CategoryId",
                table: "Shops",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CityId",
                table: "Shops",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
