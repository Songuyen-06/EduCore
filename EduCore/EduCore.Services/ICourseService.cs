


using EduCore.Domain;
using EduCore.Domain.DTOs;

namespace EduCore.Services
{
    public interface ICourseService
    {
        Task AddStudentCourse(StudentCourseDTO sc);

        Task<List<CourseDetailDTO>> GetListCourseBySubCategoryId(int cateId);
        public Task<List<CourseDetailDTO>> GetListCourseByCategoryId(int cateId);

        Task<List<CourseDetailDTO>> GetListCourse();
        Task<CourseDetailDTO> GetCourseByCourseId(int id);
        Task<List<CourseDetailDTO>> GetListCourseByStudentId(int stdId, bool isInCart);

         Task AddCourse( CourseDTO cDTO);
        Task UpdateCourse(CourseDTO cDTO, int courseId);
        Task DeleteCourse(Course course);

        Task<List<CourseDTO>>ListCourseByStudentId(int stdId, bool isInCart);
        public Task<List<CourseDetailDTO>> GetTopSellingCourses();

        public Task<List<CourseDetailDTO>> GetTopSellingCoursesByCateId(int cateId);
        public Task<List<CourseDTO>> GetListCourseByInstructorId(int instructorId);
        public  Task<CourseDetailDTO> GetCourseDetailByCourseId(int cId);

    }
}