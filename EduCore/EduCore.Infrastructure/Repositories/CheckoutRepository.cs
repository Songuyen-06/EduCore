using AutoMapper;
using EduCore.Domain;
using EduCore.Domain.Contracts;
using EduCore.Infrastructure.Repositories;

namespace EduCore.Infrastructure
{
    internal class CheckoutRepository : GenericRepository<Checkout>, ICheckoutRepository
    {
        public CheckoutRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
