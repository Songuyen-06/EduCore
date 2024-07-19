using CourseDomain.Contracts;
using CourseDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseInfrastructure.Repositories
{
    internal class SubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(CoursesDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> IsExistingSubCategory(int? cateId)
        {
            return await _entitySet.AnyAsync(c => c.CategoryId == cateId);

        }
    }
}
