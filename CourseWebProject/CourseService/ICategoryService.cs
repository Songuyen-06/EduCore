using CourseDomain;
using CourseDomain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryDTO>> GetListCategory();
        public Task<CategoryDTO> GetCategoryByCateId(int cateId);
        Task AddCategory(CategoryDTO cDTO);
        Task UpdateCategory(CategoryDTO cDTO);
        Task DeleteCategory(int cateId);
    }
}
