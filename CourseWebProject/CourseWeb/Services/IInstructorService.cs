using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface IInstructorService
    {
        public Task<List<InstructorDTO>> GetListInstructor();
    }
}
