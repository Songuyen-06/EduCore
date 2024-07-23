using CourseDomain.DTOs;

namespace CourseWeb.Services
{
    public interface ICourseService
    {
        public Task<List<CourseDetailDTO>> GetListCoursesByCategoryId(int cateId);
        public  Task<List<CourseDetailDTO>> GetListCoursesBySubCategoryId(int? subCateId);

        public Task<List<CourseDetailDTO>> GetTopSellingCourses();
        public Task<List<CourseDetailDTO>> GetTopSellingCoursesByCateId(int? cateId);
        public Task<CourseDetailDTO> GetCourseDetailByCourseId(int courseId);

        public Task<int> GetNumberCourses();
        public Task<List<CourseDTO>> GetListCourseByInstructorId(int instructorId);

        public int GetNumberPageCourse(int numberCourse);

        public Task<List<CourseDetailDTO>> GetListRelatedCourseBySubcates(List<SubCategoryDetailDTO> subCategories);

        Task<List<CourseDetailDTO>> GetListCourseByStudentId(int stdId, bool isInCart);

        public  Task<int> AddStudentCourse(StudentCourseDTO stC);

    }
}
