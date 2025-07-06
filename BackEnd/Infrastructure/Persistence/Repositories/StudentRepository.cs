using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Domain.Entities;
using EduCore.BackEnd.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
{
    internal class StudentRepository : GenericRepository<User>, IStudentRepository
    {
        public StudentRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<User> GetListStudent()
        {
            return _entitySet.Include(st => st.Enrollments).ThenInclude(en=>en.Course).Where(st=>st.RoleId==1);
        }
    }
}
