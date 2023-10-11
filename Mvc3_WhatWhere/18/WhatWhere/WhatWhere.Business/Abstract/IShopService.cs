using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Abstract
{
    public interface IShopService
    {
        // CRUD işlemleri
        Shop GetById(int id);// Bir dükkanı ID'ye göre getir
        List<Shop> GetAll();// Tüm dükkanları getir
        void Create(Shop shop);// Yeni bir dükkan oluştur
        void Update(Shop shop);// Bir şehri güncelle
        void Delete(Shop shop);// Bir şehri sil

        List<Shop> GetAllIncludingCityAndTown();


        Boss GetBossOfShop(int shopId);// Bir dükkânın patronunu getir
        void AssignBossToShop(int shopId, int bossId);// Bir dükkâna bir patron atama
        void RemoveBossFromShop(int shopId);// Bir dükkândan patron çıkarma

        Category GetCategoryOfShop(int shopId);// Dükkânın kategorisini getir
        void AssignCategoryToShop(int shopId, int categoryId);// Bir dükkâna bir kategori atama
        void RemoveCategoryFromShop(int shopId, int categoryId);// Bir dükkândan kategori çıkarma

        City GetCityOfShop(int shopId);// Dükkânın şehrini getir
        void AssignCityToShop(int shopId, int cityId);// Bir dükkâna bir şehir atama
        void RemoveCityFromShop(int shopId);// Bir dükkândan şehir çıkarma

        Town GetTownOfShop(int shopId);// Dükkânın ilçesini getir
        void AssignTownToShop(int shopId, int townId);// Bir dükkâna bir ilçe atama
        void RemoveTownFromShop(int shopId);// Bir dükkândan ilçe çıkarma
    }
}