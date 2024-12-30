using EduCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.Domain.Contracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        public Task<bool> IsExistingCategory(int? cateId);
        public IQueryable<Category> GetAllCategory();
        public Task<Category> GetCategoryByCateId(int cateId);



    }
}