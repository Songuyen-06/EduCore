using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface ICourseService
    {
        public Task<List<CourseDetailDTO>> GetListCoursesByCategoryId(int cateId);
        public  Task<List<CourseDetailDTO>> GetListCoursesBySubCategoryId(int? subCateId);

        public Task<List<CourseDetailDTO>> GetTopSellingCourses();
        public Task<List<CourseDetailDTO>> GetTopSellingCoursesByCateId(int? cateId);
        public Task<CourseDTO> getCourseByCourseId(int courseId);

        public Task<int> GetNumberCourses();
        public Task<List<CourseDTO>> GetListCourseByInstructorId(int instructorId);

        public int GetNumberPageCourse(int numberCourse);

    }
}
