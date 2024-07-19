using AutoMapper;
using CourseDomain;
using CourseDomain.Contracts;
using CourseInfrastructure.Repositories;

namespace CourseInfrastructure
{
    internal class CheckoutRepository : GenericRepository<Checkout>, ICheckoutRepository
    {
        public CheckoutRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
