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

        public async Task CreateAsync(Category category)
        {
            await _categoryRepository.CreateAsync(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public async Task<List<Category>> GetAllAsync()
        {
           return await _categoryRepository.GetAllAsync();
        }

        public async Task<List<Category>> GetAllCategoriesAsync(bool isDeleted, bool? isActive = null)
        {
            var result = await _categoryRepository.GetAllCategoriesAsync(isDeleted, isActive);
            return result;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
