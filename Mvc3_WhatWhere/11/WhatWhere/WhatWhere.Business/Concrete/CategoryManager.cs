using WhatWhere.Business.Abstract;
using WhatWhere.Data.Abstract;
using WhatWhere.Entity.Concrete;

namespace WhatWhere.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public void Create(Category category)
        {
            _categoryRepository.Create(category);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public List<Category> GetCategoriesByShop(int shopId)
        {
            // Repository'den dükkâna göre kategorileri getirmek için ilgili mantığı uygula
            return _categoryRepository.GetCategoriesByShop(shopId);
        }

        public List<Category> GetCategoriesByCity(int cityId)
        {
            // Repository'den şehire göre kategorileri getirmek için ilgili mantığı uygula
            return _categoryRepository.GetCategoriesByCity(cityId);
        }

        public List<Category> GetCategoriesByTown(int townId)
        {
            // Repository'den kasabaya göre kategorileri getirmek için ilgili mantığı uygula
            return _categoryRepository.GetCategoriesByTown(townId);
        }

        public void AssignShopToCategory(int categoryId, int shopId)
        {
            // Repository'de bir kategoriye dükkân atama işlemini gerçekleştirmek için ilgili mantığı uygula
            _categoryRepository.AssignShopToCategory(categoryId, shopId);
        }

        public void RemoveShopFromCategory(int categoryId, int shopId)
        {
            // Repository'den bir kategoriden dükkân çıkarma işlemini gerçekleştirmek için ilgili mantığı uygula
            _categoryRepository.RemoveShopFromCategory(categoryId, shopId);
        }
    }
}
