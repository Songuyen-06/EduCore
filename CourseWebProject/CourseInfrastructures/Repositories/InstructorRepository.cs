using CourseDomain;
using CourseDomain.Contracts;
using CourseDomain.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfrastructure.Repositories
{
    internal class InstructorRepository : GenericRepository<User>, IInstructorRepository
    {
        public InstructorRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<User> GetListInstructor()
        {
          return  _entitySet.Where(u => u.RoleId == 2).
                Include(u => u.Courses).ThenInclude(c => c.Enrollments)
                  .Include(u => u.Courses).ThenInclude(c => c.SubCategory);
        }
        //public Task<IEnumerable<User>> GetInstructorDetailById(int Id)
        //{

        //      return GetListInstructor.
        //}
    }
}
