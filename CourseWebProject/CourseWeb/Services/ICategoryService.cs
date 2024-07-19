using CourseDomain.DTOs;
using CourseDomain.Models;

namespace CourseWeb.Services
{
    public interface ICategoryService
    {
        Task<CategoryDTO>GetCategoryByCateId(int cateId);
        public Task<List<CategoryDTO>> GetListCategory();

    }
}
