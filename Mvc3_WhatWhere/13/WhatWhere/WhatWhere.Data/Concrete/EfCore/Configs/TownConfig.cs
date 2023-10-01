using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Configs
{
    public class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Ilce).IsRequired();

            builder.HasOne(t => t.City)
            .WithMany(c => c.Towns)
            .HasForeignKey(t => t.CityId)
            .IsRequired();

            //builder.HasOne(s => s.Categories)
            //.WithMany(b => b.Towns)
            //.HasForeignKey(s => s.BossId)
            //.OnDelete(DeleteBehavior.SetNull);

            builder.HasData
            (

                // Adana ilinin ilçeleri

                new Town { Id = 1, CityId = 1, Ilce = "Aladağ" },
                new Town { Id = 2, CityId = 1, Ilce = "Ceyhan" },
                new Town { Id = 3, CityId = 1, Ilce = "Çukurova" },
                new Town { Id = 4, CityId = 1, Ilce = "Feke" },
                new Town { Id = 5, CityId = 1, Ilce = "İmamoğlu" },
                new Town { Id = 6, CityId = 1, Ilce = "Karaisalı" },
                new Town { Id = 7, CityId = 1, Ilce = "Karataş" },
                new Town { Id = 8, CityId = 1, Ilce = "Kozan" },
                new Town { Id = 9, CityId = 1, Ilce = "Pozantı" },
                new Town { Id = 10, CityId = 1, Ilce = "Saimbeyli" },
                new Town { Id = 11, CityId = 1, Ilce = "Sarıçam" },
                new Town { Id = 12, CityId = 1, Ilce = "Seyhan" },
                new Town { Id = 13, CityId = 1, Ilce = "Tufanbeyli" },
                new Town { Id = 14, CityId = 1, Ilce = "Yumurtalık" },
                new Town { Id = 15, CityId = 1, Ilce = "Yüreğir" },

                // Adıyaman ilinin ilçeleri

                new Town { Id = 16, CityId = 2, Ilce = "Besni" },
                new Town { Id = 17, CityId = 2, Ilce = "Çelikhan" },
                new Town { Id = 18, CityId = 2, Ilce = "Gerger" },
                new Town { Id = 19, CityId = 2, Ilce = "Gölbaşı" },
                new Town { Id = 20, CityId = 2, Ilce = "Kahta" },
                new Town { Id = 21, CityId = 2, Ilce = "Merkez" },
                new Town { Id = 22, CityId = 2, Ilce = "Samsat" },
                new Town { Id = 23, CityId = 2, Ilce = "Sincik" },
                new Town { Id = 24, CityId = 2, Ilce = "Tut" },

                // Afyonkarahisar ilinin ilçeleri

                new Town { Id = 25, CityId = 3, Ilce = "Başmakçı" },
                new Town { Id = 26, CityId = 3, Ilce = "Bayat" },
                new Town { Id = 27, CityId = 3, Ilce = "Bolvadin" },
                new Town { Id = 28, CityId = 3, Ilce = "Çay" },
                new Town { Id = 29, CityId = 3, Ilce = "Çobanlar" },
                new Town { Id = 30, CityId = 3, Ilce = "Dazkırı" },
                new Town { Id = 31, CityId = 3, Ilce = "Dinar" },
                new Town { Id = 32, CityId = 3, Ilce = "Emirdağ" },
                new Town { Id = 33, CityId = 3, Ilce = "Evciler" },
                new Town { Id = 34, CityId = 3, Ilce = "Hocalar" },
                new Town { Id = 35, CityId = 3, Ilce = "İhsaniye" },
                new Town { Id = 36, CityId = 3, Ilce = "İscehisar" },
                new Town { Id = 37, CityId = 3, Ilce = "Kızılören" },
                new Town { Id = 38, CityId = 3, Ilce = "Merkez" },
                new Town { Id = 39, CityId = 3, Ilce = "Sandıklı" },
                new Town { Id = 40, CityId = 3, Ilce = "Sinanpaşa" },
                new Town { Id = 41, CityId = 3, Ilce = "Sultandağı" },
                new Town { Id = 42, CityId = 3, Ilce = "Şuhut" },

                // Ağrı ilinin ilçeleri

                new Town { Id = 43, CityId = 4, Ilce = "Diyadin" },
                new Town { Id = 44, CityId = 4, Ilce = "Doğubayazıt" },
                new Town { Id = 45, CityId = 4, Ilce = "Eleşkirt" },
                new Town { Id = 46, CityId = 4, Ilce = "Hamur" },
                new Town { Id = 47, CityId = 4, Ilce = "Merkez" },
                new Town { Id = 48, CityId = 4, Ilce = "Patnos" },
                new Town { Id = 49, CityId = 4, Ilce = "Taşlıçay" },
                new Town { Id = 50, CityId = 4, Ilce = "Tutak" },

                // Amasya ilinin ilçeleri

                new Town { Id = 51, CityId = 5, Ilce = "Göynücek" },
                new Town { Id = 52, CityId = 5, Ilce = "Gümüşhacıköy" },
                new Town { Id = 53, CityId = 5, Ilce = "Hamamözü" },
                new Town { Id = 54, CityId = 5, Ilce = "Merkez" },
                new Town { Id = 55, CityId = 5, Ilce = "Merzifon" },
                new Town { Id = 56, CityId = 5, Ilce = "Suluova" },
                new Town { Id = 57, CityId = 5, Ilce = "Taşova" },

                // Ankara ilinin ilçeleri

                new Town { Id = 58, CityId = 6, Ilce = "Altındağ" },
                new Town { Id = 59, CityId = 6, Ilce = "Ayaş" },
                new Town { Id = 60, CityId = 6, Ilce = "Bala" },
                new Town { Id = 61, CityId = 6, Ilce = "Beypazarı" },
                new Town { Id = 62, CityId = 6, Ilce = "Çamlıdere" },
                new Town { Id = 63, CityId = 6, Ilce = "Çankaya" },
                new Town { Id = 64, CityId = 6, Ilce = "Çubuk" },
                new Town { Id = 65, CityId = 6, Ilce = "Elmadağ" },
                new Town { Id = 66, CityId = 6, Ilce = "Güdül" },
                new Town { Id = 67, CityId = 6, Ilce = "Haymana" },
                new Town { Id = 68, CityId = 6, Ilce = "Kalecik" },
                new Town { Id = 69, CityId = 6, Ilce = "Kızılcahamam" },
                new Town { Id = 70, CityId = 6, Ilce = "Nallıhan" },
                new Town { Id = 71, CityId = 6, Ilce = "Polatlı" },
                new Town { Id = 72, CityId = 6, Ilce = "Şereflikoçhisar" },
                new Town { Id = 73, CityId = 6, Ilce = "Yenimahalle" },
                new Town { Id = 74, CityId = 6, Ilce = "Gölbaşı" },
                new Town { Id = 75, CityId = 6, Ilce = "Keçiören" },
                new Town { Id = 76, CityId = 6, Ilce = "Mamak" },
                new Town { Id = 77, CityId = 6, Ilce = "Sincan" },
                new Town { Id = 78, CityId = 6, Ilce = "Kazan" },
                new Town { Id = 79, CityId = 6, Ilce = "Akyurt" },
                new Town { Id = 80, CityId = 6, Ilce = "Etimesgut" },
                new Town { Id = 81, CityId = 6, Ilce = "Evren" },
                new Town { Id = 82, CityId = 6, Ilce = "Pursaklar" },

                // Antalya ilinin ilçeleri

                new Town { Id = 83, CityId = 7, Ilce = "Akseki" },
                new Town { Id = 84, CityId = 7, Ilce = "Alanya" },
                new Town { Id = 85, CityId = 7, Ilce = "Elmalı" },
                new Town { Id = 86, CityId = 7, Ilce = "Finike" },
                new Town { Id = 87, CityId = 7, Ilce = "Gazipaşa" },
                new Town { Id = 88, CityId = 7, Ilce = "Gündoğmuş" },
                new Town { Id = 89, CityId = 7, Ilce = "Kaş" },
                new Town { Id = 90, CityId = 7, Ilce = "Korkuteli" },
                new Town { Id = 91, CityId = 7, Ilce = "Kumluca" },
                new Town { Id = 92, CityId = 7, Ilce = "Manavgat" },
                new Town { Id = 93, CityId = 7, Ilce = "Serik" },
                new Town { Id = 94, CityId = 7, Ilce = "Demre" },
                new Town { Id = 95, CityId = 7, Ilce = "İbradı" },
                new Town { Id = 96, CityId = 7, Ilce = "Kemer" },
                new Town { Id = 97, CityId = 7, Ilce = "Aksu" },
                new Town { Id = 98, CityId = 7, Ilce = "Döşemealtı" },
                new Town { Id = 99, CityId = 7, Ilce = "Kepez" },
                new Town { Id = 100, CityId = 7, Ilce = "Konyaaltı" },
                new Town { Id = 101, CityId = 7, Ilce = "Muratpaşa" },

                // Artvin ilinin ilçeleri

                new Town { Id = 102, CityId = 8, Ilce = "Ardanuç" },
                new Town { Id = 103, CityId = 8, Ilce = "Arhavi" },
                new Town { Id = 104, CityId = 8, Ilce = "Merkez" },
                new Town { Id = 105, CityId = 8, Ilce = "Borçka" },
                new Town { Id = 106, CityId = 8, Ilce = "Hopa" },
                new Town { Id = 107, CityId = 8, Ilce = "Şavşat" },
                new Town { Id = 108, CityId = 8, Ilce = "Yusufeli" },
                new Town { Id = 109, CityId = 8, Ilce = "Murgul" },

                // Aydın ilinin ilçeleri

                new Town { Id = 110, CityId = 9, Ilce = "Merkez" },
                new Town { Id = 111, CityId = 9, Ilce = "Bozdoğan" },
                new Town { Id = 112, CityId = 9, Ilce = "Efeler" },
                new Town { Id = 113, CityId = 9, Ilce = "Çine" },
                new Town { Id = 114, CityId = 9, Ilce = "Germencik" },
                new Town { Id = 115, CityId = 9, Ilce = "Karacasu" },
                new Town { Id = 116, CityId = 9, Ilce = "Koçarlı" },
                new Town { Id = 117, CityId = 9, Ilce = "Kuşadası" },
                new Town { Id = 118, CityId = 9, Ilce = "Kuyucak" },
                new Town { Id = 119, CityId = 9, Ilce = "Nazilli" },
                new Town { Id = 120, CityId = 9, Ilce = "Söke" },
                new Town { Id = 121, CityId = 9, Ilce = "Sultanhisar" },
                new Town { Id = 122, CityId = 9, Ilce = "Yenipazar" },
                new Town { Id = 123, CityId = 9, Ilce = "Buharkent" },
                new Town { Id = 124, CityId = 9, Ilce = "İncirliova" },
                new Town { Id = 125, CityId = 9, Ilce = "Karpuzlu" },
                new Town { Id = 126, CityId = 9, Ilce = "Köşk" },
                new Town { Id = 127, CityId = 9, Ilce = "Didim" },

                // Balıkesir ilinin ilçeleri

                new Town { Id = 128, CityId = 10, Ilce = "Altıeylül" },
                new Town { Id = 129, CityId = 10, Ilce = "Ayvalık" },
                new Town { Id = 130, CityId = 10, Ilce = "Merkez" },
                new Town { Id = 131, CityId = 10, Ilce = "Balya" },
                new Town { Id = 132, CityId = 10, Ilce = "Bandırma" },
                new Town { Id = 133, CityId = 10, Ilce = "Bigadiç" },
                new Town { Id = 134, CityId = 10, Ilce = "Burhaniye" },
                new Town { Id = 135, CityId = 10, Ilce = "Dursunbey" },
                new Town { Id = 136, CityId = 10, Ilce = "Edremit" },
                new Town { Id = 137, CityId = 10, Ilce = "Erdek" },
                new Town { Id = 138, CityId = 10, Ilce = "Gönen" },
                new Town { Id = 139, CityId = 10, Ilce = "Havran" },
                new Town { Id = 140, CityId = 10, Ilce = "İvrindi" },
                new Town { Id = 141, CityId = 10, Ilce = "Karesi" },
                new Town { Id = 142, CityId = 10, Ilce = "Kepsut" },
                new Town { Id = 143, CityId = 10, Ilce = "Manyas" },
                new Town { Id = 144, CityId = 10, Ilce = "Savaştepe" },
                new Town { Id = 145, CityId = 10, Ilce = "Sındırgı" },
                new Town { Id = 146, CityId = 10, Ilce = "Gömeç" },
                new Town { Id = 147, CityId = 10, Ilce = "Susurluk" },
                new Town { Id = 148, CityId = 10, Ilce = "Marmara" },

                // Bilecik ilinin ilçeleri

                new Town { Id = 149, CityId = 11, Ilce = "Merkez" },
                new Town { Id = 150, CityId = 11, Ilce = "Bozüyük" },
                new Town { Id = 151, CityId = 11, Ilce = "Gölpazarı" },
                new Town { Id = 152, CityId = 11, Ilce = "Osmaneli" },
                new Town { Id = 153, CityId = 11, Ilce = "Pazaryeri" },
                new Town { Id = 154, CityId = 11, Ilce = "Söğüt" },
                new Town { Id = 155, CityId = 11, Ilce = "Yenipazar" },
                new Town { Id = 156, CityId = 11, Ilce = "İnhisar" },

                // Bingöl ilinin ilçeleri

                new Town { Id = 157, CityId = 12, Ilce = "Merkez" },
                new Town { Id = 158, CityId = 12, Ilce = "Genç" },
                new Town { Id = 159, CityId = 12, Ilce = "Karlıova" },
                new Town { Id = 160, CityId = 12, Ilce = "Kiğı" },
                new Town { Id = 161, CityId = 12, Ilce = "Solhan" },
                new Town { Id = 162, CityId = 12, Ilce = "Adaklı" },
                new Town { Id = 163, CityId = 12, Ilce = "Yayladere" },
                new Town { Id = 164, CityId = 12, Ilce = "Yedisu" },

                // Bitlis ilinin ilçeleri

                new Town { Id = 165, CityId = 13, Ilce = "Adilcevaz" },
                new Town { Id = 166, CityId = 13, Ilce = "Ahlat" },
                new Town { Id = 167, CityId = 13, Ilce = "Merkez" },
                new Town { Id = 168, CityId = 13, Ilce = "Hizan" },
                new Town { Id = 169, CityId = 13, Ilce = "Mutki" },
                new Town { Id = 170, CityId = 13, Ilce = "Tatvan" },
                new Town { Id = 171, CityId = 13, Ilce = "Güroymak" },

                // Bolu ilinin ilçeleri

                new Town { Id = 172, CityId = 14, Ilce = "Merkez" },
                new Town { Id = 173, CityId = 14, Ilce = "Gerede" },
                new Town { Id = 174, CityId = 14, Ilce = "Göynük" },
                new Town { Id = 175, CityId = 14, Ilce = "Kıbrıscık" },
                new Town { Id = 176, CityId = 14, Ilce = "Mengen" },
                new Town { Id = 177, CityId = 14, Ilce = "Mudurnu" },
                new Town { Id = 178, CityId = 14, Ilce = "Seben" },
                new Town { Id = 179, CityId = 14, Ilce = "Dörtdivan" },
                new Town { Id = 180, CityId = 14, Ilce = "Yeniçağa" },

                // Burdur ilinin ilçeleri

                new Town { Id = 181, CityId = 15, Ilce = "Ağlasun" },
                new Town { Id = 182, CityId = 15, Ilce = "Bucak" },
                new Town { Id = 183, CityId = 15, Ilce = "Merkez" },
                new Town { Id = 184, CityId = 15, Ilce = "Gölhisar" },
                new Town { Id = 185, CityId = 15, Ilce = "Tefenni" },
                new Town { Id = 186, CityId = 15, Ilce = "Yeşilova" },
                new Town { Id = 187, CityId = 15, Ilce = "Karamanlı" },
                new Town { Id = 188, CityId = 15, Ilce = "Kemer" },
                new Town { Id = 189, CityId = 15, Ilce = "Altınyayla" },
                new Town { Id = 190, CityId = 15, Ilce = "Çavdır" },
                new Town { Id = 191, CityId = 15, Ilce = "Çeltikçi" },

                // Bursa ilinin ilçeleri

                new Town { Id = 192, CityId = 16, Ilce = "Gemlik" },
                new Town { Id = 193, CityId = 16, Ilce = "İnegöl" },
                new Town { Id = 194, CityId = 16, Ilce = "İznik" },
                new Town { Id = 195, CityId = 16, Ilce = "Karacabey" },
                new Town { Id = 196, CityId = 16, Ilce = "Keles" },
                new Town { Id = 197, CityId = 16, Ilce = "Mudanya" },
                new Town { Id = 198, CityId = 16, Ilce = "Mustafakemalpaşa" },
                new Town { Id = 199, CityId = 16, Ilce = "Orhaneli" },
                new Town { Id = 200, CityId = 16, Ilce = "Orhangazi" },
                new Town { Id = 201, CityId = 16, Ilce = "Yenişehir" },
                new Town { Id = 202, CityId = 16, Ilce = "Büyükorhan" },
                new Town { Id = 203, CityId = 16, Ilce = "Harmancık" },
                new Town { Id = 204, CityId = 16, Ilce = "Nilüfer" },
                new Town { Id = 205, CityId = 16, Ilce = "Osmangazi" },
                new Town { Id = 206, CityId = 16, Ilce = "Yıldırım" },
                new Town { Id = 207, CityId = 16, Ilce = "Gürsu" },
                new Town { Id = 208, CityId = 16, Ilce = "Kestel" },

                // Çanakkale ilinin ilçeleri

                new Town { Id = 209, CityId = 17, Ilce = "Ayvacık" },
                new Town { Id = 210, CityId = 17, Ilce = "Bayramiç" },
                new Town { Id = 211, CityId = 17, Ilce = "Biga" },
                new Town { Id = 212, CityId = 17, Ilce = "Bozcaada" },
                new Town { Id = 213, CityId = 17, Ilce = "Çan" },
                new Town { Id = 214, CityId = 17, Ilce = "Merkez" },
                new Town { Id = 215, CityId = 17, Ilce = "Eceabat" },
                new Town { Id = 216, CityId = 17, Ilce = "Ezine" },
                new Town { Id = 217, CityId = 17, Ilce = "Gelibolu" },
                new Town { Id = 218, CityId = 17, Ilce = "Gökçeada" },
                new Town { Id = 219, CityId = 17, Ilce = "Lapseki" },
                new Town { Id = 220, CityId = 17, Ilce = "Yenice" },

                // Çankırı ilinin ilçeleri

                new Town { Id = 221, CityId = 18, Ilce = "Merkez" },
                new Town { Id = 222, CityId = 18, Ilce = "Çerkeş" },
                new Town { Id = 223, CityId = 18, Ilce = "Eldivan" },
                new Town { Id = 224, CityId = 18, Ilce = "Ilgaz" },
                new Town { Id = 225, CityId = 18, Ilce = "Kurşunlu" },
                new Town { Id = 226, CityId = 18, Ilce = "Orta" },
                new Town { Id = 227, CityId = 18, Ilce = "Şabanözü" },
                new Town { Id = 228, CityId = 18, Ilce = "Yapraklı" },
                new Town { Id = 229, CityId = 18, Ilce = "Atkaracalar" },
                new Town { Id = 230, CityId = 18, Ilce = "Kızılırmak" },
                new Town { Id = 231, CityId = 18, Ilce = "Bayramören" },
                new Town { Id = 232, CityId = 18, Ilce = "Korgun" },

                // Çorum ilinin ilçeleri

                new Town { Id = 233, CityId = 19, Ilce = "Alaca" },
                new Town { Id = 234, CityId = 19, Ilce = "Bayat" },
                new Town { Id = 235, CityId = 19, Ilce = "Merkez" },
                new Town { Id = 236, CityId = 19, Ilce = "İskilip" },
                new Town { Id = 237, CityId = 19, Ilce = "Kargı" },
                new Town { Id = 238, CityId = 19, Ilce = "Mecitözü" },
                new Town { Id = 239, CityId = 19, Ilce = "Ortaköy" },
                new Town { Id = 240, CityId = 19, Ilce = "Osmancık" },
                new Town { Id = 241, CityId = 19, Ilce = "Sungurlu" },
                new Town { Id = 242, CityId = 19, Ilce = "Boğazkale" },
                new Town { Id = 243, CityId = 19, Ilce = "Uğurludağ" },
                new Town { Id = 244, CityId = 19, Ilce = "Dodurga" },
                new Town { Id = 245, CityId = 19, Ilce = "Laçin" },
                new Town { Id = 246, CityId = 19, Ilce = "Oğuzlar" },

                // Denizli ilinin ilçeleri

                new Town { Id = 247, CityId = 20, Ilce = "Acıpayam" },
                new Town { Id = 248, CityId = 20, Ilce = "Buldan" },
                new Town { Id = 249, CityId = 20, Ilce = "Çal" },
                new Town { Id = 250, CityId = 20, Ilce = "Çameli" },
                new Town { Id = 251, CityId = 20, Ilce = "Çardak" },
                new Town { Id = 252, CityId = 20, Ilce = "Çivril" },
                new Town { Id = 253, CityId = 20, Ilce = "Merkez" },
                new Town { Id = 254, CityId = 20, Ilce = "Merkezefendi" },
                new Town { Id = 255, CityId = 20, Ilce = "Pamukkale" },
                new Town { Id = 256, CityId = 20, Ilce = "Güney" },
                new Town { Id = 257, CityId = 20, Ilce = "Kale" },
                new Town { Id = 258, CityId = 20, Ilce = "Sarayköy" },
                new Town { Id = 259, CityId = 20, Ilce = "Tavas" },
                new Town { Id = 260, CityId = 20, Ilce = "Babadağ" },
                new Town { Id = 261, CityId = 20, Ilce = "Bekilli" },
                new Town { Id = 262, CityId = 20, Ilce = "Honaz" },
                new Town { Id = 263, CityId = 20, Ilce = "Serinhisar" },
                new Town { Id = 264, CityId = 20, Ilce = "Baklan" },
                new Town { Id = 265, CityId = 20, Ilce = "Beyağaç" },
                new Town { Id = 266, CityId = 20, Ilce = "Bozkurt" },

                // Diyarbakır ilinin ilçeleri

                new Town { Id = 267, CityId = 21, Ilce = "Kocaköy" },
                new Town { Id = 268, CityId = 21, Ilce = "Çermik" },
                new Town { Id = 269, CityId = 21, Ilce = "Çınar" },
                new Town { Id = 270, CityId = 21, Ilce = "Çüngüş" },
                new Town { Id = 271, CityId = 21, Ilce = "Dicle" },
                new Town { Id = 272, CityId = 21, Ilce = "Ergani" },
                new Town { Id = 273, CityId = 21, Ilce = "Hani" },
                new Town { Id = 274, CityId = 21, Ilce = "Hazro" },
                new Town { Id = 275, CityId = 21, Ilce = "Kulp" },
                new Town { Id = 276, CityId = 21, Ilce = "Lice" },
                new Town { Id = 277, CityId = 21, Ilce = "Silvan" },
                new Town { Id = 278, CityId = 21, Ilce = "Eğil" },
                new Town { Id = 279, CityId = 21, Ilce = "Bağlar" },
                new Town { Id = 280, CityId = 21, Ilce = "Kayapınar" },
                new Town { Id = 281, CityId = 21, Ilce = "Sur" },
                new Town { Id = 282, CityId = 21, Ilce = "Yenişehir" },
                new Town { Id = 283, CityId = 21, Ilce = "Bismil" },

                // Edirne ilinin ilçeleri 

                new Town { Id = 284, CityId = 22, Ilce = "Merkez" },
                new Town { Id = 285, CityId = 22, Ilce = "Enez" },
                new Town { Id = 286, CityId = 22, Ilce = "Havsa" },
                new Town { Id = 287, CityId = 22, Ilce = "İpsala" },
                new Town { Id = 288, CityId = 22, Ilce = "Keşan" },
                new Town { Id = 289, CityId = 22, Ilce = "Lalapaşa" },
                new Town { Id = 290, CityId = 22, Ilce = "Meriç" },
                new Town { Id = 291, CityId = 22, Ilce = "Uzunköprü" },
                new Town { Id = 292, CityId = 22, Ilce = "Süloğlu" },

                // Elazığ ilinin ilçeleri

                new Town { Id = 293, CityId = 23, Ilce = "Ağın" },
                new Town { Id = 294, CityId = 23, Ilce = "Baskil" },
                new Town { Id = 295, CityId = 23, Ilce = "Merkez" },
                new Town { Id = 296, CityId = 23, Ilce = "Karakoçan" },
                new Town { Id = 297, CityId = 23, Ilce = "Keban" },
                new Town { Id = 298, CityId = 23, Ilce = "Maden" },
                new Town { Id = 299, CityId = 23, Ilce = "Palu" },
                new Town { Id = 300, CityId = 23, Ilce = "Sivrice" },
                new Town { Id = 301, CityId = 23, Ilce = "Arıcak" },
                new Town { Id = 302, CityId = 23, Ilce = "Kovancılar" },
                new Town { Id = 303, CityId = 23, Ilce = "Alacakaya" },

                // Erzincan ilinin ilçeleri

                new Town { Id = 304, CityId = 24, Ilce = "Çayırlı" },
                new Town { Id = 305, CityId = 24, Ilce = "Merkez" },
                new Town { Id = 306, CityId = 24, Ilce = "İliç" },
                new Town { Id = 307, CityId = 24, Ilce = "Kemah" },
                new Town { Id = 308, CityId = 24, Ilce = "Kemaliye" },
                new Town { Id = 309, CityId = 24, Ilce = "Refahiye" },
                new Town { Id = 310, CityId = 24, Ilce = "Tercan" },
                new Town { Id = 311, CityId = 24, Ilce = "Üzümlü" },
                new Town { Id = 312, CityId = 24, Ilce = "Otlukbeli" },

                // Erzurum ilinin ilçeleri

                new Town { Id = 313, CityId = 25, Ilce = "Aşkale" },
                new Town { Id = 314, CityId = 25, Ilce = "Çat" },
                new Town { Id = 315, CityId = 25, Ilce = "Hınıs" },
                new Town { Id = 316, CityId = 25, Ilce = "Horasan" },
                new Town { Id = 317, CityId = 25, Ilce = "İspir" },
                new Town { Id = 318, CityId = 25, Ilce = "Karayazı" },
                new Town { Id = 319, CityId = 25, Ilce = "Narman" },
                new Town { Id = 320, CityId = 25, Ilce = "Oltu" },
                new Town { Id = 321, CityId = 25, Ilce = "Olur" },
                new Town { Id = 322, CityId = 25, Ilce = "Pasinler" },
                new Town { Id = 323, CityId = 25, Ilce = "Şenkaya" },
                new Town { Id = 324, CityId = 25, Ilce = "Tekman" },
                new Town { Id = 325, CityId = 25, Ilce = "Tortum" },
                new Town { Id = 326, CityId = 25, Ilce = "Karaçoban" },
                new Town { Id = 327, CityId = 25, Ilce = "Uzundere" },
                new Town { Id = 328, CityId = 25, Ilce = "Pazaryolu" },
                new Town { Id = 329, CityId = 25, Ilce = "Köprüköy" },
                new Town { Id = 330, CityId = 25, Ilce = "Palandöken" },
                new Town { Id = 331, CityId = 25, Ilce = "Yakutiye" },
                new Town { Id = 332, CityId = 25, Ilce = "Aziziye" },

                // Eskişehir ilinin ilçeleri

                new Town { Id = 333, CityId = 26, Ilce = "Çifteler" },
                new Town { Id = 334, CityId = 26, Ilce = "Mahmudiye" },
                new Town { Id = 335, CityId = 26, Ilce = "Mihalıççık" },
                new Town { Id = 336, CityId = 26, Ilce = "Sarıcakaya" },
                new Town { Id = 337, CityId = 26, Ilce = "Seyitgazi" },
                new Town { Id = 338, CityId = 26, Ilce = "Sivrihisar" },
                new Town { Id = 339, CityId = 26, Ilce = "Alpu" },
                new Town { Id = 340, CityId = 26, Ilce = "Beylikova" },
                new Town { Id = 341, CityId = 26, Ilce = "İnönü" },
                new Town { Id = 342, CityId = 26, Ilce = "Günyüzü" },
                new Town { Id = 343, CityId = 26, Ilce = "Han" },
                new Town { Id = 344, CityId = 26, Ilce = "Mihalgazi" },
                new Town { Id = 345, CityId = 26, Ilce = "Odunpazarı" },
                new Town { Id = 346, CityId = 26, Ilce = "Tepebaşı" },

                // Gaziantep ilinin ilçeleri

                new Town { Id = 347, CityId = 27, Ilce = "Araban" },
                new Town { Id = 348, CityId = 27, Ilce = "İslahiye" },
                new Town { Id = 349, CityId = 27, Ilce = "Nizip" },
                new Town { Id = 350, CityId = 27, Ilce = "Oğuzeli" },
                new Town { Id = 351, CityId = 27, Ilce = "Yavuzeli" },
                new Town { Id = 352, CityId = 27, Ilce = "Şahinbey" },
                new Town { Id = 353, CityId = 27, Ilce = "Şehitkamil" },
                new Town { Id = 354, CityId = 27, Ilce = "Karkamış" },
                new Town { Id = 355, CityId = 27, Ilce = "Nurdağı" },

                // Giresun ilinin ilçeleri

                new Town { Id = 356, CityId = 28, Ilce = "Alucra" },
                new Town { Id = 357, CityId = 28, Ilce = "Bulancak" },
                new Town { Id = 358, CityId = 28, Ilce = "Dereli" },
                new Town { Id = 359, CityId = 28, Ilce = "Espiye" },
                new Town { Id = 360, CityId = 28, Ilce = "Eynesil" },
                new Town { Id = 361, CityId = 28, Ilce = "Merkez" },
                new Town { Id = 362, CityId = 28, Ilce = "Görele" },
                new Town { Id = 363, CityId = 28, Ilce = "Keşap" },
                new Town { Id = 364, CityId = 28, Ilce = "Şebinkarahisar" },
                new Town { Id = 365, CityId = 28, Ilce = "Tirebolu" },
                new Town { Id = 366, CityId = 28, Ilce = "Piraziz" },
                new Town { Id = 367, CityId = 28, Ilce = "Yağlıdere" },
                new Town { Id = 368, CityId = 28, Ilce = "Çamoluk" },
                new Town { Id = 369, CityId = 28, Ilce = "Çanakçı" },
                new Town { Id = 370, CityId = 28, Ilce = "Doğankent" },
                new Town { Id = 371, CityId = 28, Ilce = "Güce" },

                // Gümüşhane ilinin ilçeleri

                new Town { Id = 372, CityId = 29, Ilce = "Merkez" },
                new Town { Id = 373, CityId = 29, Ilce = "Kelkit" },
                new Town { Id = 374, CityId = 29, Ilce = "Şiran" },
                new Town { Id = 375, CityId = 29, Ilce = "Torul" },
                new Town { Id = 376, CityId = 29, Ilce = "Köse" },
                new Town { Id = 377, CityId = 29, Ilce = "Kürtün" },

                // Hakkari ilinin ilçeleri

                new Town { Id = 378, CityId = 30, Ilce = "Çukurca" },
                new Town { Id = 379, CityId = 30, Ilce = "Merkez" },
                new Town { Id = 380, CityId = 30, Ilce = "Şemdinli" },
                new Town { Id = 381, CityId = 30, Ilce = "Yüksekova" },

                // Hatay ilinin ilçeleri

                new Town { Id = 382, CityId = 31, Ilce = "Altınözü" },
                new Town { Id = 383, CityId = 31, Ilce = "Arsuz" },
                new Town { Id = 384, CityId = 31, Ilce = "Defne" },
                new Town { Id = 385, CityId = 31, Ilce = "Dörtyol" },
                new Town { Id = 386, CityId = 31, Ilce = "Hassa" },
                new Town { Id = 387, CityId = 31, Ilce = "Antakya" },
                new Town { Id = 388, CityId = 31, Ilce = "İskenderun" },
                new Town { Id = 389, CityId = 31, Ilce = "Kırıkhan" },
                new Town { Id = 390, CityId = 31, Ilce = "Payas" },
                new Town { Id = 391, CityId = 31, Ilce = "Reyhanlı" },
                new Town { Id = 392, CityId = 31, Ilce = "Samandağ" },
                new Town { Id = 393, CityId = 31, Ilce = "Yayladağı" },
                new Town { Id = 394, CityId = 31, Ilce = "Erzin" },
                new Town { Id = 395, CityId = 31, Ilce = "Belen" },
                new Town { Id = 396, CityId = 31, Ilce = "Kumlu" },

                // Isparta ilinin ilçeleri

                new Town { Id = 397, CityId = 32, Ilce = "Atabey" },
                new Town { Id = 398, CityId = 32, Ilce = "Eğirdir" },
                new Town { Id = 399, CityId = 32, Ilce = "Gelendost" },
                new Town { Id = 400, CityId = 32, Ilce = "Merkez" },
                new Town { Id = 401, CityId = 32, Ilce = "Keçiborlu" },
                new Town { Id = 402, CityId = 32, Ilce = "Senirkent" },
                new Town { Id = 403, CityId = 32, Ilce = "Sütçüler" },
                new Town { Id = 404, CityId = 32, Ilce = "Şarkikaraağaç" },
                new Town { Id = 405, CityId = 32, Ilce = "Uluborlu" },
                new Town { Id = 406, CityId = 32, Ilce = "Yalvaç" },
                new Town { Id = 407, CityId = 32, Ilce = "Aksu" },
                new Town { Id = 408, CityId = 32, Ilce = "Gönen" },
                new Town { Id = 409, CityId = 32, Ilce = "Yenişarbademli" },

                // Mersin ilinin ilçeleri

                new Town { Id = 410, CityId = 33, Ilce = "Anamur" },
                new Town { Id = 411, CityId = 33, Ilce = "Erdemli" },
                new Town { Id = 412, CityId = 33, Ilce = "Gülnar" },
                new Town { Id = 413, CityId = 33, Ilce = "Mut" },
                new Town { Id = 414, CityId = 33, Ilce = "Silifke" },
                new Town { Id = 415, CityId = 33, Ilce = "Tarsus" },
                new Town { Id = 416, CityId = 33, Ilce = "Aydıncık" },
                new Town { Id = 417, CityId = 33, Ilce = "Bozyazı" },
                new Town { Id = 418, CityId = 33, Ilce = "Çamlıyayla" },
                new Town { Id = 419, CityId = 33, Ilce = "Akdeniz" },
                new Town { Id = 420, CityId = 33, Ilce = "Mezitli" },
                new Town { Id = 421, CityId = 33, Ilce = "Toroslar" },
                new Town { Id = 422, CityId = 33, Ilce = "Yenişehir" },

                // İstanbul ilinin ilçeleri

                new Town { Id = 423, CityId = 34, Ilce = "Adalar" },
                new Town { Id = 424, CityId = 34, Ilce = "Bakırköy" },
                new Town { Id = 425, CityId = 34, Ilce = "Beşiktaş" },
                new Town { Id = 426, CityId = 34, Ilce = "Beykoz" },
                new Town { Id = 427, CityId = 34, Ilce = "Beyoğlu" },
                new Town { Id = 428, CityId = 34, Ilce = "Çatalca" },
                new Town { Id = 429, CityId = 34, Ilce = "Eyüp" },
                new Town { Id = 430, CityId = 34, Ilce = "Fatih" },
                new Town { Id = 431, CityId = 34, Ilce = "Gaziosmanpaşa" },
                new Town { Id = 432, CityId = 34, Ilce = "Kadıköy" },
                new Town { Id = 433, CityId = 34, Ilce = "Kartal" },
                new Town { Id = 434, CityId = 34, Ilce = "Sarıyer" },
                new Town { Id = 435, CityId = 34, Ilce = "Silivri" },
                new Town { Id = 436, CityId = 34, Ilce = "Şile" },
                new Town { Id = 437, CityId = 34, Ilce = "Şişli" },
                new Town { Id = 438, CityId = 34, Ilce = "Üsküdar" },
                new Town { Id = 439, CityId = 34, Ilce = "Zeytinburnu" },
                new Town { Id = 440, CityId = 34, Ilce = "Büyükçekmece" },
                new Town { Id = 441, CityId = 34, Ilce = "Kağıthane" },
                new Town { Id = 442, CityId = 34, Ilce = "Küçükçekmece" },
                new Town { Id = 443, CityId = 34, Ilce = "Pendik" },
                new Town { Id = 444, CityId = 34, Ilce = "Ümraniye" },
                new Town { Id = 445, CityId = 34, Ilce = "Bayrampaşa" },
                new Town { Id = 446, CityId = 34, Ilce = "Avcılar" },
                new Town { Id = 447, CityId = 34, Ilce = "Bağcılar" },
                new Town { Id = 448, CityId = 34, Ilce = "Bahçelievler" },
                new Town { Id = 449, CityId = 34, Ilce = "Güngören" },
                new Town { Id = 450, CityId = 34, Ilce = "Maltepe" },
                new Town { Id = 451, CityId = 34, Ilce = "Sultanbeyli" },
                new Town { Id = 452, CityId = 34, Ilce = "Tuzla" },
                new Town { Id = 453, CityId = 34, Ilce = "Esenler" },
                new Town { Id = 454, CityId = 34, Ilce = "Arnavutköy" },
                new Town { Id = 455, CityId = 34, Ilce = "Ataşehir" },
                new Town { Id = 456, CityId = 34, Ilce = "Başakşehir" },
                new Town { Id = 457, CityId = 34, Ilce = "Beylikdüzü" },
                new Town { Id = 458, CityId = 34, Ilce = "Çekmeköy" },
                new Town { Id = 459, CityId = 34, Ilce = "Esenyurt" },
                new Town { Id = 460, CityId = 34, Ilce = "Sancaktepe" },
                new Town { Id = 461, CityId = 34, Ilce = "Sultangazi" },

                // İzmir ilinin ilçeleri

                new Town { Id = 462, CityId = 35, Ilce = "Aliağa" },
                new Town { Id = 463, CityId = 35, Ilce = "Bayındır" },
                new Town { Id = 464, CityId = 35, Ilce = "Bergama" },
                new Town { Id = 465, CityId = 35, Ilce = "Bornova" },
                new Town { Id = 466, CityId = 35, Ilce = "Çeşme" },
                new Town { Id = 467, CityId = 35, Ilce = "Dikili" },
                new Town { Id = 468, CityId = 35, Ilce = "Foça" },
                new Town { Id = 469, CityId = 35, Ilce = "Karaburun" },
                new Town { Id = 470, CityId = 35, Ilce = "Karşıyaka" },
                new Town { Id = 471, CityId = 35, Ilce = "Kemalpaşa" },
                new Town { Id = 472, CityId = 35, Ilce = "Kınık" },
                new Town { Id = 473, CityId = 35, Ilce = "Kiraz" },
                new Town { Id = 474, CityId = 35, Ilce = "Menemen" },
                new Town { Id = 475, CityId = 35, Ilce = "Ödemiş" },
                new Town { Id = 476, CityId = 35, Ilce = "Seferihisar" },
                new Town { Id = 477, CityId = 35, Ilce = "Selçuk" },
                new Town { Id = 478, CityId = 35, Ilce = "Tire" },
                new Town { Id = 479, CityId = 35, Ilce = "Torbalı" },
                new Town { Id = 480, CityId = 35, Ilce = "Urla" },
                new Town { Id = 481, CityId = 35, Ilce = "Beydağ" },
                new Town { Id = 482, CityId = 35, Ilce = "Buca" },
                new Town { Id = 483, CityId = 35, Ilce = "Konak" },
                new Town { Id = 484, CityId = 35, Ilce = "Menderes" },
                new Town { Id = 485, CityId = 35, Ilce = "Balçova" },
                new Town { Id = 486, CityId = 35, Ilce = "Çiğli" },
                new Town { Id = 487, CityId = 35, Ilce = "Gaziemir" },
                new Town { Id = 488, CityId = 35, Ilce = "Narlıdere" },
                new Town { Id = 489, CityId = 35, Ilce = "Güzelbahçe" },
                new Town { Id = 490, CityId = 35, Ilce = "Bayraklı" },
                new Town { Id = 491, CityId = 35, Ilce = "Karabağlar" },

                // Kars ilinin ilçeleri

                new Town { Id = 492, CityId = 36, Ilce = "Arpaçay" },
                new Town { Id = 493, CityId = 36, Ilce = "Digor" },
                new Town { Id = 494, CityId = 36, Ilce = "Kağızman" },
                new Town { Id = 495, CityId = 36, Ilce = "Merkez" },
                new Town { Id = 496, CityId = 36, Ilce = "Sarıkamış" },
                new Town { Id = 497, CityId = 36, Ilce = "Selim" },
                new Town { Id = 498, CityId = 36, Ilce = "Susuz" },
                new Town { Id = 499, CityId = 36, Ilce = "Akyaka" },

                // Kastamonu ilinin ilçeleri

                new Town { Id = 500, CityId = 37, Ilce = "Abana" },
                new Town { Id = 501, CityId = 37, Ilce = "Araç" },
                new Town { Id = 502, CityId = 37, Ilce = "Azdavay" },
                new Town { Id = 503, CityId = 37, Ilce = "Bozkurt" },
                new Town { Id = 504, CityId = 37, Ilce = "Cide" },
                new Town { Id = 505, CityId = 37, Ilce = "Çatalzeytin" },
                new Town { Id = 506, CityId = 37, Ilce = "Daday" },
                new Town { Id = 507, CityId = 37, Ilce = "Devrekani" },
                new Town { Id = 508, CityId = 37, Ilce = "İnebolu" },
                new Town { Id = 509, CityId = 37, Ilce = "Merkez" },
                new Town { Id = 510, CityId = 37, Ilce = "Küre" },
                new Town { Id = 511, CityId = 37, Ilce = "Taşköprü" },
                new Town { Id = 512, CityId = 37, Ilce = "Tosya" },
                new Town { Id = 513, CityId = 37, Ilce = "İhsangazi" },
                new Town { Id = 514, CityId = 37, Ilce = "Pınarbaşı" },
                new Town { Id = 515, CityId = 37, Ilce = "Şenpazar" },
                new Town { Id = 516, CityId = 37, Ilce = "Ağlı" },
                new Town { Id = 517, CityId = 37, Ilce = "Doğanyurt" },
                new Town { Id = 518, CityId = 37, Ilce = "Hanönü" },
                new Town { Id = 519, CityId = 37, Ilce = "Seydiler" },

                // Kayseri ilinin ilçeleri

                new Town { Id = 520, CityId = 38, Ilce = "Bünyan" },
                new Town { Id = 521, CityId = 38, Ilce = "Develi" },
                new Town { Id = 522, CityId = 38, Ilce = "Felahiye" },
                new Town { Id = 523, CityId = 38, Ilce = "İncesu" },
                new Town { Id = 524, CityId = 38, Ilce = "Pınarbaşı" },
                new Town { Id = 525, CityId = 38, Ilce = "Sarıoğlan" },
                new Town { Id = 526, CityId = 38, Ilce = "Sarız" },
                new Town { Id = 527, CityId = 38, Ilce = "Tomarza" },
                new Town { Id = 528, CityId = 38, Ilce = "Yahyalı" },
                new Town { Id = 529, CityId = 38, Ilce = "Yeşilhisar" },
                new Town { Id = 530, CityId = 38, Ilce = "Akkışla" },
                new Town { Id = 531, CityId = 38, Ilce = "Talas" },
                new Town { Id = 532, CityId = 38, Ilce = "Kocasinan" },
                new Town { Id = 533, CityId = 38, Ilce = "Melikgazi" },
                new Town { Id = 534, CityId = 38, Ilce = "Hacılar" },
                new Town { Id = 535, CityId = 38, Ilce = "Özvatan" },

                // Kırklareli ilinin ilçeleri

                new Town { Id = 536, CityId = 39, Ilce = "Babaeski" },
                new Town { Id = 537, CityId = 39, Ilce = "Demirköy" },
                new Town { Id = 538, CityId = 39, Ilce = "Merkez" },
                new Town { Id = 539, CityId = 39, Ilce = "Kofçaz" },
                new Town { Id = 540, CityId = 39, Ilce = "Lüleburgaz" },
                new Town { Id = 541, CityId = 39, Ilce = "Pehlivanköy" },
                new Town { Id = 542, CityId = 39, Ilce = "Pınarhisar" },
                new Town { Id = 543, CityId = 39, Ilce = "Vize" },

                // Kırşehir ilinin ilçeleri

                new Town { Id = 544, CityId = 40, Ilce = "Çiçekdağı" },
                new Town { Id = 545, CityId = 40, Ilce = "Kaman" },
                new Town { Id = 546, CityId = 40, Ilce = "Merkez" },
                new Town { Id = 547, CityId = 40, Ilce = "Mucur" },
                new Town { Id = 548, CityId = 40, Ilce = "Akpınar" },
                new Town { Id = 549, CityId = 40, Ilce = "Akçakent" },
                new Town { Id = 550, CityId = 40, Ilce = "Boztepe" },

                // Kocaeli ilinin ilçeleri

                new Town { Id = 551, CityId = 41, Ilce = "Gebze" },
                new Town { Id = 552, CityId = 41, Ilce = "Gölcük" },
                new Town { Id = 553, CityId = 41, Ilce = "Kandıra" },
                new Town { Id = 554, CityId = 41, Ilce = "Karamürsel" },
                new Town { Id = 555, CityId = 41, Ilce = "Körfez" },
                new Town { Id = 556, CityId = 41, Ilce = "Derince" },
                new Town { Id = 557, CityId = 41, Ilce = "Başiskele" },
                new Town { Id = 558, CityId = 41, Ilce = "Çayırova" },
                new Town { Id = 559, CityId = 41, Ilce = "Darıca" },
                new Town { Id = 560, CityId = 41, Ilce = "Dilovası" },
                new Town { Id = 561, CityId = 41, Ilce = "İzmit" },
                new Town { Id = 562, CityId = 41, Ilce = "Kartepe" },

                // Konya ilinin ilçeleri

                new Town { Id = 563, CityId = 42, Ilce = "Akşehir" },
                new Town { Id = 564, CityId = 42, Ilce = "Beyşehir" },
                new Town { Id = 565, CityId = 42, Ilce = "Bozkır" },
                new Town { Id = 566, CityId = 42, Ilce = "Cihanbeyli" },
                new Town { Id = 567, CityId = 42, Ilce = "Çumra" },
                new Town { Id = 568, CityId = 42, Ilce = "Doğanhisar" },
                new Town { Id = 569, CityId = 42, Ilce = "Ereğli" },
                new Town { Id = 570, CityId = 42, Ilce = "Hadim" },
                new Town { Id = 571, CityId = 42, Ilce = "Ilgın" },
                new Town { Id = 572, CityId = 42, Ilce = "Kadınhanı" },
                new Town { Id = 573, CityId = 42, Ilce = "Karapınar" },
                new Town { Id = 574, CityId = 42, Ilce = "Kulu" },
                new Town { Id = 575, CityId = 42, Ilce = "Sarayönü" },
                new Town { Id = 576, CityId = 42, Ilce = "Seydişehir" },
                new Town { Id = 577, CityId = 42, Ilce = "Yunak" },
                new Town { Id = 578, CityId = 42, Ilce = "Akören" },
                new Town { Id = 579, CityId = 42, Ilce = "Altınekin" },
                new Town { Id = 580, CityId = 42, Ilce = "Derebucak" },
                new Town { Id = 581, CityId = 42, Ilce = "Hüyük" },
                new Town { Id = 582, CityId = 42, Ilce = "Karatay" },
                new Town { Id = 583, CityId = 42, Ilce = "Meram" },
                new Town { Id = 584, CityId = 42, Ilce = "Selçuklu" },
                new Town { Id = 585, CityId = 42, Ilce = "Taşkent" },
                new Town { Id = 586, CityId = 42, Ilce = "Ahırlı" },
                new Town { Id = 587, CityId = 42, Ilce = "Çeltik" },
                new Town { Id = 588, CityId = 42, Ilce = "Derbent" },
                new Town { Id = 589, CityId = 42, Ilce = "Emirgazi" },
                new Town { Id = 590, CityId = 42, Ilce = "Güneysınır" },
                new Town { Id = 591, CityId = 42, Ilce = "Halkapınar" },
                new Town { Id = 592, CityId = 42, Ilce = "Tuzlukçu" },
                new Town { Id = 593, CityId = 42, Ilce = "Yalıhüyük" },

                // Kütahya ilinin ilçeleri

                new Town { Id = 594, CityId = 43, Ilce = "Altıntaş" },
                new Town { Id = 595, CityId = 43, Ilce = "Domaniç" },
                new Town { Id = 596, CityId = 43, Ilce = "Emet" },
                new Town { Id = 597, CityId = 43, Ilce = "Gediz" },
                new Town { Id = 598, CityId = 43, Ilce = "Merkez" },
                new Town { Id = 599, CityId = 43, Ilce = "Simav" },
                new Town { Id = 600, CityId = 43, Ilce = "Tavşanlı" },
                new Town { Id = 601, CityId = 43, Ilce = "Aslanapa" },
                new Town { Id = 602, CityId = 43, Ilce = "Dumlupınar" },
                new Town { Id = 603, CityId = 43, Ilce = "Hisarcık" },
                new Town { Id = 604, CityId = 43, Ilce = "Şaphane" },
                new Town { Id = 605, CityId = 43, Ilce = "Çavdarhisar" },
                new Town { Id = 606, CityId = 43, Ilce = "Pazarlar" },

                // Malatya ilinin ilçeleri

                new Town { Id = 607, CityId = 44, Ilce = "Akçadağ" },
                new Town { Id = 608, CityId = 44, Ilce = "Arapgir" },
                new Town { Id = 609, CityId = 44, Ilce = "Arguvan" },
                new Town { Id = 610, CityId = 44, Ilce = "Darende" },
                new Town { Id = 611, CityId = 44, Ilce = "Doğanşehir" },
                new Town { Id = 612, CityId = 44, Ilce = "Hekimhan" },
                new Town { Id = 613, CityId = 44, Ilce = "Merkez" },
                new Town { Id = 614, CityId = 44, Ilce = "Pütürge" },
                new Town { Id = 615, CityId = 44, Ilce = "Yeşilyurt" },
                new Town { Id = 616, CityId = 44, Ilce = "Battalgazi" },
                new Town { Id = 617, CityId = 44, Ilce = "Doğanyol" },
                new Town { Id = 618, CityId = 44, Ilce = "Kale" },
                new Town { Id = 619, CityId = 44, Ilce = "Kuluncak" },
                new Town { Id = 620, CityId = 44, Ilce = "Yazıhan" },

                // Manisa ilinin ilçeleri

                new Town { Id = 621, CityId = 45, Ilce = "Akhisar" },
                new Town { Id = 622, CityId = 45, Ilce = "Alaşehir" },
                new Town { Id = 623, CityId = 45, Ilce = "Demirci" },
                new Town { Id = 624, CityId = 45, Ilce = "Gördes" },
                new Town { Id = 625, CityId = 45, Ilce = "Kırkağaç" },
                new Town { Id = 626, CityId = 45, Ilce = "Kula" },
                new Town { Id = 627, CityId = 45, Ilce = "Merkez" },
                new Town { Id = 628, CityId = 45, Ilce = "Salihli" },
                new Town { Id = 629, CityId = 45, Ilce = "Sarıgöl" },
                new Town { Id = 630, CityId = 45, Ilce = "Saruhanlı" },
                new Town { Id = 631, CityId = 45, Ilce = "Selendi" },
                new Town { Id = 632, CityId = 45, Ilce = "Soma" },
                new Town { Id = 633, CityId = 45, Ilce = "Şehzadeler" },
                new Town { Id = 634, CityId = 45, Ilce = "Yunusemre" },
                new Town { Id = 635, CityId = 45, Ilce = "Turgutlu" },
                new Town { Id = 636, CityId = 45, Ilce = "Ahmetli" },
                new Town { Id = 637, CityId = 45, Ilce = "Gölmarmara" },
                new Town { Id = 638, CityId = 45, Ilce = "Köprübaşı" },

                // Kahramanmaraş ilinin ilçeleri

                new Town { Id = 639, CityId = 46, Ilce = "Afşin" },
                new Town { Id = 640, CityId = 46, Ilce = "Andırın" },
                new Town { Id = 641, CityId = 46, Ilce = "Dulkadiroğlu" },
                new Town { Id = 642, CityId = 46, Ilce = "Onikişubat" },
                new Town { Id = 643, CityId = 46, Ilce = "Elbistan" },
                new Town { Id = 644, CityId = 46, Ilce = "Göksun" },
                new Town { Id = 645, CityId = 46, Ilce = "Merkez" },
                new Town { Id = 646, CityId = 46, Ilce = "Pazarcık" },
                new Town { Id = 647, CityId = 46, Ilce = "Türkoğlu" },
                new Town { Id = 648, CityId = 46, Ilce = "Çağlayancerit" },
                new Town { Id = 649, CityId = 46, Ilce = "Ekinözü" },
                new Town { Id = 650, CityId = 46, Ilce = "Nurhak" },

                // Mardin ilinin ilçeleri

                new Town { Id = 651, CityId = 47, Ilce = "Derik" },
                new Town { Id = 652, CityId = 47, Ilce = "Kızıltepe" },
                new Town { Id = 653, CityId = 47, Ilce = "Artuklu" },
                new Town { Id = 654, CityId = 47, Ilce = "Merkez" },
                new Town { Id = 655, CityId = 47, Ilce = "Mazıdağı" },
                new Town { Id = 656, CityId = 47, Ilce = "Midyat" },
                new Town { Id = 657, CityId = 47, Ilce = "Nusaybin" },
                new Town { Id = 658, CityId = 47, Ilce = "Ömerli" },
                new Town { Id = 659, CityId = 47, Ilce = "Savur" },
                new Town { Id = 660, CityId = 47, Ilce = "Dargeçit" },
                new Town { Id = 661, CityId = 47, Ilce = "Yeşilli" },

                // Muğla ilinin ilçeleri

                new Town { Id = 662, CityId = 48, Ilce = "Bodrum" },
                new Town { Id = 663, CityId = 48, Ilce = "Datça" },
                new Town { Id = 664, CityId = 48, Ilce = "Fethiye" },
                new Town { Id = 665, CityId = 48, Ilce = "Köyceğiz" },
                new Town { Id = 666, CityId = 48, Ilce = "Marmaris" },
                new Town { Id = 667, CityId = 48, Ilce = "Menteşe" },
                new Town { Id = 668, CityId = 48, Ilce = "Milas" },
                new Town { Id = 669, CityId = 48, Ilce = "Ula" },
                new Town { Id = 670, CityId = 48, Ilce = "Yatağan" },
                new Town { Id = 671, CityId = 48, Ilce = "Dalaman" },
                new Town { Id = 672, CityId = 48, Ilce = "Seydikemer" },
                new Town { Id = 673, CityId = 48, Ilce = "Ortaca" },
                new Town { Id = 674, CityId = 48, Ilce = "Kavaklıdere" },

                // Muş ilinin ilçeleri

                new Town { Id = 675, CityId = 49, Ilce = "Bulanık" },
                new Town { Id = 676, CityId = 49, Ilce = "Malazgirt" },
                new Town { Id = 677, CityId = 49, Ilce = "Merkez" },
                new Town { Id = 678, CityId = 49, Ilce = "Varto" },
                new Town { Id = 679, CityId = 49, Ilce = "Hasköy" },
                new Town { Id = 680, CityId = 49, Ilce = "Korkut" },

                // Nevşehir ilinin ilçeleri

                new Town { Id = 681, CityId = 50, Ilce = "Avanos" },
                new Town { Id = 682, CityId = 50, Ilce = "Derinkuyu" },
                new Town { Id = 683, CityId = 50, Ilce = "Gülşehir" },
                new Town { Id = 684, CityId = 50, Ilce = "Hacıbektaş" },
                new Town { Id = 685, CityId = 50, Ilce = "Kozaklı" },
                new Town { Id = 686, CityId = 50, Ilce = "Merkez" },
                new Town { Id = 687, CityId = 50, Ilce = "Ürgüp" },
                new Town { Id = 688, CityId = 50, Ilce = "Acıgöl" },

                // Niğde ilinin ilçeleri

                new Town { Id = 689, CityId = 51, Ilce = "Bor" },
                new Town { Id = 690, CityId = 51, Ilce = "Çamardı" },
                new Town { Id = 691, CityId = 51, Ilce = "Merkez" },
                new Town { Id = 692, CityId = 51, Ilce = "Ulukışla" },
                new Town { Id = 693, CityId = 51, Ilce = "Altunhisar" },
                new Town { Id = 694, CityId = 51, Ilce = "Çiftlik" },

                // Ordu ilinin ilçeleri

                new Town { Id = 695, CityId = 52, Ilce = "Akkuş" },
                new Town { Id = 696, CityId = 52, Ilce = "Altınordu" },
                new Town { Id = 697, CityId = 52, Ilce = "Aybastı" },
                new Town { Id = 698, CityId = 52, Ilce = "Fatsa" },
                new Town { Id = 699, CityId = 52, Ilce = "Gölköy" },
                new Town { Id = 700, CityId = 52, Ilce = "Korgan" },
                new Town { Id = 701, CityId = 52, Ilce = "Kumru" },
                new Town { Id = 702, CityId = 52, Ilce = "Mesudiye" },
                new Town { Id = 703, CityId = 52, Ilce = "Perşembe" },
                new Town { Id = 704, CityId = 52, Ilce = "Ulubey" },
                new Town { Id = 705, CityId = 52, Ilce = "Ünye" },
                new Town { Id = 706, CityId = 52, Ilce = "Gülyalı" },
                new Town { Id = 707, CityId = 52, Ilce = "Gürgentepe" },
                new Town { Id = 708, CityId = 52, Ilce = "Çamaş" },
                new Town { Id = 709, CityId = 52, Ilce = "Çatalpınar" },
                new Town { Id = 710, CityId = 52, Ilce = "Çaybaşı" },
                new Town { Id = 711, CityId = 52, Ilce = "İkizce" },
                new Town { Id = 712, CityId = 52, Ilce = "Kabadüz" },
                new Town { Id = 713, CityId = 52, Ilce = "Kabataş" },

                // Rize ilinin ilçeleri

                new Town { Id = 714, CityId = 53, Ilce = "Ardeşen" },
                new Town { Id = 715, CityId = 53, Ilce = "Çamlıhemşin" },
                new Town { Id = 716, CityId = 53, Ilce = "Çayeli" },
                new Town { Id = 717, CityId = 53, Ilce = "Fındıklı" },
                new Town { Id = 718, CityId = 53, Ilce = "İkizdere" },
                new Town { Id = 719, CityId = 53, Ilce = "Kalkandere" },
                new Town { Id = 720, CityId = 53, Ilce = "Pazar" },
                new Town { Id = 721, CityId = 53, Ilce = "Merkez" },
                new Town { Id = 722, CityId = 53, Ilce = "Güneysu" },
                new Town { Id = 723, CityId = 53, Ilce = "Derepazarı" },
                new Town { Id = 724, CityId = 53, Ilce = "Hemşin" },
                new Town { Id = 725, CityId = 53, Ilce = "İyidere" },

                // Sakarya ilinin ilçeleri

                new Town { Id = 726, CityId = 54, Ilce = "Akyazı" },
                new Town { Id = 727, CityId = 54, Ilce = "Geyve" },
                new Town { Id = 728, CityId = 54, Ilce = "Hendek" },
                new Town { Id = 729, CityId = 54, Ilce = "Karasu" },
                new Town { Id = 730, CityId = 54, Ilce = "Kaynarca" },
                new Town { Id = 731, CityId = 54, Ilce = "Sapanca" },
                new Town { Id = 732, CityId = 54, Ilce = "Kocaali" },
                new Town { Id = 733, CityId = 54, Ilce = "Pamukova" },
                new Town { Id = 734, CityId = 54, Ilce = "Taraklı" },
                new Town { Id = 735, CityId = 54, Ilce = "Ferizli" },
                new Town { Id = 736, CityId = 54, Ilce = "Karapürçek" },
                new Town { Id = 737, CityId = 54, Ilce = "Söğütlü" },
                new Town { Id = 738, CityId = 54, Ilce = "Adapazarı" },
                new Town { Id = 739, CityId = 54, Ilce = "Arifiye" },
                new Town { Id = 740, CityId = 54, Ilce = "Erenler" },
                new Town { Id = 741, CityId = 54, Ilce = "Serdivan" },

                // Samsun ilinin ilçeleri

                new Town { Id = 742, CityId = 55, Ilce = "Alaçam" },
                new Town { Id = 743, CityId = 55, Ilce = "Bafra" },
                new Town { Id = 744, CityId = 55, Ilce = "Çarşamba" },
                new Town { Id = 745, CityId = 55, Ilce = "Havza" },
                new Town { Id = 746, CityId = 55, Ilce = "Kavak" },
                new Town { Id = 747, CityId = 55, Ilce = "Ladik" },
                new Town { Id = 748, CityId = 55, Ilce = "Terme" },
                new Town { Id = 749, CityId = 55, Ilce = "Vezirköprü" },
                new Town { Id = 750, CityId = 55, Ilce = "Asarcık" },
                new Town { Id = 751, CityId = 55, Ilce = "Ondokuzmayıs" },
                new Town { Id = 752, CityId = 55, Ilce = "Salıpazarı" },
                new Town { Id = 753, CityId = 55, Ilce = "Tekkeköy" },
                new Town { Id = 754, CityId = 55, Ilce = "Ayvacık" },
                new Town { Id = 755, CityId = 55, Ilce = "Yakakent" },
                new Town { Id = 756, CityId = 55, Ilce = "Atakum" },
                new Town { Id = 757, CityId = 55, Ilce = "Canik" },
                new Town { Id = 758, CityId = 55, Ilce = "İlkadım" },

                // Siirt ilinin ilçeleri

                new Town { Id = 759, CityId = 56, Ilce = "Baykan" },
                new Town { Id = 760, CityId = 56, Ilce = "Eruh" },
                new Town { Id = 761, CityId = 56, Ilce = "Kurtalan" },
                new Town { Id = 762, CityId = 56, Ilce = "Pervari" },
                new Town { Id = 763, CityId = 56, Ilce = "Merkez" },
                new Town { Id = 764, CityId = 56, Ilce = "Şirvan" },
                new Town { Id = 765, CityId = 56, Ilce = "Tillo" },

                // Sinop ilinin ilçeleri

                new Town { Id = 766, CityId = 57, Ilce = "Ayancık" },
                new Town { Id = 767, CityId = 57, Ilce = "Boyabat" },
                new Town { Id = 768, CityId = 57, Ilce = "Durağan" },
                new Town { Id = 769, CityId = 57, Ilce = "Erfelek" },
                new Town { Id = 770, CityId = 57, Ilce = "Gerze" },
                new Town { Id = 771, CityId = 57, Ilce = "Merkez" },
                new Town { Id = 772, CityId = 57, Ilce = "Türkeli" },
                new Town { Id = 773, CityId = 57, Ilce = "Dikmen" },
                new Town { Id = 774, CityId = 57, Ilce = "Saraydüzü" },

                // Sivas ilinin ilçeleri

                new Town { Id = 775, CityId = 58, Ilce = "Divriği" },
                new Town { Id = 776, CityId = 58, Ilce = "Gemerek" },
                new Town { Id = 777, CityId = 58, Ilce = "Gürün" },
                new Town { Id = 778, CityId = 58, Ilce = "Hafik" },
                new Town { Id = 779, CityId = 58, Ilce = "İmranlı" },
                new Town { Id = 780, CityId = 58, Ilce = "Kangal" },
                new Town { Id = 781, CityId = 58, Ilce = "Koyulhisar" },
                new Town { Id = 782, CityId = 58, Ilce = "Merkez" },
                new Town { Id = 783, CityId = 58, Ilce = "Suşehri" },
                new Town { Id = 784, CityId = 58, Ilce = "Şarkışla" },
                new Town { Id = 785, CityId = 58, Ilce = "Yıldızeli" },
                new Town { Id = 786, CityId = 58, Ilce = "Zara" },
                new Town { Id = 787, CityId = 58, Ilce = "Akıncılar" },
                new Town { Id = 788, CityId = 58, Ilce = "Altınyayla" },
                new Town { Id = 789, CityId = 58, Ilce = "Doğanşar" },
                new Town { Id = 790, CityId = 58, Ilce = "Gölova" },
                new Town { Id = 791, CityId = 58, Ilce = "Ulaş" },

                // Tekirdağ ilinin ilçeleri

                new Town { Id = 792, CityId = 59, Ilce = "Çerkezköy" },
                new Town { Id = 793, CityId = 59, Ilce = "Çorlu" },
                new Town { Id = 794, CityId = 59, Ilce = "Ergene" },
                new Town { Id = 795, CityId = 59, Ilce = "Hayrabolu" },
                new Town { Id = 796, CityId = 59, Ilce = "Malkara" },
                new Town { Id = 797, CityId = 59, Ilce = "Muratlı" },
                new Town { Id = 798, CityId = 59, Ilce = "Saray" },
                new Town { Id = 799, CityId = 59, Ilce = "Süleymanpaşa" },
                new Town { Id = 800, CityId = 59, Ilce = "Kapaklı" },
                new Town { Id = 801, CityId = 59, Ilce = "Şarköy" },
                new Town { Id = 802, CityId = 59, Ilce = "Marmaraereğlisi" },

                // Tokat ilinin ilçeleri

                new Town { Id = 803, CityId = 60, Ilce = "Almus" },
                new Town { Id = 804, CityId = 60, Ilce = "Artova" },
                new Town { Id = 805, CityId = 60, Ilce = "Erbaa" },
                new Town { Id = 806, CityId = 60, Ilce = "Niksar" },
                new Town { Id = 807, CityId = 60, Ilce = "Reşadiye" },
                new Town { Id = 808, CityId = 60, Ilce = "Merkez" },
                new Town { Id = 809, CityId = 60, Ilce = "Turhal" },
                new Town { Id = 810, CityId = 60, Ilce = "Zile" },
                new Town { Id = 811, CityId = 60, Ilce = "Pazar" },
                new Town { Id = 812, CityId = 60, Ilce = "Yeşilyurt" },
                new Town { Id = 813, CityId = 60, Ilce = "Başçiftlik" },
                new Town { Id = 814, CityId = 60, Ilce = "Sulusaray" },

                // Trabzon ilinin ilçeleri

                new Town { Id = 815, CityId = 61, Ilce = "Akçaabat" },
                new Town { Id = 816, CityId = 61, Ilce = "Araklı" },
                new Town { Id = 817, CityId = 61, Ilce = "Arsin" },
                new Town { Id = 818, CityId = 61, Ilce = "Çaykara" },
                new Town { Id = 819, CityId = 61, Ilce = "Maçka" },
                new Town { Id = 820, CityId = 61, Ilce = "Of" },
                new Town { Id = 821, CityId = 61, Ilce = "Ortahisar" },
                new Town { Id = 822, CityId = 61, Ilce = "Sürmene" },
                new Town { Id = 823, CityId = 61, Ilce = "Tonya" },
                new Town { Id = 824, CityId = 61, Ilce = "Vakfıkebir" },
                new Town { Id = 825, CityId = 61, Ilce = "Yomra" },
                new Town { Id = 826, CityId = 61, Ilce = "Beşikdüzü" },
                new Town { Id = 827, CityId = 61, Ilce = "Şalpazarı" },
                new Town { Id = 828, CityId = 61, Ilce = "Çarşıbaşı" },
                new Town { Id = 829, CityId = 61, Ilce = "Dernekpazarı" },
                new Town { Id = 830, CityId = 61, Ilce = "Düzköy" },
                new Town { Id = 831, CityId = 61, Ilce = "Hayrat" },
                new Town { Id = 832, CityId = 61, Ilce = "Köprübaşı" },

                // Tunceli ilinin ilçeleri

                new Town { Id = 833, CityId = 62, Ilce = "Çemişgezek" },
                new Town { Id = 834, CityId = 62, Ilce = "Hozat" },
                new Town { Id = 835, CityId = 62, Ilce = "Mazgirt" },
                new Town { Id = 836, CityId = 62, Ilce = "Nazımiye" },
                new Town { Id = 837, CityId = 62, Ilce = "Ovacık" },
                new Town { Id = 838, CityId = 62, Ilce = "Pertek" },
                new Town { Id = 839, CityId = 62, Ilce = "Pülümür" },
                new Town { Id = 840, CityId = 62, Ilce = "Merkez" },

                // Şanlıurfa ilinin ilçeleri

                new Town { Id = 841, CityId = 63, Ilce = "Akçakale" },
                new Town { Id = 842, CityId = 63, Ilce = "Birecik" },
                new Town { Id = 843, CityId = 63, Ilce = "Bozova" },
                new Town { Id = 844, CityId = 63, Ilce = "Ceylanpınar" },
                new Town { Id = 845, CityId = 63, Ilce = "Eyyübiye" },
                new Town { Id = 846, CityId = 63, Ilce = "Halfeti" },
                new Town { Id = 847, CityId = 63, Ilce = "Haliliye" },
                new Town { Id = 848, CityId = 63, Ilce = "Hilvan" },
                new Town { Id = 849, CityId = 63, Ilce = "Karaköprü" },
                new Town { Id = 850, CityId = 63, Ilce = "Siverek" },
                new Town { Id = 851, CityId = 63, Ilce = "Suruç" },
                new Town { Id = 852, CityId = 63, Ilce = "Viranşehir" },
                new Town { Id = 853, CityId = 63, Ilce = "Harran" },

                // Uşak ilinin ilçeleri

                new Town { Id = 854, CityId = 64, Ilce = "Banaz" },
                new Town { Id = 855, CityId = 64, Ilce = "Eşme" },
                new Town { Id = 856, CityId = 64, Ilce = "Karahallı" },
                new Town { Id = 857, CityId = 64, Ilce = "Sivaslı" },
                new Town { Id = 858, CityId = 64, Ilce = "Ulubey" },
                new Town { Id = 859, CityId = 64, Ilce = "Merkez" },

                // Van ilinin ilçeleri

                new Town { Id = 860, CityId = 65, Ilce = "Başkale" },
                new Town { Id = 861, CityId = 65, Ilce = "Çatak" },
                new Town { Id = 862, CityId = 65, Ilce = "Erciş" },
                new Town { Id = 863, CityId = 65, Ilce = "Gevaş" },
                new Town { Id = 864, CityId = 65, Ilce = "Gürpınar" },
                new Town { Id = 865, CityId = 65, Ilce = "İpekyolu" },
                new Town { Id = 866, CityId = 65, Ilce = "Muradiye" },
                new Town { Id = 867, CityId = 65, Ilce = "Özalp" },
                new Town { Id = 868, CityId = 65, Ilce = "Tuşba" },
                new Town { Id = 869, CityId = 65, Ilce = "Bahçesaray" },
                new Town { Id = 870, CityId = 65, Ilce = "Çaldıran" },
                new Town { Id = 871, CityId = 65, Ilce = "Edremit" },
                new Town { Id = 872, CityId = 65, Ilce = "Saray" },

                // Yozgat ilinin ilçeleri

                new Town { Id = 873, CityId = 66, Ilce = "Akdağmadeni" },
                new Town { Id = 874, CityId = 66, Ilce = "Boğazlıyan" },
                new Town { Id = 875, CityId = 66, Ilce = "Çayıralan" },
                new Town { Id = 876, CityId = 66, Ilce = "Çekerek" },
                new Town { Id = 877, CityId = 66, Ilce = "Sarıkaya" },
                new Town { Id = 878, CityId = 66, Ilce = "Sorgun" },
                new Town { Id = 879, CityId = 66, Ilce = "Şefaatli" },
                new Town { Id = 880, CityId = 66, Ilce = "Yerköy" },
                new Town { Id = 881, CityId = 66, Ilce = "Merkez" },
                new Town { Id = 882, CityId = 66, Ilce = "Aydıncık" },
                new Town { Id = 883, CityId = 66, Ilce = "Çandır" },
                new Town { Id = 884, CityId = 66, Ilce = "Kadışehri" },
                new Town { Id = 885, CityId = 66, Ilce = "Saraykent" },
                new Town { Id = 886, CityId = 66, Ilce = "Yenifakılı" },

                // Zonguldak ilinin ilçeleri

                new Town { Id = 887, CityId = 67, Ilce = "Çaycuma" },
                new Town { Id = 888, CityId = 67, Ilce = "Devrek" },
                new Town { Id = 889, CityId = 67, Ilce = "Ereğli" },
                new Town { Id = 890, CityId = 67, Ilce = "Merkez" },
                new Town { Id = 891, CityId = 67, Ilce = "Alaplı" },
                new Town { Id = 892, CityId = 67, Ilce = "Gökçebey" },

                // Aksaray ilinin ilçeleri

                new Town { Id = 893, CityId = 68, Ilce = "Ağaçören" },
                new Town { Id = 894, CityId = 68, Ilce = "Eskil" },
                new Town { Id = 895, CityId = 68, Ilce = "Gülağaç" },
                new Town { Id = 896, CityId = 68, Ilce = "Güzelyurt" },
                new Town { Id = 897, CityId = 68, Ilce = "Merkez" },
                new Town { Id = 898, CityId = 68, Ilce = "Ortaköy" },
                new Town { Id = 899, CityId = 68, Ilce = "Sarıyahşi" },

                // Bayburt ilinin ilçeleri

                new Town { Id = 900, CityId = 69, Ilce = "Merkez" },
                new Town { Id = 901, CityId = 69, Ilce = "Aydıntepe" },
                new Town { Id = 902, CityId = 69, Ilce = "Demirözü" },

                // Karaman ilinin ilçeleri

                new Town { Id = 903, CityId = 70, Ilce = "Ermenek" },
                new Town { Id = 904, CityId = 70, Ilce = "Merkez" },
                new Town { Id = 905, CityId = 70, Ilce = "Ayrancı" },
                new Town { Id = 906, CityId = 70, Ilce = "Kazımkarabekir" },
                new Town { Id = 907, CityId = 70, Ilce = "Başyayla" },
                new Town { Id = 908, CityId = 70, Ilce = "Sarıveliler" },

                // Kırıkkale ilinin ilçeleri

                new Town { Id = 909, CityId = 71, Ilce = "Delice" },
                new Town { Id = 910, CityId = 71, Ilce = "Keskin" },
                new Town { Id = 911, CityId = 71, Ilce = "Merkez" },
                new Town { Id = 912, CityId = 71, Ilce = "Sulakyurt" },
                new Town { Id = 913, CityId = 71, Ilce = "Bahşili" },
                new Town { Id = 914, CityId = 71, Ilce = "Balışeyh" },
                new Town { Id = 915, CityId = 71, Ilce = "Çelebi" },
                new Town { Id = 916, CityId = 71, Ilce = "Karakeçili" },
                new Town { Id = 917, CityId = 71, Ilce = "Yahşihan" },

                // Batman ilinin ilçeleri

                new Town { Id = 918, CityId = 72, Ilce = "Merkez" },
                new Town { Id = 919, CityId = 72, Ilce = "Beşiri" },
                new Town { Id = 920, CityId = 72, Ilce = "Gercüş" },
                new Town { Id = 921, CityId = 72, Ilce = "Kozluk" },
                new Town { Id = 922, CityId = 72, Ilce = "Sason" },
                new Town { Id = 923, CityId = 72, Ilce = "Hasankeyf" },

                // Şırnak ilinin ilçeleri

                new Town { Id = 924, CityId = 73, Ilce = "Beytüşşebap" },
                new Town { Id = 925, CityId = 73, Ilce = "Cizre" },
                new Town { Id = 926, CityId = 73, Ilce = "İdil" },
                new Town { Id = 927, CityId = 73, Ilce = "Silopi" },
                new Town { Id = 928, CityId = 73, Ilce = "Merkez" },
                new Town { Id = 929, CityId = 73, Ilce = "Uludere" },
                new Town { Id = 930, CityId = 73, Ilce = "Güçlükonak" },

                // Bartın ilinin ilçeleri

                new Town { Id = 931, CityId = 74, Ilce = "Merkez" },
                new Town { Id = 932, CityId = 74, Ilce = "Kurucaşile" },
                new Town { Id = 933, CityId = 74, Ilce = "Ulus" },
                new Town { Id = 934, CityId = 74, Ilce = "Amasra" },

                // Ardahan ilinin ilçeleri

                new Town { Id = 935, CityId = 75, Ilce = "Merkez" },
                new Town { Id = 936, CityId = 75, Ilce = "Çıldır" },
                new Town { Id = 937, CityId = 75, Ilce = "Göle" },
                new Town { Id = 938, CityId = 75, Ilce = "Hanak" },
                new Town { Id = 939, CityId = 75, Ilce = "Posof" },
                new Town { Id = 940, CityId = 75, Ilce = "Damal" },

                // Iğdır ilinin ilçeleri

                new Town { Id = 941, CityId = 76, Ilce = "Aralık" },
                new Town { Id = 942, CityId = 76, Ilce = "Merkez" },
                new Town { Id = 943, CityId = 76, Ilce = "Tuzluca" },
                new Town { Id = 944, CityId = 76, Ilce = "Karakoyunlu" },

                // Yalova ilinin ilçeleri

                new Town { Id = 945, CityId = 77, Ilce = "Merkez" },
                new Town { Id = 946, CityId = 77, Ilce = "Altınova" },
                new Town { Id = 947, CityId = 77, Ilce = "Armutlu" },
                new Town { Id = 948, CityId = 77, Ilce = "Çınarcık" },
                new Town { Id = 949, CityId = 77, Ilce = "Çiftlikköy" },
                new Town { Id = 950, CityId = 77, Ilce = "Termal" },

                // Karabük ilinin ilçeleri

                new Town { Id = 951, CityId = 78, Ilce = "Eflani" },
                new Town { Id = 952, CityId = 78, Ilce = "Eskipazar" },
                new Town { Id = 953, CityId = 78, Ilce = "Merkez" },
                new Town { Id = 954, CityId = 78, Ilce = "Ovacık" },
                new Town { Id = 955, CityId = 78, Ilce = "Safranbolu" },
                new Town { Id = 956, CityId = 78, Ilce = "Yenice" },

                // Kilis ilinin ilçeleri

                new Town { Id = 957, CityId = 79, Ilce = "Merkez" },
                new Town { Id = 958, CityId = 79, Ilce = "Elbeyli" },
                new Town { Id = 959, CityId = 79, Ilce = "Musabeyli" },
                new Town { Id = 960, CityId = 79, Ilce = "Polateli" },

                // Osmaniye ilinin ilçeleri

                new Town { Id = 961, CityId = 80, Ilce = "Bahçe" },
                new Town { Id = 962, CityId = 80, Ilce = "Kadirli" },
                new Town { Id = 963, CityId = 80, Ilce = "Merkez" },
                new Town { Id = 964, CityId = 80, Ilce = "Düziçi" },
                new Town { Id = 965, CityId = 80, Ilce = "Hasanbeyli" },
                new Town { Id = 966, CityId = 80, Ilce = "Sumbas" },
                new Town { Id = 967, CityId = 80, Ilce = "Toprakkale" },

                // Düzce ilinin ilçeleri

                new Town { Id = 968, CityId = 81, Ilce = "Akçakoca" },
                new Town { Id = 969, CityId = 81, Ilce = "Merkez" },
                new Town { Id = 970, CityId = 81, Ilce = "Yığılca" },
                new Town { Id = 971, CityId = 81, Ilce = "Cumayeri" },
                new Town { Id = 972, CityId = 81, Ilce = "Gölyaka" },
                new Town { Id = 973, CityId = 81, Ilce = "Çilimli" },
                new Town { Id = 974, CityId = 81, Ilce = "Gümüşova" },
                new Town { Id = 975, CityId = 81, Ilce = "Kaynaşlı" }

            );
        }
    }
}
