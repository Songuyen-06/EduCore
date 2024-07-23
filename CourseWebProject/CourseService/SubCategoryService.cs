using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
using CourseDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SubCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<SubCategoryDTO>> GetAllSubCategory()
        {
            var subCategories = await _unitOfWork.SubCategoryRepository.GetAllSubCategory();
            return _mapper.Map<List<SubCategoryDTO>>(subCategories);
        }
    }
}
