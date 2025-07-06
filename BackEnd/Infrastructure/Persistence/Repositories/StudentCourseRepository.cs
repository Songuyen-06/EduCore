
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
    public class StudentCourseRepository : GenericRepository<StudentCourse>, IStudentCourseRepository
    {
        public StudentCourseRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
       
    }
}
