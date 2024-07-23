using CourseDomain.DTOs;
using CourseDomain.Models;

namespace CourseWeb.Services
{
    public interface ICategoryService
    {
        Task<CategoryDTO> GetCategoryByCateId(int cateId);
        public Task<List<CategoryDTO>> GetListCategory();
        Task<bool> UpdateCategory(CategoryDTO category);
        Task DeleteCategory(int categoryId);
        Task AddCategory(CategoryDTO category);
        public  Task<int> GetNumberCategories();

    }
}
