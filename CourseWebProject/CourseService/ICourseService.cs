


using CourseDomain;
using CourseDomain.DTOs;

namespace CourseServices
{
    public interface ICourseService
    {
        Task AddStudentCourse(StudentCourseDTO sc);

        Task<List<CourseDTO>> GetListCourseBySubCategoryId(int cateId);
        public Task<List<CourseDTO>> GetListCourseByCategoryId(int cateId);

        Task<List<CourseDTO>> GetListCourse();
        Task<CourseDTO> GetCourseByCourseId(int id);
        Task<List<CourseDTO>> GetListCourseByStudentId(int stdId, bool isInCart);

         Task AddCourse(  PartialCourseDTO cDTO);
        Task UpdateCourse(PartialCourseDTO cDTO, int courseId);
        Task DeleteCourse(Course course);

        public Task<List<CourseDTO>> GetTopSellingCourses();

        public Task<List<CourseDTO>> GetTopSellingCoursesByCateId(int cateId);

    }
}