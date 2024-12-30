using AutoMapper;
using EduCore.Domain;
using EduCore.Domain.Contracts;
using EduCore.Infrastructure.Repositories;

namespace EduCore.Infrastructure
{
    internal class EnrollmentRepository : GenericRepository<Enrollment>,IEnrollmentRepository
    {
        public EnrollmentRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
