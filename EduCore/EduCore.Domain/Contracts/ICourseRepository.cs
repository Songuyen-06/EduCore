


using EduCore.Domain.DTOs;

namespace EduCore.Domain
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<IEnumerable<Course>> GetListCourseBySubCategoryId(int subCateId);
        public Task<IEnumerable<Course>> GetListCourseByCategoryId(int cateId);

        public IQueryable<Course> GetListCourseByInclude();

        public Task<IEnumerable<Course>> GetListCourseByInstructorId(int Id);

        public Task<Course> GetCourseByCourseId(int courseId);
        public  Task<IEnumerable<Course>> GetListCourseByStudentId(int stdId, bool isInCart);
        public Task<bool> IsExistingCourse(int courseId);

        public  IQueryable<Course> GetTopSellingCourses();
        public Task<IEnumerable<Course>> GetTopSellingCoursesByCateId(int cateId);

        public Task<Course> GetCourseDetailByCourseId(int Id);


    }
}
