using EduCore.BackEnd.Application.DTOs;

namespace EduCore.Web.Services
{
    public interface ISectionService
    {
        public Task<List<SectionDTO>> GetAllSectionByCourseId(int courseId);
    }
}
