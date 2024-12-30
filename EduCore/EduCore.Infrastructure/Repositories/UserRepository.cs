using EduCore.Domain;
using EduCore.Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Infrastructure.Repositories
{
    internal class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> IsExistingUser(int? userId)
        {
            return await _entitySet.AnyAsync(u => u.UserId == userId);
        }
        public async Task<User> GetById(int userId)
        {
            return await _entitySet.SingleOrDefaultAsync(u => u.UserId == userId);
        }
        public async Task UpdateUser(User user)
        {
            _entitySet.Update(user);
            await _dbContext.SaveChangesAsync();
        }
        public async Task Add(User user)
        {
            await _dbContext.AddAsync(user);
        }
        public async Task<int> CountAsync()
        {
            return await _entitySet.CountAsync(); // Thay đổi _context.Users theo tên DbSet của bạn
        }
        //public async Task DeleteUserById(int userId)
        //{
        //    var userCourses = _entitySet.FirstOrDefault(u => u.UserId == userId).Courses;
        //    if (userCourses != null)
        //    {
        //        foreach (var c in userCourses)
        //        {
        //            c.InstructorId = null;
        //        }
        //        _dbContext.UpdateRange(userCourses);
        //    }


        //        _dbContext.Remove(_entitySet.Include(u => u.StudentCertificates)
        //            .Include(u => u.Reviews)
        //            .Include(u => u.StudentCourses)
        //            .Include(u => u.SystemSettings)
        //            .Include(u => u.Enrollments)
        //            .Include(u => u.Checkouts).FirstOrDefaultAsync(u => u.UserId == userId));



        //}


    }
}
