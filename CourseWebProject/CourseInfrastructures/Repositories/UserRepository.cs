using CourseDomain;
using CourseDomain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfrastructure.Repositories
{
    internal class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> IsExistingUser(int ?userId)
        {
            return await _entitySet.AnyAsync(u => u.UserId == userId);
        }
       
    }
}
