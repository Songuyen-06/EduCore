using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface ISectionService
    {
        public Task<List<SectionDTO>> GetAllSectionByCourseId(int courseId);
    }
}
