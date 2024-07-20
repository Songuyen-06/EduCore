using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface ICourseService
    {
        public Task<List<CourseDetailDTO>> GetListCoursesByCategoryId(int cateId);
        public  Task<List<CourseDetailDTO>> GetListCoursesBySubCategoryId(int? subCateId);
        public int GetNumberPageCourse(int cateId);

        public Task<List<CourseDetailDTO>> GetTopSellingCourses();
        public Task<List<CourseDetailDTO>> GetTopSellingCoursesByCateId(int? cateId);

        public Task<int> GetNumberCourses();

    }
}
