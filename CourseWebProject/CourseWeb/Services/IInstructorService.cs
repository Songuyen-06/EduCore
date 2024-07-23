using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface IInstructorService
    {
        public Task<List<InstructorDTO>> GetListInstructor();

        public Task<List<InstructorDTO>> GetListInstructorByFilter(int cateId, int? subCateId);
        public Task<int> GetNumberInstructors();
        public int GetNumberPageInstructor(int numberInstructor);
        public Task<InstructorDetailDTO> GetInstructorDetailById(int id);


    }
}
