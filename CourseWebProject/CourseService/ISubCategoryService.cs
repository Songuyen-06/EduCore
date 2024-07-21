using CourseDomain.DTOs;
using CourseDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public interface ISubCategoryService
    {
        public Task<List<SubCategoryDTO>> GetAllSubCategory();
    }
}
