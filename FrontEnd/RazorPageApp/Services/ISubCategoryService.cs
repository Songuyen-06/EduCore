using EduCore.BackEnd.Application.DTOs;

namespace EduCore.Web.Services
{
    public interface ISubCategoryService
    {
        public Task<List<SubCategoryDTO>> GetAllSubCategory();
    }
}
