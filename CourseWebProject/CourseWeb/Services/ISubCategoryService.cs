using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface ISubCategoryService
    {
        public Task<List<SubCategoryDTO>> GetAllSubCategory();
    }
}
