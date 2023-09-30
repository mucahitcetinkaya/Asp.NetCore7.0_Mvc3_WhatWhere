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

            builder.Property(x => x.Ilce).IsRequired().HasConversion(
                v => string.Join(",", v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));

            builder.HasData
            (
               new City
               {
                   Id = 1,
                   Sehir = "Adana",
                   Ilce = new string[]
                   {
                       "Aladağ",
                       "Ceyhan",
                       "Çukurova",
                       "Feke",
                       "İmamoğlu",
                       "Karaisalı",
                       "Karataş",
                       "Kozan",
                       "Pozantı",
                       "Saimbeyli",
                       "Sarıçam",
                       "Seyhan",
                       "Tufanbeyli",
                       "Yumurtalık",
                       "Yüreğir"
                   }
               },
            new City
            {
                Id = 2,
                Sehir = "Adıyaman",
                Ilce = new string[]
                {
                       "Besni",
                       "Çelikhan",
                       "Gerger",
                       "Gölbaşı",
                       "Kahta",
                       "Merkez",
                       "Samsat",
                       "Sincik",
                       "Tut"
                }
            },
               new City
               {
                   Id = 3,
                   Sehir = "Afyonkarahisar",
                   Ilce = new string[]
                   {
                       "Başmakçı",
                       "Bayat",
                       "Bolvadin",
                       "Çay",
                       "Çobanlar",
                       "Dazkırı",
                       "Dinar",
                       "Emirdağ",
                       "Evciler",
                       "Hocalar",
                       "İhsaniye",
                       "İscehisar",
                       "Kızılören",
                       "Merkez",
                       "Sandıklı",
                       "Sinanpaşa",
                       "Sultandağı",
                       "Şuhut"
                   }
               },
               new City
               {
                   Id = 4,
                   Sehir = "Ağrı",
                   Ilce = new string[]
                   {
                       "Diyadin",
                       "Doğubayazıt",
                       "Eleşkirt",
                       "Hamur",
                       "Merkez",
                       "Patnos",
                       "Taşlıçay",
                       "Tutak"
                   }
               },
               new City
               {
                   Id = 5,
                   Sehir = "Amasya",
                   Ilce = new string[]
                   {
                       "Göynücek",
                       "Gümüşhacıköy",
                       "Hamamözü",
                       "Merkez",
                       "Merzifon",
                       "Suluova",
                       "Taşova"
                   }
               },
               new City
               {
                   Id = 6,
                   Sehir = "Ankara",
                   Ilce = new string[]
                   {
                       "Altındağ",
                       "Ayaş",
                       "Bala",
                       "Beypazarı",
                       "Çamlıdere",
                       "Çankaya",
                       "Çubuk",
                       "Elmadağ",
                       "Güdül",
                       "Haymana",
                       "Kalecik",
                       "Kızılcahamam",
                       "Nallıhan",
                       "Polatlı",
                       "Şereflikoçhisar",
                       "Yenimahalle",
                       "Gölbaşı",
                       "Keçiören",
                       "Mamak",
                       "Sincan",
                       "Kazan",
                       "Akyurt",
                       "Etimesgut",
                       "Evren",
                       "Pursaklar"
                   }
               },
               new City
               {
                   Id = 7,
                   Sehir = "Antalya",
                   Ilce = new string[]
                   {
                       "Akseki",
                       "Alanya",
                       "Elmalı",
                       "Finike",
                       "Gazipaşa",
                       "Gündoğmuş",
                       "Kaş",
                       "Korkuteli",
                       "Kumluca",
                       "Manavgat",
                       "Serik",
                       "Demre",
                       "İbradı",
                       "Kemer",
                       "Aksu",
                       "Döşemealtı",
                       "Kepez",
                       "Konyaaltı",
                       "Muratpaşa"
                   }
               },
               new City
               {
                   Id = 8,
                   Sehir = "Artvin",
                   Ilce = new string[]
                   {
                       "Ardanuç",
                       "Arhavi",
                       "Merkez",
                       "Borçka",
                       "Hopa",
                       "Şavşat",
                       "Yusufeli",
                       "Murgul"
                   }
               },
               new City
               {
                   Id = 9,
                   Sehir = "Aydın",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Bozdoğan",
                       "Efeler",
                       "Çine",
                       "Germencik",
                       "Karacasu",
                       "Koçarlı",
                       "Kuşadası",
                       "Kuyucak",
                       "Nazilli",
                       "Söke",
                       "Sultanhisar",
                       "Yenipazar",
                       "Buharkent",
                       "İncirliova",
                       "Karpuzlu",
                       "Köşk",
                       "Didim"
                   }
               },
               new City
               {
                   Id = 10,
                   Sehir = "Balıkesir",
                   Ilce = new string[]
                   {
                       "Altıeylül",
                       "Ayvalık",
                       "Merkez",
                       "Balya",
                       "Bandırma",
                       "Bigadiç",
                       "Burhaniye",
                       "Dursunbey",
                       "Edremit",
                       "Erdek",
                       "Gönen",
                       "Havran",
                       "İvrindi",
                       "Karesi",
                       "Kepsut",
                       "Manyas",
                       "Savaştepe",
                       "Sındırgı",
                       "Gömeç",
                       "Susurluk",
                       "Marmara"
                   }
               },
               new City
               {
                   Id = 11,
                   Sehir = "Bilecik",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Bozüyük",
                       "Gölpazarı",
                       "Osmaneli",
                       "Pazaryeri",
                       "Söğüt",
                       "Yenipazar",
                       "İnhisar"
                   }
               },
               new City
               {
                   Id = 12,
                   Sehir = "Bingöl",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Genç",
                       "Karlıova",
                       "Kiğı",
                       "Solhan",
                       "Adaklı",
                       "Yayladere",
                       "Yedisu"
                   }
               },
               new City
               {
                   Id = 13,
                   Sehir = "Bitlis",
                   Ilce = new string[]
                   {
                       "Adilcevaz",
                       "Ahlat",
                       "Merkez",
                       "Hizan",
                       "Mutki",
                       "Tatvan",
                       "Güroymak"
                   }
               },
               new City
               {
                   Id = 14,
                   Sehir = "Bolu",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Gerede",
                       "Göynük",
                       "Kıbrıscık",
                       "Mengen",
                       "Mudurnu",
                       "Seben",
                       "Dörtdivan",
                       "Yeniçağa"
                   }
               },
               new City
               {
                   Id = 15,
                   Sehir = "Burdur",
                   Ilce = new string[]
                   {
                       "Ağlasun",
                       "Bucak",
                       "Merkez",
                       "Gölhisar",
                       "Tefenni",
                       "Yeşilova",
                       "Karamanlı",
                       "Kemer",
                       "Altınyayla",
                       "Çavdır",
                       "Çeltikçi"
                   }
               },
               new City
               {
                   Id = 16,
                   Sehir = "Bursa",
                   Ilce = new string[]
                   {
                       "Gemlik",
                       "İnegöl",
                       "İznik",
                       "Karacabey",
                       "Keles",
                       "Mudanya",
                       "Mustafakemalpaşa",
                       "Orhaneli",
                       "Orhangazi",
                       "Yenişehir",
                       "Büyükorhan",
                       "Harmancık",
                       "Nilüfer",
                       "Osmangazi",
                       "Yıldırım",
                       "Gürsu",
                       "Kestel"
                   }
               },
               new City
               {
                   Id = 17,
                   Sehir = "Çanakkale",
                   Ilce = new string[]
                   {
                       "Ayvacık",
                       "Bayramiç",
                       "Biga",
                       "Bozcaada",
                       "Çan",
                       "Merkez",
                       "Eceabat",
                       "Ezine",
                       "Gelibolu",
                       "Gökçeada",
                       "Lapseki",
                       "Yenice"
                   }
               },
               new City
               {
                   Id = 18,
                   Sehir = "Çankırı",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Çerkeş",
                       "Eldivan",
                       "Ilgaz",
                       "Kurşunlu",
                       "Orta",
                       "Şabanözü",
                       "Yapraklı",
                       "Atkaracalar",
                       "Kızılırmak",
                       "Bayramören",
                       "Korgun"
                   }
               },
               new City
               {
                   Id = 19,
                   Sehir = "Çorum",
                   Ilce = new string[]
                   {
                       "Alaca",
                       "Bayat",
                       "Merkez",
                       "İskilip",
                       "Kargı",
                       "Mecitözü",
                       "Ortaköy",
                       "Osmancık",
                       "Sungurlu",
                       "Boğazkale",
                       "Uğurludağ",
                       "Dodurga",
                       "Laçin",
                       "Oğuzlar"
                   }
               },
               new City
               {
                   Id = 20,
                   Sehir = "Denizli",
                   Ilce = new string[]
                   {
                       "Acıpayam",
                       "Buldan",
                       "Çal",
                       "Çameli",
                       "Çardak",
                       "Çivril",
                       "Merkez",
                       "Merkezefendi",
                       "Pamukkale",
                       "Güney",
                       "Kale",
                       "Sarayköy",
                       "Tavas",
                       "Babadağ",
                       "Bekilli",
                       "Honaz",
                       "Serinhisar",
                       "Baklan",
                       "Beyağaç",
                       "Bozkurt"
                   }
               },
               new City
               {
                   Id = 21,
                   Sehir = "Diyarbakır",
                   Ilce = new string[]
                   {
                       "Kocaköy",
                       "Çermik",
                       "Çınar",
                       "Çüngüş",
                       "Dicle",
                       "Ergani",
                       "Hani",
                       "Hazro",
                       "Kulp",
                       "Lice",
                       "Silvan",
                       "Eğil",
                       "Bağlar",
                       "Kayapınar",
                       "Sur",
                       "Yenişehir",
                       "Bismil"
                   }
               },
               new City
               {
                   Id = 22,
                   Sehir = "Edirne",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Enez",
                       "Havsa",
                       "İpsala",
                       "Keşan",
                       "Lalapaşa",
                       "Meriç",
                       "Uzunköprü",
                       "Süloğlu"
                   }
               },
               new City
               {
                   Id = 23,
                   Sehir = "Elazığ",
                   Ilce = new string[]
                   {
                       "Ağın",
                       "Baskil",
                       "Merkez",
                       "Karakoçan",
                       "Keban",
                       "Maden",
                       "Palu",
                       "Sivrice",
                       "Arıcak",
                       "Kovancılar",
                       "Alacakaya"
                   }
               },
               new City
               {
                   Id = 24,
                   Sehir = "Erzincan",
                   Ilce = new string[]
                   {
                       "Çayırlı",
                       "Merkez",
                       "İliç",
                       "Kemah",
                       "Kemaliye",
                       "Refahiye",
                       "Tercan",
                       "Üzümlü",
                       "Otlukbeli"
                   }
               },
               new City
               {
                   Id = 25,
                   Sehir = "Erzurum",
                   Ilce = new string[]
                   {
                       "Aşkale",
                       "Çat",
                       "Hınıs",
                       "Horasan",
                       "İspir",
                       "Karayazı",
                       "Narman",
                       "Oltu",
                       "Olur",
                       "Pasinler",
                       "Şenkaya",
                       "Tekman",
                       "Tortum",
                       "Karaçoban",
                       "Uzundere",
                       "Pazaryolu",
                       "Köprüköy",
                       "Palandöken",
                       "Yakutiye",
                       "Aziziye"
                   }
               },
               new City
               {
                   Id = 26,
                   Sehir = "Eskişehir",
                   Ilce = new string[]
                   {
                       "Çifteler",
                       "Mahmudiye",
                       "Mihalıççık",
                       "Sarıcakaya",
                       "Seyitgazi",
                       "Sivrihisar",
                       "Alpu",
                       "Beylikova",
                       "İnönü",
                       "Günyüzü",
                       "Han",
                       "Mihalgazi",
                       "Odunpazarı",
                       "Tepebaşı"
                   }
               },
               new City
               {
                   Id = 27,
                   Sehir = "Gaziantep",
                   Ilce = new string[]
                   {
                       "Araban",
                       "İslahiye",
                       "Nizip",
                       "Oğuzeli",
                       "Yavuzeli",
                       "Şahinbey",
                       "Şehitkamil",
                       "Karkamış",
                       "Nurdağı"
                   }
               },
               new City
               {
                   Id = 28,
                   Sehir = "Giresun",
                   Ilce = new string[]
                   {
                       "Alucra",
                       "Bulancak",
                       "Dereli",
                       "Espiye",
                       "Eynesil",
                       "Merkez",
                       "Görele",
                       "Keşap",
                       "Şebinkarahisar",
                       "Tirebolu",
                       "Piraziz",
                       "Yağlıdere",
                       "Çamoluk",
                       "Çanakçı",
                       "Doğankent",
                       "Güce"
                   }
               },
               new City
               {
                   Id = 29,
                   Sehir = "Gümüşhane",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Kelkit",
                       "Şiran",
                       "Torul",
                       "Köse",
                       "Kürtün"
                   }
               },
               new City
               {
                   Id = 30,
                   Sehir = "Hakkari",
                   Ilce = new string[]
                   {
                       "Çukurca",
                       "Merkez",
                       "Şemdinli",
                       "Yüksekova"
                   }
               },
               new City
               {
                   Id = 31,
                   Sehir = "Hatay",
                   Ilce = new string[]
                   {
                       "Altınözü",
                       "Arsuz",
                       "Defne",
                       "Dörtyol",
                       "Hassa",
                       "Antakya",
                       "İskenderun",
                       "Kırıkhan",
                       "Payas",
                       "Reyhanlı",
                       "Samandağ",
                       "Yayladağı",
                       "Erzin",
                       "Belen",
                       "Kumlu"
                   }
               },
               new City
               {
                   Id = 32,
                   Sehir = "Isparta",
                   Ilce = new string[]
                   {
                       "Atabey",
                       "Eğirdir",
                       "Gelendost",
                       "Merkez",
                       "Keçiborlu",
                       "Senirkent",
                       "Sütçüler",
                       "Şarkikaraağaç",
                       "Uluborlu",
                       "Yalvaç",
                       "Aksu",
                       "Gönen",
                       "Yenişarbademli"
                   }
               },
               new City
               {
                   Id = 33,
                   Sehir = "Mersin",
                   Ilce = new string[]
                   {
                       "Anamur",
                       "Erdemli",
                       "Gülnar",
                       "Mut",
                       "Silifke",
                       "Tarsus",
                       "Aydıncık",
                       "Bozyazı",
                       "Çamlıyayla",
                       "Akdeniz",
                       "Mezitli",
                       "Toroslar",
                       "Yenişehir"
                   }
               },
               new City
               {
                   Id = 34,
                   Sehir = "İstanbul",
                   Ilce = new string[]
                   {
                       "Adalar",
                       "Bakırköy",
                       "Beşiktaş",
                       "Beykoz",
                       "Beyoğlu",
                       "Çatalca",
                       "Eyüp",
                       "Fatih",
                       "Gaziosmanpaşa",
                       "Kadıköy",
                       "Kartal",
                       "Sarıyer",
                       "Silivri",
                       "Şile",
                       "Şişli",
                       "Üsküdar",
                       "Zeytinburnu",
                       "Büyükçekmece",
                       "Kağıthane",
                       "Küçükçekmece",
                       "Pendik",
                       "Ümraniye",
                       "Bayrampaşa",
                       "Avcılar",
                       "Bağcılar",
                       "Bahçelievler",
                       "Güngören",
                       "Maltepe",
                       "Sultanbeyli",
                       "Tuzla",
                       "Esenler",
                       "Arnavutköy",
                       "Ataşehir",
                       "Başakşehir",
                       "Beylikdüzü",
                       "Çekmeköy",
                       "Esenyurt",
                       "Sancaktepe",
                       "Sultangazi"
                   }
               },
               new City
               {
                   Id = 35,
                   Sehir = "İzmir",
                   Ilce = new string[]
                   {
                       "Aliağa",
                       "Bayındır",
                       "Bergama",
                       "Bornova",
                       "Çeşme",
                       "Dikili",
                       "Foça",
                       "Karaburun",
                       "Karşıyaka",
                       "Kemalpaşa",
                       "Kınık",
                       "Kiraz",
                       "Menemen",
                       "Ödemiş",
                       "Seferihisar",
                       "Selçuk",
                       "Tire",
                       "Torbalı",
                       "Urla",
                       "Beydağ",
                       "Buca",
                       "Konak",
                       "Menderes",
                       "Balçova",
                       "Çiğli",
                       "Gaziemir",
                       "Narlıdere",
                       "Güzelbahçe",
                       "Bayraklı",
                       "Karabağlar"
                   }
               },
               new City
               {
                   Id = 36,
                   Sehir = "Kars",
                   Ilce = new string[]
                   {
                       "Arpaçay",
                       "Digor",
                       "Kağızman",
                       "Merkez",
                       "Sarıkamış",
                       "Selim",
                       "Susuz",
                       "Akyaka"
                   }
               },
               new City
               {
                   Id = 37,
                   Sehir = "Kastamonu",
                   Ilce = new string[]
                   {
                       "Abana",
                       "Araç",
                       "Azdavay",
                       "Bozkurt",
                       "Cide",
                       "Çatalzeytin",
                       "Daday",
                       "Devrekani",
                       "İnebolu",
                       "Merkez",
                       "Küre",
                       "Taşköprü",
                       "Tosya",
                       "İhsangazi",
                       "Pınarbaşı",
                       "Şenpazar",
                       "Ağlı",
                       "Doğanyurt",
                       "Hanönü",
                       "Seydiler"
                   }
               },
               new City
               {
                   Id = 38,
                   Sehir = "Kayseri",
                   Ilce = new string[]
                   {
                       "Bünyan",
                       "Develi",
                       "Felahiye",
                       "İncesu",
                       "Pınarbaşı",
                       "Sarıoğlan",
                       "Sarız",
                       "Tomarza",
                       "Yahyalı",
                       "Yeşilhisar",
                       "Akkışla",
                       "Talas",
                       "Kocasinan",
                       "Melikgazi",
                       "Hacılar",
                       "Özvatan"
                   }
               },
               new City
               {
                   Id = 39,
                   Sehir = "Kırklareli",
                   Ilce = new string[]
                   {
                       "Babaeski",
                       "Demirköy",
                       "Merkez",
                       "Kofçaz",
                       "Lüleburgaz",
                       "Pehlivanköy",
                       "Pınarhisar",
                       "Vize"
                   }
               },
               new City
               {
                   Id = 40,
                   Sehir = "Kırşehir",
                   Ilce = new string[]
                   {
                       "Çiçekdağı",
                       "Kaman",
                       "Merkez",
                       "Mucur",
                       "Akpınar",
                       "Akçakent",
                       "Boztepe"
                   }
               },
               new City
               {
                   Id = 41,
                   Sehir = "Kocaeli",
                   Ilce = new string[]
                   {
                       "Gebze",
                       "Gölcük",
                       "Kandıra",
                       "Karamürsel",
                       "Körfez",
                       "Derince",
                       "Başiskele",
                       "Çayırova",
                       "Darıca",
                       "Dilovası",
                       "İzmit",
                       "Kartepe"
                   }
               },
               new City
               {
                   Id = 42,
                   Sehir = "Konya",
                   Ilce = new string[]
                   {
                       "Akşehir",
                       "Beyşehir",
                       "Bozkır",
                       "Cihanbeyli",
                       "Çumra",
                       "Doğanhisar",
                       "Ereğli",
                       "Hadim",
                       "Ilgın",
                       "Kadınhanı",
                       "Karapınar",
                       "Kulu",
                       "Sarayönü",
                       "Seydişehir",
                       "Yunak",
                       "Akören",
                       "Altınekin",
                       "Derebucak",
                       "Hüyük",
                       "Karatay",
                       "Meram",
                       "Selçuklu",
                       "Taşkent",
                       "Ahırlı",
                       "Çeltik",
                       "Derbent",
                       "Emirgazi",
                       "Güneysınır",
                       "Halkapınar",
                       "Tuzlukçu",
                       "Yalıhüyük"
                   }
               },
               new City
               {
                   Id = 43,
                   Sehir = "Kütahya",
                   Ilce = new string[]
                   {
                       "Altıntaş",
                       "Domaniç",
                       "Emet",
                       "Gediz",
                       "Merkez",
                       "Simav",
                       "Tavşanlı",
                       "Aslanapa",
                       "Dumlupınar",
                       "Hisarcık",
                       "Şaphane",
                       "Çavdarhisar",
                       "Pazarlar"
                   }
               },
               new City
               {
                   Id = 44,
                   Sehir = "Malatya",
                   Ilce = new string[]
                   {
                       "Akçadağ",
                       "Arapgir",
                       "Arguvan",
                       "Darende",
                       "Doğanşehir",
                       "Hekimhan",
                       "Merkez",
                       "Pütürge",
                       "Yeşilyurt",
                       "Battalgazi",
                       "Doğanyol",
                       "Kale",
                       "Kuluncak",
                       "Yazıhan"
                   }
               },
               new City
               {
                   Id = 45,
                   Sehir = "Manisa",
                   Ilce = new string[]
                   {
                       "Akhisar",
                       "Alaşehir",
                       "Demirci",
                       "Gördes",
                       "Kırkağaç",
                       "Kula",
                       "Merkez",
                       "Salihli",
                       "Sarıgöl",
                       "Saruhanlı",
                       "Selendi",
                       "Soma",
                       "Şehzadeler",
                       "Yunusemre",
                       "Turgutlu",
                       "Ahmetli",
                       "Gölmarmara",
                       "Köprübaşı"
                   }
               },
               new City
               {
                   Id = 46,
                   Sehir = "Kahramanmaraş",
                   Ilce = new string[]
                   {
                       "Afşin",
                       "Andırın",
                       "Dulkadiroğlu",
                       "Onikişubat",
                       "Elbistan",
                       "Göksun",
                       "Merkez",
                       "Pazarcık",
                       "Türkoğlu",
                       "Çağlayancerit",
                       "Ekinözü",
                       "Nurhak"
                   }
               },
               new City
               {
                   Id = 47,
                   Sehir = "Mardin",
                   Ilce = new string[]
                   {
                       "Derik",
                       "Kızıltepe",
                       "Artuklu",
                       "Merkez",
                       "Mazıdağı",
                       "Midyat",
                       "Nusaybin",
                       "Ömerli",
                       "Savur",
                       "Dargeçit",
                       "Yeşilli"
                   }
               },
               new City
               {
                   Id = 48,
                   Sehir = "Muğla",
                   Ilce = new string[]
                   {
                       "Bodrum",
                       "Datça",
                       "Fethiye",
                       "Köyceğiz",
                       "Marmaris",
                       "Menteşe",
                       "Milas",
                       "Ula",
                       "Yatağan",
                       "Dalaman",
                       "Seydikemer",
                       "Ortaca",
                       "Kavaklıdere"
                   }
               },
               new City
               {
                   Id = 49,
                   Sehir = "Muş",
                   Ilce = new string[]
                   {
                       "Bulanık",
                       "Malazgirt",
                       "Merkez",
                       "Varto",
                       "Hasköy",
                       "Korkut"
                   }
               },
               new City
               {
                   Id = 50,
                   Sehir = "Nevşehir",
                   Ilce = new string[]
                   {
                       "Avanos",
                       "Derinkuyu",
                       "Gülşehir",
                       "Hacıbektaş",
                       "Kozaklı",
                       "Merkez",
                       "Ürgüp",
                       "Acıgöl"
                   }
               },
               new City
               {
                   Id = 51,
                   Sehir = "Niğde",
                   Ilce = new string[]
                   {
                       "Bor",
                       "Çamardı",
                       "Merkez",
                       "Ulukışla",
                       "Altunhisar",
                       "Çiftlik"
                   }
               },
               new City
               {
                   Id = 52,
                   Sehir = "Ordu",
                   Ilce = new string[]
                   {
                       "Akkuş",
                       "Altınordu",
                       "Aybastı",
                       "Fatsa",
                       "Gölköy",
                       "Korgan",
                       "Kumru",
                       "Mesudiye",
                       "Perşembe",
                       "Ulubey",
                       "Ünye",
                       "Gülyalı",
                       "Gürgentepe",
                       "Çamaş",
                       "Çatalpınar",
                       "Çaybaşı",
                       "İkizce",
                       "Kabadüz",
                       "Kabataş"
                   }
               },
               new City
               {
                   Id = 53,
                   Sehir = "Rize",
                   Ilce = new string[]
                   {
                       "Ardeşen",
                       "Çamlıhemşin",
                       "Çayeli",
                       "Fındıklı",
                       "İkizdere",
                       "Kalkandere",
                       "Pazar",
                       "Merkez",
                       "Güneysu",
                       "Derepazarı",
                       "Hemşin",
                       "İyidere"
                   }
               },
               new City
               {
                   Id = 54,
                   Sehir = "Sakarya",
                   Ilce = new string[]
                   {
                       "Akyazı",
                       "Geyve",
                       "Hendek",
                       "Karasu",
                       "Kaynarca",
                       "Sapanca",
                       "Kocaali",
                       "Pamukova",
                       "Taraklı",
                       "Ferizli",
                       "Karapürçek",
                       "Söğütlü",
                       "Adapazarı",
                       "Arifiye",
                       "Erenler",
                       "Serdivan"
                   }
               },
               new City
               {
                   Id = 55,
                   Sehir = "Samsun",
                   Ilce = new string[]
                   {
                       "Alaçam",
                       "Bafra",
                       "Çarşamba",
                       "Havza",
                       "Kavak",
                       "Ladik",
                       "Terme",
                       "Vezirköprü",
                       "Asarcık",
                       "Ondokuzmayıs",
                       "Salıpazarı",
                       "Tekkeköy",
                       "Ayvacık",
                       "Yakakent",
                       "Atakum",
                       "Canik",
                       "İlkadım"
                   }
               },
               new City
               {
                   Id = 56,
                   Sehir = "Siirt",
                   Ilce = new string[]
                   {
                       "Baykan",
                       "Eruh",
                       "Kurtalan",
                       "Pervari",
                       "Merkez",
                       "Şirvan",
                       "Tillo"
                   }
               },
               new City
               {
                   Id = 57,
                   Sehir = "Sinop",
                   Ilce = new string[]
                   {
                       "Ayancık",
                       "Boyabat",
                       "Durağan",
                       "Erfelek",
                       "Gerze",
                       "Merkez",
                       "Türkeli",
                       "Dikmen",
                       "Saraydüzü"
                   }
               },
               new City
               {
                   Id = 58,
                   Sehir = "Sivas",
                   Ilce = new string[]
                   {
                       "Divriği",
                       "Gemerek",
                       "Gürün",
                       "Hafik",
                       "İmranlı",
                       "Kangal",
                       "Koyulhisar",
                       "Merkez",
                       "Suşehri",
                       "Şarkışla",
                       "Yıldızeli",
                       "Zara",
                       "Akıncılar",
                       "Altınyayla",
                       "Doğanşar",
                       "Gölova",
                       "Ulaş"
                   }
               },
               new City
               {
                   Id = 59,
                   Sehir = "Tekirdağ",
                   Ilce = new string[]
                   {
                       "Çerkezköy",
                       "Çorlu",
                       "Ergene",
                       "Hayrabolu",
                       "Malkara",
                       "Muratlı",
                       "Saray",
                       "Süleymanpaşa",
                       "Kapaklı",
                       "Şarköy",
                       "Marmaraereğlisi"
                   }
               },
               new City
               {
                   Id = 60,
                   Sehir = "Tokat",
                   Ilce = new string[]
                   {
                       "Almus",
                       "Artova",
                       "Erbaa",
                       "Niksar",
                       "Reşadiye",
                       "Merkez",
                       "Turhal",
                       "Zile",
                       "Pazar",
                       "Yeşilyurt",
                       "Başçiftlik",
                       "Sulusaray"
                   }
               },
               new City
               {
                   Id = 61,
                   Sehir = "Trabzon",
                   Ilce = new string[]
                   {
                       "Akçaabat",
                       "Araklı",
                       "Arsin",
                       "Çaykara",
                       "Maçka",
                       "Of",
                       "Ortahisar",
                       "Sürmene",
                       "Tonya",
                       "Vakfıkebir",
                       "Yomra",
                       "Beşikdüzü",
                       "Şalpazarı",
                       "Çarşıbaşı",
                       "Dernekpazarı",
                       "Düzköy",
                       "Hayrat",
                       "Köprübaşı"
                   }
               },
               new City
               {
                   Id = 62,
                   Sehir = "Tunceli",
                   Ilce = new string[]
                   {
                       "Çemişgezek",
                       "Hozat",
                       "Mazgirt",
                       "Nazımiye",
                       "Ovacık",
                       "Pertek",
                       "Pülümür",
                       "Merkez"
                   }
               },
               new City
               {
                   Id = 63,
                   Sehir = "Şanlıurfa",
                   Ilce = new string[]
                   {
                       "Akçakale",
                       "Birecik",
                       "Bozova",
                       "Ceylanpınar",
                       "Eyyübiye",
                       "Halfeti",
                       "Haliliye",
                       "Hilvan",
                       "Karaköprü",
                       "Siverek",
                       "Suruç",
                       "Viranşehir",
                       "Harran"
                   }
               },
               new City
               {
                   Id = 64,
                   Sehir = "Uşak",
                   Ilce = new string[]
                   {
                       "Banaz",
                       "Eşme",
                       "Karahallı",
                       "Sivaslı",
                       "Ulubey",
                       "Merkez"
                   }
               },
               new City
               {
                   Id = 65,
                   Sehir = "Van",
                   Ilce = new string[]
                   {
                       "Başkale",
                       "Çatak",
                       "Erciş",
                       "Gevaş",
                       "Gürpınar",
                       "İpekyolu",
                       "Muradiye",
                       "Özalp",
                       "Tuşba",
                       "Bahçesaray",
                       "Çaldıran",
                       "Edremit",
                       "Saray"
                   }
               },
               new City
               {
                   Id = 66,
                   Sehir = "Yozgat",
                   Ilce = new string[]
                   {
                       "Akdağmadeni",
                       "Boğazlıyan",
                       "Çayıralan",
                       "Çekerek",
                       "Sarıkaya",
                       "Sorgun",
                       "Şefaatli",
                       "Yerköy",
                       "Merkez",
                       "Aydıncık",
                       "Çandır",
                       "Kadışehri",
                       "Saraykent",
                       "Yenifakılı"
                   }
               },
               new City
               {
                   Id = 67,
                   Sehir = "Zonguldak",
                   Ilce = new string[]
                   {
                       "Çaycuma",
                       "Devrek",
                       "Ereğli",
                       "Merkez",
                       "Alaplı",
                       "Gökçebey"
                   }
               },
               new City
               {
                   Id = 68,
                   Sehir = "Aksaray",
                   Ilce = new string[]
                   {
                       "Ağaçören",
                       "Eskil",
                       "Gülağaç",
                       "Güzelyurt",
                       "Merkez",
                       "Ortaköy",
                       "Sarıyahşi"
                   }
               },
               new City
               {
                   Id = 69,
                   Sehir = "Bayburt",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Aydıntepe",
                       "Demirözü"
                   }
               },
               new City
               {
                   Id = 70,
                   Sehir = "Karaman",
                   Ilce = new string[]
                   {
                       "Ermenek",
                       "Merkez",
                       "Ayrancı",
                       "Kazımkarabekir",
                       "Başyayla",
                       "Sarıveliler"
                   }
               },
               new City
               {
                   Id = 71,
                   Sehir = "Kırıkkale",
                   Ilce = new string[]
                   {
                       "Delice",
                       "Keskin",
                       "Merkez",
                       "Sulakyurt",
                       "Bahşili",
                       "Balışeyh",
                       "Çelebi",
                       "Karakeçili",
                       "Yahşihan"
                   }
               },
               new City
               {
                   Id = 72,
                   Sehir = "Batman",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Beşiri",
                       "Gercüş",
                       "Kozluk",
                       "Sason",
                       "Hasankeyf"
                   }
               },
               new City
               {
                   Id = 73,
                   Sehir = "Şırnak",
                   Ilce = new string[]
                   {
                       "Beytüşşebap",
                       "Cizre",
                       "İdil",
                       "Silopi",
                       "Merkez",
                       "Uludere",
                       "Güçlükonak"
                   }
               },
               new City
               {
                   Id = 74,
                   Sehir = "Bartın",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Kurucaşile",
                       "Ulus",
                       "Amasra"
                   }
               },
               new City
               {
                   Id = 75,
                   Sehir = "Ardahan",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Çıldır",
                       "Göle",
                       "Hanak",
                       "Posof",
                       "Damal"
                   }
               },
               new City
               {
                   Id = 76,
                   Sehir = "Iğdır",
                   Ilce = new string[]
                   {
                       "Aralık",
                       "Merkez",
                       "Tuzluca",
                       "Karakoyunlu"
                   }
               },
               new City
               {
                   Id = 77,
                   Sehir = "Yalova",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Altınova",
                       "Armutlu",
                       "Çınarcık",
                       "Çiftlikköy",
                       "Termal"
                   }
               },
               new City
               {
                   Id = 78,
                   Sehir = "Karabük",
                   Ilce = new string[]
                   {
                       "Eflani",
                       "Eskipazar",
                       "Merkez",
                       "Ovacık",
                       "Safranbolu",
                       "Yenice"
                   }
               },
               new City
               {
                   Id = 79,
                   Sehir = "Kilis",
                   Ilce = new string[]
                   {
                       "Merkez",
                       "Elbeyli",
                       "Musabeyli",
                       "Polateli"
                   }
               },
               new City
               {
                   Id = 80,
                   Sehir = "Osmaniye",
                   Ilce = new string[]
                   {
                       "Bahçe",
                       "Kadirli",
                       "Merkez",
                       "Düziçi",
                       "Hasanbeyli",
                       "Sumbas",
                       "Toprakkale"
                   }
               },
               new City
               {
                   Id = 81,
                   Sehir = "Düzce",
                   Ilce = new string[]
                   {
                       "Akçakoca",
                       "Merkez",
                       "Yığılca",
                       "Cumayeri",
                       "Gölyaka",
                       "Çilimli",
                       "Gümüşova",
                       "Kaynaşlı"
                   }
               }


            );
        }
    }
}
