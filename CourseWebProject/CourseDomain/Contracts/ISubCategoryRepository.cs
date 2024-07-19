using CourseDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.Contracts
{
    public  interface ISubCategoryRepository: IGenericRepository<SubCategory>
    {
        public Task<bool> IsExistingSubCategory(int? cateId);

    }
}
