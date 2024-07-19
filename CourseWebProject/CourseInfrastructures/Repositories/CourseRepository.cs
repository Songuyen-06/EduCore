
using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
using CourseInfrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfrastructure
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(CoursesDbContext dbContext) : base(dbContext)
        {

        }
        public IQueryable<Course> GetListCourseByInclude()
        {
            return _entitySet.Include(c => c.Instructor).
                Include(c => c.SubCategory).ThenInclude(subc => subc.Category).
                Include(c => c.Sections).ThenInclude(s => s.Lectures).
                  Include(c => c.Reviews).ThenInclude(r => r.Student).
                     Include(c => c.StudentCourses).ThenInclude(sc => sc.User)
                     .ThenInclude(u => u.Role);
        }
        public IQueryable<Course> GetTopSellingCourses()
        {
            return GetListCourseByInclude()
                .OrderByDescending(c => c.Checkouts.Count);
        }


        public async Task<IEnumerable<Course>> GetTopSellingCoursesByCateId(int cateId)
        {

            var c = await GetListCourseByInclude().Where(c => c.SubCategory.CategoryId == cateId)
                .OrderByDescending(c => c.Checkouts.Count).ToListAsync();
            return c;

        }
        //GetListCourseByCategoryId đang thư nghiệm 
        public async Task<IEnumerable<Course>> GetListCourseByCategoryId(int cateId)
        {
            return await GetListCourseByInclude().Where(c => c.SubCategory.CategoryId == cateId).ToListAsync();

        }
        public async Task<IEnumerable<Course>> GetListCourseBySubCategoryId(int subCateId)
        {
            return await GetListCourseByInclude().Where(c => c.SubCategoryId == subCateId).ToListAsync();

        }
        public async Task<Course> GetCourseByCourseId(int courseId)
        {
            return await GetListCourseByInclude().FirstOrDefaultAsync(c => c.CourseId == courseId);

        }

        public async Task<IEnumerable<Course>> GetListCourseByStudentId(int stdId, bool isInCart)
        {
            return await GetListCourseByInclude().
                Where(c => c.StudentCourses.
                Any(sc => sc.UserId == stdId && sc.User.Role.RoleId == 1 && sc.IsInCart == isInCart))
                .ToListAsync();

        }

        public async Task<bool> IsExistingCourse(int courseId)
        {
            return await _entitySet.AnyAsync(c => c.CourseId == courseId);
        }





    }
}
