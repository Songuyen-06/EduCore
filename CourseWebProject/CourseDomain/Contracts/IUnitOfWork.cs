
using CourseDomain.Contracts;

namespace CourseDomain
{
    public interface IUnitOfWork
    {     
        IUserRepository UserRepository { get; }
        ICourseRepository CourseRepository { get; }
        IReviewRepository ReviewRepository { get; }

        ICategoryRepository CategoryRepository { get; }

        ICheckoutRepository CheckoutRepository { get; }

        IStudentCourseRepository StudentCourseRepository { get; }



        IEnrollmentRepository EnrollmentRepository { get; }

        ISectionRepository SectionRepository { get; }

        ISubCategoryRepository SubCategoryRepository {  get; }

        Task Commit();
        Task Rollback();
    }
}
