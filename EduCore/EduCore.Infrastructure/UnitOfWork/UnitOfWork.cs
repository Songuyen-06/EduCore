using AutoMapper;
using EduCore.Domain;
using EduCore.Domain.Contracts;
using EduCore.Infrastructure.Repositories;

namespace EduCore.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CoursesDbContext _dbContext;

        private IUserRepository _userRepository;
        private ICourseRepository _courseRepository;
        private IReviewRepository _reviewRepository;
        private IEnrollmentRepository _enrollmentRepository;
        private ICheckoutRepository _checkoutRepository;
        private ICategoryRepository _categoryRepository;
        private ISectionRepository _sectionRepository;

        private ISubCategoryRepository _subCategoryRepository;

        private IInstructorRepository _instructorRepository;

        private IStudentCourseRepository _studentCourseRepository;

        private ICertificateRepositoty _certificateRepositoty;
        public UnitOfWork(CoursesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
        }
        public ICertificateRepositoty CertificateRepositoty => _certificateRepositoty ?? new CertificateRepository(_dbContext);
        public IInstructorRepository InstructorRepository => _instructorRepository ?? new InstructorRepository(_dbContext);
        public ISubCategoryRepository SubCategoryRepository => _subCategoryRepository ?? new SubCategoryRepository(_dbContext);

        public IUserRepository UserRepository => _userRepository ?? new UserRepository(_dbContext);

        public ICourseRepository CourseRepository => _courseRepository ?? new CourseRepository(_dbContext);


        public IReviewRepository ReviewRepository => _reviewRepository ?? new ReviewRepository(_dbContext);


        public ICheckoutRepository CheckoutRepository => _checkoutRepository ?? new CheckoutRepository(_dbContext);


        public IEnrollmentRepository EnrollmentRepository => _enrollmentRepository ?? new EnrollmentRepository(_dbContext);

        public ICategoryRepository CategoryRepository => _categoryRepository ?? new CategoryRepository(_dbContext);

        public ISectionRepository SectionRepository => _sectionRepository ?? new SectionRepository(_dbContext);

        public IStudentCourseRepository StudentCourseRepository => _studentCourseRepository ?? new StudentCourseRepository(_dbContext);

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task Rollback()
        {
            await _dbContext.DisposeAsync();
        }


    }
}
