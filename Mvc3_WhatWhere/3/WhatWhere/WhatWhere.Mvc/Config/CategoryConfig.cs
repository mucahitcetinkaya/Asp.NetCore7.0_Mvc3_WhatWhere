using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhatWhere.Mvc.Models;

namespace WhatWhere.Mvc.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
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
