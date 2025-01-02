using SalesInvoiceTestApi.Repositories;
using SalesInvoiceTestApi.Model;

namespace SalesInvoiceTestApi.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllCategorysAsync() => await _categoryRepository.GetAllAsync();

        public async Task<Category> GetCategoryByIdAsync(int id) => await _categoryRepository.GetByIdAsync(id);

        public async Task AddCategoryAsync(Category category) => await _categoryRepository.AddAsync(category);

        public async Task UpdateCategoryAsync(Category category) => await _categoryRepository.UpdateAsync(category);

        public async Task DeleteCategoryAsync(int id) => await _categoryRepository.DeleteAsync(id);
    }
}
