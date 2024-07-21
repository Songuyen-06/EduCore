using CourseDomain;
using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface ICourseService
    {
        public Task<List<CourseDTO>> GetListCoursesByCategoryId(int cateId);
        public  Task<List<CourseDTO>> GetListCoursesBySubCategoryId(int? subCateId);
        public int GetNumberPageCourse(int cateId);

        public Task<CourseDTO> getCourseByCourseId(int courseId);

        public Task<List<CourseDTO>> GetTopSellingCourses();
        public Task<List<CourseDTO>> GetTopSellingCoursesByCateId(int? cateId);

        public Task<List<CourseDTO>> GetListCourseByInstructorId(int instructorId);
         public CourseDTO CreateCourse(CourseDTO course);
    }
}
