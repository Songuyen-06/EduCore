using AutoMapper;

using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Domain.Entities;
using EduCore.BackEnd.Infrastructure.Persistence;
using EduCore.BackEnd.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    internal class CheckoutRepository : GenericRepository<StudentCheckout>, ICheckoutRepository
    {
        public CheckoutRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }

        

        public IQueryable<StudentCheckout> GetListCheckoutByInclude()
        {
            return _entitySet.Include(c => c.Course).Include(c => c.Student);
        }

    }
}
