using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Data.Concrete.EfCore.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.Description).IsRequired();

            builder.HasData
            (
                new Category()
                {
                    Id = 1,
                    Name = "Kasap",
                    Description = "Kasap Kategorisi",
                    ImageUrl = "kasap.jpg",
                },
                new Category()
                {
                    Id = 2,
                    Name = "Eczane",
                    Description = "Eczane Kategorisi",
                    ImageUrl = "eczane.jpg",
                },
                new Category()
                {
                    Id = 3,
                    Name = "Kırtasiye",
                    Description = "Kırtasiye Kategorisi",
                    ImageUrl = "kirtasiye.jpg",
                },
                new Category()
                {
                    Id = 4,
                    Name = "Terzi",
                    Description = "Terzi Kategorisi",
                    ImageUrl = "terzi.jpg",
                },
                new Category()
                {
                    Id = 5,
                    Name = "Dişçi",
                    Description = "Dişçi Kategorisi",
                    ImageUrl = "disci.jpg",
                },
                new Category()
                {
                    Id = 6,
                    Name = "Kiralık Katil",
                    Description = "Kiralık Katil Kategorisi",
                    ImageUrl = "kiralik-katil.jpg",
                },
                new Category()
                {
                    Id = 7,
                    Name = "Gym",
                    Description = "Gym Kategorisi",
                    ImageUrl = "gym.jpg",
                },
                new Category()
                {
                    Id = 8,
                    Name = "Mantıcı",
                    Description = "Mantıcı Kategorisi",
                    ImageUrl = "mantici.jpg",
                },
                new Category()
                {
                    Id = 9,
                    Name = "Futbol Sahası",
                    Description = "Futbol Sahası Kategorisi",
                    ImageUrl = "futbol-sahasi.jpg",
                },
                new Category()
                {
                    Id = 10,
                    Name = "Lostra",
                    Description = "Lostra Kategorisi",
                    ImageUrl = "lostra.jpg",
                },
                new Category()
                {
                    Id = 11,
                    Name = "Bakkal",
                    Description = "Bakkal Kategorisi",
                    ImageUrl = "bakkal.jpg",
                },
                new Category()
                {
                    Id = 12,
                    Name = "Restoran",
                    Description = "Restoran Kategorisi",
                    ImageUrl = "restoran.jpg",
                },
                new Category()
                {
                    Id = 13,
                    Name = "Kafe",
                    Description = "Kafe Kategorisi",
                    ImageUrl = "kafe.jpg",
                },
                new Category()
                {
                    Id = 14,
                    Name = "Butik",
                    Description = "Butik Kategorisi",
                    ImageUrl = "butik.jpg",
                },
                new Category()
                {
                    Id = 15,
                    Name = "Optik",
                    Description = "Optik Kategorisi",
                    ImageUrl = "optik.jpg",
                },
                new Category()
                {
                    Id = 16,
                    Name = "Mobilya Mağazası",
                    Description = "Mobilya Mağazası Kategorisi",
                    ImageUrl = "mobilya.jpg",
                },
                new Category()
                {
                    Id = 17,
                    Name = "Oyuncakçı",
                    Description = "Oyuncakçı Kategorisi",
                    ImageUrl = "oyuncakci.jpg",
                },
                new Category()
                {
                    Id = 18,
                    Name = "Elektronik Mağaza",
                    Description = "Elektronik Mağaza Kategorisi",
                    ImageUrl = "elektronik.jpg",
                },
                new Category()
                {
                    Id = 19,
                    Name = "Çiçekçi",
                    Description = "Çiçekçi Kategorisi",
                    ImageUrl = "cicekci.jpg",
                },
                new Category()
                {
                    Id = 20,
                    Name = "Kitapçı",
                    Description = "Kitapçı Kategorisi",
                    ImageUrl = "kitapci.jpg",
                },
                new Category()
                {
                    Id = 21,
                    Name = "Genel",
                    Description = "Genel Kategorisi",
                    ImageUrl = "genel.jpg",
                }
            );
        }
    }

}
