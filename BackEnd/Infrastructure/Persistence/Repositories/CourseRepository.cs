﻿
using AutoMapper;

using EduCore.BackEnd.Application.DTOs;
using EduCore.BackEnd.Domain.Contracts;
using EduCore.BackEnd.Domain.Entities;
using EduCore.BackEnd.Infrastructure.Persistence;
using EduCore.BackEnd.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Infrastructure.Persistence.Repositories
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
                     Include(c => c.Enrollments).ThenInclude(e=>e.Student)
                     .ThenInclude(u => u.Role).Include(c=>c.Documents);
        }
        public IQueryable<Course> GetTopSellingCourses()
        {
            return GetListCourseByInclude()
                .OrderByDescending(c => c.Checkouts.Count).Take(8);
        }
       


        public async Task<IEnumerable<Course>> GetTopSellingCoursesByCateId(int cateId)
        {

            var c = await GetListCourseByInclude().Where(c => c.SubCategory.CategoryId == cateId)
                .OrderByDescending(c => c.Checkouts.Count).Take(8).ToListAsync();
            return c;

        }
        public async Task<IEnumerable<Course>> GetTopSellingCoursesBySubCateId(int subCateId)
        {

            var c = await GetListCourseByInclude().Where(c => c.SubCategoryId ==subCateId)
                .OrderByDescending(c => c.Checkouts.Count).Take(8).ToListAsync();
            return c;

        }
        public async Task<IEnumerable<Course>> GetEnrolledCourseListByStudentId(int stdId)
        {
            return await GetListCourseByInclude().
               Where(c => c.Enrollments.Any(e=>e.StudentId==stdId)).ToListAsync();
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


        public async Task<IEnumerable<Course>> GetListCourseByInstructorId(int Id)
        {
            return await GetListCourseByInclude().Where(c => c.InstructorId == Id).ToListAsync();
        }
        public async Task<Course> GetCourseDetailByCourseId(int Id)
        {
            return await GetListCourseByInclude().FirstOrDefaultAsync(c => c.CourseId == Id);
        }
        
    }
}
