using AutoMapper;
using CourseDomain;
using CourseDomain.Contracts;
using CourseInfrastructure.Repositories;

namespace CourseInfrastructure
{
    internal class EnrollmentRepository : GenericRepository<Enrollment>,IEnrollmentRepository
    {
        public EnrollmentRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
