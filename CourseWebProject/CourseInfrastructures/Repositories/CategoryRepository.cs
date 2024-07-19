﻿using AutoMapper;
using CourseDomain;
using CourseDomain.Contracts;
using CourseInfrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CourseInfrastructure
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> IsExistingCategory(int? cateId)
        {
            return await _entitySet.AnyAsync(c => c.CategoryId == cateId);

        }
        public IQueryable<Category> GetAllCategory()
        {
            return _entitySet.Include(c => c.SubCategories);
        }
        public async Task<Category> GetCategoryByCateId(int cateId)
        {
            return await GetAllCategory().FirstOrDefaultAsync(c => c.CategoryId == cateId); 

        }
       

        public void Delete(Category category)
        {
            _dbContext.Categories.Remove(category);
        }

    }
}
