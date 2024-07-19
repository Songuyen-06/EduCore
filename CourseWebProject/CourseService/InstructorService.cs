using AutoMapper;
using CourseDomain;
using CourseDomain.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseServices
{
    public  class InstructorService:IInstructorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public InstructorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InstructorDTO>> GetListInstructor()
        {
            return _mapper.Map<IEnumerable<InstructorDTO>>(await _unitOfWork.InstructorRepository.GetListInstructor().ToListAsync());
        }
    }
}
